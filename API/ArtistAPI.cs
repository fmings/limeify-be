using limeify_be;

namespace Limeify.API
{
    public class ArtistAPI
    {
        public static void Map(WebApplication app)
        {
            // get a single artist
            app.MapGet("/api/artists/{id}", (LimeifyDbContext db, int id) =>
            {
                return db.Artists.SingleOrDefault(artist => artist.Id == id);
            });
        }
    }
}