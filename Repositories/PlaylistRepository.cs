using Limeify.Interfaces;
using Limeify.Models;
using Microsoft.EntityFrameworkCore;

namespace Limeify.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        // The repository layer is responsible for CRUD operations.
        // This repository class implements the IWeatherForecastRepository interface.
        // Remember: the interface is a contract that defines methods that a class MUST implement.
        // The repository layer will call the database context to do the actual CRUD operations.
        // The repository layer will return the data to the service layer.

        private readonly LimeifyDbContext dbContext;

        public PlaylistRepository(LimeifyDbContext context)
        {
            dbContext = context;
        }

        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            return await dbContext.Playlists.ToListAsync();
        }

        public async Task<List<Playlist>> GetPlaylistsByUidAsync(string uid)
        {
            return await dbContext.Playlists.ToListAsync();
        }

        public async Task<Playlist> GetPlaylistByIdAsync(int id)
        {
            return await dbContext.Playlists.FindAsync(id);
        }

        public async Task<Playlist> CreatePlaylistAsync(Playlist playlist)
        {
            dbContext.Playlists.Add(playlist);
            await dbContext.SaveChangesAsync();
            return playlist;
        }

        public async Task<Playlist> UpdatePlaylistAsync(int id, Playlist playlist)
        {
            var existingPlaylist = await dbContext.Playlists.FindAsync(id);

            if (existingPlaylist == null)
            {
                return null;
            }

            existingPlaylist.Name = playlist.Name;
            existingPlaylist.CategoryId = playlist.CategoryId;
            existingPlaylist.Image = playlist.Image;

            await dbContext.SaveChangesAsync();
            return playlist;
        }

        public async Task<Playlist> DeletePlaylistAsync(int id)
        {
            var playlist = await dbContext.Playlists.FindAsync(id);

            if (playlist == null)
            {
                return null;
            }

            dbContext.Playlists.Remove(playlist);
            await dbContext.SaveChangesAsync();
            return playlist;
        }
    }
}