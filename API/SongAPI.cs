using Limeify.Interfaces;
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
            app.MapPost("/api/songs/{songId}/add-to-playlist/{playlistId}", async (ISongRepository songRepository, int songId, int playlistId) =>
            {
                var result = await songRepository.AddSongToPlaylistAsync(songId, playlistId);

                return result;
            })
            .Produces<IResult>(StatusCodes.Status204NoContent);

            // Remove song from playlist
            app.MapDelete("/api/playlists/{playlistId}/remove-song/{songId}", async (ISongRepository songRepository, int playlistId, int songId) =>
            {
                var result = await songRepository.RemoveSongFromPlaylistAsync(playlistId, songId);

                return result;
            })
            .Produces<IResult>(StatusCodes.Status204NoContent);

        }
    }
}