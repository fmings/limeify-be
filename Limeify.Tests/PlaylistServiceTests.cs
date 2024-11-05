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
        public async Task CreatePlaylistAsync_ShouldReturnNewPlaylistId()
        {
            var newPlaylist = new Playlist
            {
                Id = 6,
                Name = "New Playlist",
                CategoryId = 1,
                Image = "https://www.afrocharts.com/images/song_cover.png",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92",
                IsPublic = false,
            };

            _mockPlaylistRepository
                .Setup(repo => repo.CreatePlaylistAsync(newPlaylist))
                .ReturnsAsync(newPlaylist);

            var actualPlaylist = await _playlistService.CreatePlaylistAsync(newPlaylist);

            Assert.Equal(newPlaylist.Id, actualPlaylist.Id);
        }

        [Fact]
        public async Task UpdatePlaylistAsync_ShouldReturnUpdatedPlaylist_WhenPlaylistExists()
        {
            var updatedPlaylist = new Playlist
            {
                Id = 6,
                Name = "Updated Playlist",
                CategoryId = 1,
                Image = "https://www.afrocharts.com/images/song_cover.png",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92",
                IsPublic = false,
            };

            _mockPlaylistRepository
                .Setup(repo => repo.UpdatePlaylistAsync(updatedPlaylist.Id, updatedPlaylist))
                .ReturnsAsync(updatedPlaylist);

            var result = await _playlistService.UpdatePlaylistAsync(updatedPlaylist.Id, updatedPlaylist);

            Assert.Equal(updatedPlaylist, result);
        }

        [Fact]
        public async Task UpdatePlaylistAsync_ShouldReturnNull_WhenPlaylistDoesNotExist()
        {
            var nonExistentPlaylistId = 999;
            var updatedPlaylist = new Playlist
            {
                Id = nonExistentPlaylistId,
                Name = "Non-existent Playlist",
                CategoryId = 1,
                Image = "https://www.afrocharts.com/images/song_cover.png",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92",
                IsPublic = false,
            };

            _mockPlaylistRepository
                .Setup(repo => repo.UpdatePlaylistAsync(nonExistentPlaylistId, updatedPlaylist))
                .ReturnsAsync((Playlist)null);

            var result = await _playlistService.UpdatePlaylistAsync(nonExistentPlaylistId, updatedPlaylist);

            Assert.Null(result);
        }

        [Fact]
        public async Task DeletePlaylistAsync_ShouldReturnDeletedPlaylist_WhenPlaylistDeleted()
        {
            var playlistId = 1;
            var deletedPlaylist = new Playlist { Id = playlistId, Name = "Chill Vibes" };

            _mockPlaylistRepository
                .Setup(repo => repo.DeletePlaylistAsync(playlistId))
                .ReturnsAsync(deletedPlaylist);

            var result = await _playlistService.DeletePlaylistAsync(playlistId);

            _mockPlaylistRepository.Verify(repo => repo.DeletePlaylistAsync(playlistId), Times.Once);
            Assert.IsType<Playlist>(result);
            Assert.Equal(deletedPlaylist.Id, result.Id);
        }

        [Fact]
        public async Task DeletePlaylistAsync_ShouldReturnNotFound_WhenPlaylistDoesNotExist()
        {
            var playlistId = 99;

            _mockPlaylistRepository
                .Setup(repo => repo.DeletePlaylistAsync(playlistId))
                .ReturnsAsync((Playlist)null); 

            var result = await _playlistService.DeletePlaylistAsync(playlistId);

            _mockPlaylistRepository.Verify(repo => repo.DeletePlaylistAsync(playlistId), Times.Once);
            Assert.Null(result);
        }
    }
}
