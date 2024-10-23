using Microsoft.EntityFrameworkCore;

namespace Limeify.API
{
    public class SongAPI
    {
        public static void Map(WebApplication app)
        {
            // get all songs
            app.MapGet("/api/songs", (LimeifyDbContext db) =>
            {
                return db.Songs
                    .Include(s => s.Artist)
                    .Include(s => s.Album)
                    .Include(s => s.Genre)
                    .ToListAsync();
            });

            // get song by id
            app.MapGet("/api/songs/{id}", (LimeifyDbContext db, int id) =>
            {
                var song = db.Songs
                    .Include(s => s.Artist)
                    .Include(s => s.Album)
                    .Include(s => s.Genre)
                    .FirstOrDefault(s => s.Id == id);

                if (song == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(song);
            });

            // add song to playlist
            app.MapPost("/api/songs/{songId}/add-to-playlist/{playlistId}", async (LimeifyDbContext db, int songId, int playlistId) =>
            {
                var song = await db.Songs.Include(s => s.Playlists).FirstOrDefaultAsync(s => s.Id == songId);
                var playlist = await db.Playlists.Include(p => p.Songs).FirstOrDefaultAsync(p => p.Id == playlistId);

                if (playlist == null || song == null)
                {
                    return Results.NotFound("Playlist or song not found.");
                }

                // check if the playlist already contains the song
                if (playlist.Songs.Any(s => s.Id == songId))
                {
                    return Results.BadRequest("Song already exists in the playlist.");
                }

                // add the song to the playlist
                playlist.Songs.Add(song);
                await db.SaveChangesAsync();

                return Results.Created($"/api/songs/{songId}/add-to-playlist/{playlistId}", playlist);
            });

            // Remove song from playlist
            app.MapDelete("/api/playlists/{playlistId}/remove-song/{songId}", async(LimeifyDbContext db, int playlistId, int songId) =>
            {
                var playlist = await db.Playlists.Include(p => p.Songs).FirstOrDefaultAsync(p => p.Id == playlistId);

                // Fetch the song to be removed
                var song = await db.Songs.FirstOrDefaultAsync(s => s.Id == songId);

                if (playlist == null || song == null)
                {
                    return Results.NotFound("Playlist or song not found.");
                }

                // Check if the song exists in the playlist
                if (!playlist.Songs.Any(s => s.Id == songId))
                {
                    return Results.BadRequest("Song does not exist in the playlist.");
                }

                playlist.Songs.Remove(song);

                await db.SaveChangesAsync();

                return Results.Ok("Song removed from the playlist.");
            });

        }
    }
}