namespace Limeify.Endpoints
{
    public class CategoryEndpoints
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