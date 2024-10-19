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

            // add song to playlist
            app.MapPost("/api/songs/{songId}/add-to-playlist/{playlistId}", (LimeifyDbContext db, int songId, int playlistId) =>
            {
                var song = db.Songs.Find(songId);
                var playlist = db.Playlists.Find(playlistId);

                if (playlistId == null || song == null)
                {
                    return Results.NotFound("Playlist or song not found.");
                }

                // check if the playlist already contains the song
                var existingPlaylistSong = db.PlaylistSong.FirstOrDefault(pp => pp.PlaylistId == playlistId && pp.SongId == songId);

                if (existingPlaylistSong != null)
                {
                    return Results.BadRequest("Song already exists in the playlist.");
                }

                db.Playlists.Songs.Add(song);
                db.SaveChanges();

                return Results.Created($"/api/songs/{songId}/add-to-playlist/{playlistId}", playlistId);
            });
        }
    }
}