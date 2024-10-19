using limeify_be;

namespace Limeify.API
{
    public class ArtistAPI
    {
        public static void Map(WebApplication app)
        {
            // Get all Artist
            app.MapGet("/api/artist", (LimeifyDbContext db) =>
            {
                return db.Artists.ToList();
            });
        }
    }
}
