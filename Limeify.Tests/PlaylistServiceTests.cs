using Limeify.Interfaces;
using Limeify.Models;
using Limeify.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Moq;
using Xunit;

namespace Limeify.Tests
{
    public class PlaylistServiceTests
    {
        private readonly PlaylistService _playlistService;
        private readonly Mock<IPlaylistRepository> _mockPlaylistRepository;

        public PlaylistServiceTests()
        {
            _mockPlaylistRepository = new Mock<IPlaylistRepository>();
            _playlistService = new PlaylistService(_mockPlaylistRepository.Object);
        }

        [Fact]
        public async Task GetPlaylistsAsync_ShouldReturnListOfPlaylists()
        {
            // Arrange
            var playlists = new List<Playlist>
            {
                new Playlist { Id = 1, Name = "Chill Vibes" },
                new Playlist { Id = 2, Name = "Workout Beats" }
            };

            _mockPlaylistRepository.Setup(repo => repo.GetPlaylistsAsync()).ReturnsAsync(playlists);

            // Act
            var result = await _playlistService.GetPlaylistsAsync();

            // Assert
            _mockPlaylistRepository.Verify(repo => repo.GetPlaylistsAsync(), Times.Once);
            Assert.Equal(playlists.Count, result.Count);
            Assert.Equal(playlists[0].Id, result[0].Id);
            Assert.Equal(playlists[1].Id, result[1].Id);
        }

        [Fact]
        public async Task DeletePlaylistAsync_ShouldReturnDeletedPlaylist_WhenPlaylistDeleted()
        {
            // Arrange
            var playlistId = 1;
            var deletedPlaylist = new Playlist { Id = playlistId, Name = "Chill Vibes" };

            _mockPlaylistRepository
                .Setup(repo => repo.DeletePlaylistAsync(playlistId))
                .ReturnsAsync(deletedPlaylist);

            // Act
            var result = await _playlistService.DeletePlaylistAsync(playlistId);

            // Assert
            _mockPlaylistRepository.Verify(repo => repo.DeletePlaylistAsync(playlistId), Times.Once);
            Assert.IsType<Playlist>(result);
            Assert.Equal(deletedPlaylist.Id, result.Id);
        }

        [Fact]
        public async Task DeletePlaylistAsync_ShouldReturnNotFound_WhenPlaylistDoesNotExist()
        {
            // Arrange
            var playlistId = 99;

            _mockPlaylistRepository
                .Setup(repo => repo.DeletePlaylistAsync(playlistId))
                .ReturnsAsync((Playlist)null); // Simulating not found

            // Act
            var result = await _playlistService.DeletePlaylistAsync(playlistId);

            // Assert
            _mockPlaylistRepository.Verify(repo => repo.DeletePlaylistAsync(playlistId), Times.Once);
            Assert.IsType<NotFound>(result); // Ensure it returns NotFound
        }
    }
}
