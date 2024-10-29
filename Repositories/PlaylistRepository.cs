using Limeify.Interfaces;
using Limeify.Models;
using Microsoft.EntityFrameworkCore;

namespace Limeify.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly LimeifyDbContext dbContext;

        public PlaylistRepository(LimeifyDbContext context)
        {
            dbContext = context;
        }

        // get all playlists
        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            return await dbContext.Playlists.ToListAsync();
        }

        // get all playlists by uid
        public async Task<List<Playlist>> GetPlaylistsByUidAsync(string uid)
        {
            List<Playlist> userPlaylists = await dbContext.Playlists.Where(p => p.Uid == uid).ToListAsync();
            return userPlaylists;
        }

        // get single playlist by id and include list of songs on playlist
        public async Task<Playlist> GetPlaylistByIdAsync(int id)
        {
            Playlist selectedPlaylist = await dbContext.Playlists
                .Include(p => p.Songs)
                    .ThenInclude(s => s.Album)
                .Include(p => p.Songs)
                    .ThenInclude(s => s.Artist)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);

            return selectedPlaylist;
        }

        // create a playlist
        public async Task<Playlist> CreatePlaylistAsync(Playlist playlist)
        {
            await dbContext.Playlists.AddAsync(playlist);
            await dbContext.SaveChangesAsync();
            return playlist;
        }

        // update a playlist
        public async Task<Playlist> UpdatePlaylistAsync(int id, Playlist updatedDetails)
        {
            var playlistToUpdate = await dbContext.Playlists.FirstOrDefaultAsync(p => p.Id == id);

            if (playlistToUpdate == null)
            {
                return null;
            }

            playlistToUpdate.Name = updatedDetails.Name;
            playlistToUpdate.CategoryId = updatedDetails.CategoryId;
            playlistToUpdate.Image = updatedDetails.Image;

            await dbContext.SaveChangesAsync();
            return updatedDetails;
        }

        // delete a playlist
        public async Task<Playlist> DeletePlaylistAsync(int id)
        {
            var playlistToDelete = await dbContext.Playlists.FirstOrDefaultAsync(p => p.Id == id);

            if (playlistToDelete == null)
            {
                return null;
            }

            dbContext.Playlists.Remove(playlistToDelete);
            await dbContext.SaveChangesAsync();
            return playlistToDelete;
        }
    }
}