using Limeify.Interfaces;
using Limeify.Services;
using Moq;
namespace Limeify.Tests;

public class SongTests
{
    private readonly SongService _songService;

    private readonly Mock<ISongRepository> _mockSongRepository;

    public SongTests()
    {
        _mockSongRepository = new Mock<ISongRepository>();
        _songService = new SongService( _mockSongRepository.Object);
    }

    [Fact]
    public void RemoveSongFromPlaylist_ShouldReturnTrue_WhenSongRemoved()
    {
        // Arrange - means to set up the test
        var songId = 1;
        var playlistId = 2;

        // The Setup method is used to set up the behavior of the mock object.
        _mockSongRepository.Setup(repo => repo.RemoveSongFromPlaylistAsync(playlistId, songId)).Returns(true);

        // Act - means to run the test
        // The GetBookById method is called with the bookId parameter.
        var result = _mockSongRepository.RemoveSongFromPlaylistAsync(playlistId, songId);

        // Assert - means to check the result
        // The actualBook returned by the GetBookById method should be null.
        Assert.True(result);
    }

    [Fact]
    public void RemoveSongFromPlaylist_ShouldReturnBadRequest_WhenSongRemoved()
    {

    }

    [Fact]
    public void AddSongToPlaylist_ShouldReturnOK_WhenSongAdded()
    {

    }

    [Fact]
    public void AddSongToPlaylist_ShouldReturnNull_WhenSongDoesNotExist()
    {

    }
}