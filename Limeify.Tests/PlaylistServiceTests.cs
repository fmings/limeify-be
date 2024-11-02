using Xunit;
using Moq;
using Limeify.Interfaces;
using Limeify.Services;
using Limeify.Models;

namespace Limeify.Tests;

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

        _mockPlaylistRepository.Setup(repo => repo.CreatePlaylistAsync(newPlaylist)).ReturnsAsync(newPlaylist);
        var actualPlaylist = await _playlistService.CreatePlaylistAsync(newPlaylist);
        Assert.Equal(newPlaylist.Id, actualPlaylist.Id);
    }

    [Fact]
    public async Task UpdatePlaylistAsync_ShouldReturnTrue_WhenPlaylistExists()
    {

    }

    [Fact]
    public async Task UpdatePlaylistAsync_ShouldReturnFalse_WhenPlaylistDoesNotExist()
    {

    }
}