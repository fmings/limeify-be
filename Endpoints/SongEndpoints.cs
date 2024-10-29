using Limeify.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Limeify.Endpoints
{
    public class SongEndpoints
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

            // search songs
            //app.MapGet("/api/songs/search", (LimeifyDbContext db, string searchValue) =>
            //{
            //    var searchResults = db.Songs
            //        .Where(song =>
            //            song.Name.ToLower().Contains(searchValue.ToLower()) ||
            //            song.Artist.Name.ToLower().Contains(searchValue.ToLower())
            //});

            // add song to playlist
            app.MapPost("/api/songs/{songId}/add-to-playlist/{playlistId}", async (ISongService songService, int songId, int playlistId) =>
            {
                var result = await songService.AddSongToPlaylistAsync(songId, playlistId);
                return result;
            })
            .Produces<IResult>(StatusCodes.Status204NoContent);

            // remove song from playlist
            app.MapDelete("/api/songs/{songId}/remove-from-playlist/{playlistId}", async (ISongService songService, int playlistId, int songId) =>
            {
                var result = await songService.RemoveSongFromPlaylistAsync(playlistId, songId);
                return result;
            })
            .Produces<IResult>(StatusCodes.Status204NoContent);
        }
    }
}