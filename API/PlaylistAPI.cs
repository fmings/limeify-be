using Limeify.Models;
using limeify_be;
using Microsoft.EntityFrameworkCore;

namespace Limeify.API
{
    public class PlaylistAPI
    {
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
            app.MapGet("/api/playlist/{id}", (LimeifyDbContext db, int id) =>
            {
                Playlist selectedPlaylist = db.Playlists
                    .Include(p => p.Songs)
                    .FirstOrDefault(p => p.Id == id);

                return selectedPlaylist;

            });

            // CREATE A NEW PLAYLIST
            app.MapPost("/api/playlist", (LimeifyDbContext db, Playlist playlist) =>
            {
                db.Playlists.Add(playlist);
                db.SaveChanges();
                return Results.Created($"/api/playlist/{playlist.Id}", playlist);
            });

            // UPDATE A PLAYLIST
            app.MapPut("/api/playlist/{id}", (LimeifyDbContext db, int id, Playlist updatedDetails) =>
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
            app.MapDelete("/api/playlist/{id}", (LimeifyDbContext db, int id) =>
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
