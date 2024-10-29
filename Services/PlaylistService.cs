using Limeify.Interfaces;
using Limeify.Models;

namespace Limeify.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _playlistRepository;

        public PlaylistService(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }

        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            return await _playlistRepository.GetPlaylistsAsync();
        }

        public async Task<List<Playlist>> GetPublicPlaylistsAsync()
        {
            return await _playlistRepository.GetPublicPlaylistsAsync();
        }

        public async Task<List<Playlist>> GetPlaylistsByUidAsync(string uid)
        {
            return await _playlistRepository.GetPlaylistsByUidAsync(uid);
        }

        public async Task<Playlist> GetPlaylistByIdAsync(int id)
        {
            return await _playlistRepository.GetPlaylistByIdAsync(id);
        }

        public async Task<Playlist> CreatePlaylistAsync(Playlist playlist)
        {
            return await _playlistRepository.CreatePlaylistAsync(playlist);
        }

        public async Task<Playlist> UpdatePlaylistAsync(int id, Playlist playlist)
        {
            return await _playlistRepository.UpdatePlaylistAsync(id, playlist);
        }

        public async Task<Playlist> DeletePlaylistAsync(int id)
        {
            return await _playlistRepository.DeletePlaylistAsync(id);
        }
    }
}