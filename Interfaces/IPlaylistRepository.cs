using Limeify.Models;

namespace Limeify.Interfaces
{
    public interface IPlaylistRepository
    {
        // An interface is a contract that defines the signature of the functionality.
        // It defines a set of methods that a class that inherits the interface MUST implement.
        // The interface is a mechanism to achieve abstraction.
        // Interfaces can be used in unit testing to mock out the actual implementation.

        Task<List<Playlist>> GetPlaylistsAsync();
        Task<List<Playlist>> GetPlaylistsByUidAsync(string uid);
        Task<Playlist> GetPlaylistByIdAsync(int id);
        Task<Playlist> CreatePlaylistAsync(Playlist playlist);
        Task<Playlist> UpdatePlaylistAsync(int id, Playlist playlist);
        Task<Playlist> DeletePlaylistAsync(int id);
    }
}