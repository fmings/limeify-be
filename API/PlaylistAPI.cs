using Limeify.Models;
using Microsoft.EntityFrameworkCore;

namespace Limeify.API
{
    public class PlaylistAPI
    {
        // The endpoint layer is responsible for handling HTTP requests.
        // The endpoint layer will call the service layer to process business logic.
        // The endpoint layer will return the data to the client.
        // The endpoint layer is the entry point for the client to access the application.
        // We must register this MapWeatherEndpoints method in the Program.cs file.
        // You can click the reference to see where it is registered in the Program.cs file.

        public static void Map(WebApplication app)
        {
            // GET ALL PLAYLISTS
            app.MapGet("/api/playlists", (LimeifyDbContext db) =>
            {
                return db.Playlists.ToList();
            });

            // GET ALL PLAYLISTS BY UID
            app.MapGet("/api/user/{uid}/playlists", (LimeifyDbContext db, string uid) =>
            {
                List<Playlist> userPlaylists = db.Playlists.Where(p => p.Uid == uid).ToList();
                return userPlaylists;
            });

            // GET SINGLE PLAYLIST BY ID AND INCLUDE LIST OF SONGS ON PLAYLIST
            app.MapGet("/api/playlists/{id}", (LimeifyDbContext db, int id) =>
            {
                Playlist selectedPlaylist = db.Playlists
                    .Include(p => p.Songs)
                    .FirstOrDefault(p => p.Id == id);

                return selectedPlaylist;
            });

            // CREATE A NEW PLAYLIST
            app.MapPost("/api/playlists", (LimeifyDbContext db, Playlist playlist) =>
            {
                db.Playlists.Add(playlist);
                db.SaveChanges();
                return Results.Created($"/api/playlist/{playlist.Id}", playlist);
            });

            // UPDATE A PLAYLIST
            app.MapPut("/api/playlists/{id}", (LimeifyDbContext db, int id, Playlist updatedDetails) =>
            {
                Playlist playlistToUpdate = db.Playlists.FirstOrDefault(p => p.Id == id);
                if (playlistToUpdate == null)
                {
                    return Results.NotFound();
                }

                playlistToUpdate.Name = updatedDetails.Name;
                playlistToUpdate.CategoryId = updatedDetails.CategoryId;
                playlistToUpdate.Image = updatedDetails.Image;

                db.SaveChanges();

                return Results.Ok(playlistToUpdate);
            });

            // DELETE A PLAYLIST
            app.MapDelete("/api/playlists/{id}", (LimeifyDbContext db, int id) =>
            {
                Playlist playlistToDelete = db.Playlists.FirstOrDefault(p => p.Id == id);
                if (playlistToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Playlists.Remove(playlistToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}