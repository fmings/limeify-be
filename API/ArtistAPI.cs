namespace Limeify.API
{
    public class ArtistAPI
    {
        public static void Map(WebApplication app)
        {
            // get all artists
            app.MapGet("/api/artists", (LimeifyDbContext db) =>
            {
                return db.Artists.ToList();
            });

            // get a single artist
            app.MapGet("/api/artists/{id}", (LimeifyDbContext db, int id) =>
            {
                return db.Artists.SingleOrDefault(artist => artist.Id == id);
            });
        }
    }
}