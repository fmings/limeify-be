using Limeify.Models;

namespace Limeify.Interfaces
{
    public interface IPlaylistRepository
    {
        Task<List<Playlist>> GetPlaylistsAsync();
        Task<List<Playlist>> GetPublicPlaylistsAsync();
        Task<List<Playlist>> GetPlaylistsByUidAsync(string uid);
        Task<Playlist> GetPlaylistByIdAsync(int id);
        Task<Playlist> CreatePlaylistAsync(Playlist playlist);
        Task<Playlist> UpdatePlaylistAsync(int id, Playlist playlist);
        Task<Playlist> DeletePlaylistAsync(int id);
    }
}