using limeify_be;

namespace Limeify.API
{
    public class CategoryAPI
    {
        public static void Map(WebApplication app)
        {
            // get all categories
            app.MapGet("/api/categories", (LimeifyDbContext db) =>
            {
                return db.Genres.ToList();
            });
        }
    }
}