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
            app.MapPost("/api/songs/{songId}/add-to-playlist/{playlistId}", (LimeifyDbContext db, int songId, int playlistId) =>
            {
                var song = db.Songs.Include(s => s.Playlists).FirstOrDefault(s => s.Id == songId);
                var playlist = db.Playlists.Include(p => p.Songs).FirstOrDefault(p => p.Id == playlistId);

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
                db.SaveChanges();

                return Results.Created($"/api/songs/{songId}/add-to-playlist/{playlistId}", playlist);
            });

            // Remove song from playlist
            app.MapDelete("/api/playlists/{playlistId}/remove-song/{songId}", (LimeifyDbContext db, int playlistId, int songId) =>
            {
                var playlist = db.Playlists.Include(p => p.Songs).FirstOrDefault(p => p.Id == playlistId);

                // Fetch the song to be removed
                var song = db.Songs.FirstOrDefault(s => s.Id == songId);

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

                db.SaveChanges();

                return Results.Ok("Song removed from the playlist.");
            });

        }
    }
}