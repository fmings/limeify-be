using limeify_be;

namespace Limeify.API
{
    public class SongAPI
    {
        public static void Map(WebApplication app)
        {
            // add song to playlist
            app.MapGet("/api/songs/{songId}/add-to-playlist/{playlistId}", (LimeifyDbContext db, int songId, int playlistId) =>
            {
                var song = db.Songs.Find(songId);
                var podcast = db.Playlists.Find(playlistId);

                if (playlistId == null || song == null)
                {
                    return Results.NotFound("Playlist or song not found.");

                    // check if the playlist already contains the song
                }
            });
        }
    }
}