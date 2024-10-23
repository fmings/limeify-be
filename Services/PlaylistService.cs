using Limeify.Interfaces;
using Limeify.Models;

namespace Limeify.Services
{
    public class PlaylistService : IPlaylistService
    {
        // The service layer is responsible for processing business logic.
        // Right now, the service layer is just calling the repository layer.
        // The service layer will call the repository layer to do the actual CRUD operations.
        // The service layer will return the data to the endpoint (controller).

        private readonly IPlaylistRepository _playlistRepository;

        // This constructor is used for dependency injection.
        // We are injecting the IWeatherForecastRepository interface into the WeatherForecastService class.
        // We inject the repository interface instead of the actual repository class.
        // This is because we can easily mock the interface for unit testing.
        // It also makes our code more flexible and easier to maintain.
        // The type of DI used here is called constructor injection.

        public PlaylistService(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }

        // async means that the method is asynchronous.
        // async methods can be awaited using the await keyword.
        // async methods return a Task or Task<T>.
        // Task represents an asynchronous operation that can return a value.
        // Task<T> is a task that returns a value.
        // To get the value, we use the await keyword.

        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            return await _playlistRepository.GetPlaylistsAsync();
        }

        public async Task<Playlist> GetPlaylistsByUidAsync(string uid)
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