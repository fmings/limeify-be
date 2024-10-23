using Limeify.Models;

namespace Limeify.Interfaces
{
    public interface IPlaylistService
    {
        // The service layer is responsible for processing business logic.
        // The service layer will call the repository layer to do the actual CRUD operations.

        Task<List<Playlist>> GetPlaylistsAsync();
        Task<Playlist> GetPlaylistsByUidAsync(string uid);
        Task<Playlist> GetPlaylistByIdAsync(int id);
        Task<Playlist> CreatePlaylistAsync(Playlist playlist);
        Task<Playlist> UpdatePlaylistAsync(int id, Playlist playlist);
        Task<Playlist> DeletePlaylistAsync(int id);
    }
}