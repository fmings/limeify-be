using Limeify.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Limeify.Repositories
{
    public class SongRepository : ISongRepository
    {
        private readonly LimeifyDbContext dbContext;

        public SongRepository(LimeifyDbContext context)
        {
            dbContext = context;
        }

        public async Task<IResult> RemoveSongFromPlaylistAsync(int songId, int playlistId)
        {
            // fetch the playlist along with the songs
            var playlist = await dbContext.Playlists.Include(p => p.Songs).FirstOrDefaultAsync(p => p.Id == playlistId);

            // Fetch the song to be removed
            var song = await dbContext.Songs.FirstOrDefaultAsync(s => s.Id == songId);

            // check if playlist or song doesn't exist
            if (playlist == null || song == null)
            {
                return Results.NotFound("Playlist or song not found.");
            }

            // Check if the song exists in the playlist
            if (!playlist.Songs.Any(s => s.Id == songId))
            {
                return Results.BadRequest("Song does not exist in the playlist.");
            }

            // remove song from the playlist
            playlist.Songs.Remove(song);

            // save the changes to the database
            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        }

        public async Task<IResult> AddSongToPlaylistAsync(int songId, int playlistId)
        {
            // fetch the song along with it's playlists
            var song = await dbContext.Songs.Include(s => s.Playlists).FirstOrDefaultAsync(s => s.Id == songId);

            // fetch the playlist along with it's songs
            var playlist = await dbContext.Playlists.Include(p => p.Songs).FirstOrDefaultAsync(p => p.Id == playlistId);

            // check if the playlist or song doesn't exist
            if (playlist == null || song == null)
            {
                return Results.NotFound("Playlist or song not found.");
            }

            // check if the playlist already contains the song
            if (playlist.Songs.Any(s => s.Id == songId))
            {
                return Results.BadRequest("Song already exists in the playlist.");
            }

            // add the song to the playlist
            playlist.Songs.Add(song);

            // save the changes to the database
            await dbContext.SaveChangesAsync();
            return Results.Created($"/api/songs/{songId}/add-to-playlist/{playlistId}", playlist);
        }
    }
}