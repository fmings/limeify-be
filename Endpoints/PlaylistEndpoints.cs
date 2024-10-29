using Limeify.Interfaces;
using Limeify.Models;

namespace Limeify.Endpoints
{
    public class PlaylistEndpoints
    {
        public static void Map(WebApplication app)
        {
            // get all playlists
            app.MapGet("/api/playlists", async (IPlaylistService playlistService) =>
            {
                return await playlistService.GetPlaylistsAsync();
            })
            .Produces<List<Playlist>>(StatusCodes.Status200OK);

            // get all playlists by uid
            app.MapGet("/api/user/{uid}/playlists", async (IPlaylistService playlistService, string uid) =>
            {
                return await playlistService.GetPlaylistsByUidAsync(uid);
            })
            .Produces<List<Playlist>>(StatusCodes.Status200OK);

            // get single playlist by id and include list of songs on playlist
            app.MapGet("/api/playlists/{id}", async (IPlaylistService playlistService, int id) =>
            {
                Playlist selectedPlaylist = await playlistService.GetPlaylistByIdAsync(id);
                return Results.Ok(selectedPlaylist);
            })
            .Produces<Playlist>(StatusCodes.Status200OK);

            // create a new playlist
            app.MapPost("/api/playlists", async (IPlaylistService playlistService, Playlist playlist) =>
            {
                var newPlaylist = await playlistService.CreatePlaylistAsync(playlist);
                return Results.Created($"/api/playlist/{playlist.Id}", playlist);
            })
            .Produces<Playlist>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            // update a playlist
            app.MapPut("/api/playlists/{id}", async (IPlaylistService playlistService, int id, Playlist updatedDetails) =>
            {
                var playlistToUpdate = await playlistService.UpdatePlaylistAsync(id, updatedDetails);
                return Results.Ok(playlistToUpdate);
            })
            .Produces<Playlist>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status204NoContent);

            // delete a playlist
            app.MapDelete("/api/playlists/{id}", async (IPlaylistService playlistService, int id) =>
            {
                var playlistToDelete = await playlistService.DeletePlaylistAsync(id);
                return Results.NoContent();
            })
            .Produces<Playlist>(StatusCodes.Status204NoContent);
        }
    }
}