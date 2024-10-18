using Limeify.Models;
using limeify_be;
using Microsoft.EntityFrameworkCore;

namespace Limeify.API
{
    public class SongAPI
    {
        public static void Map(WebApplication app)
        {
            // GET All Songs
            app.MapGet("/api/songs", (LimeifyDbContext db) =>
            {
                return db.Songs
                    .Include(s => s.Artist)
                    .Include(s => s.Album)
                    .Include(s => s.Genre)
                    .ToListAsync();
            });

            //GET Songs By Id
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
        }
    }
}
