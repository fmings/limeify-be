using Limeify.Interfaces;
using Limeify.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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
    public async Task RemoveSongFromPlaylist_ShouldReturnNoContent_WhenSongRemoved()
    {
        // Arrange - means to set up the test
        var songId = 1;
        var playlistId = 2;

        // The Setup method is used to set up the behavior of the mock object.
        _mockSongRepository.Setup(repo => repo.RemoveSongFromPlaylistAsync(playlistId, songId)).ReturnsAsync(Results.NoContent());

        // Act - means to run the test
        // The RemoveSongFromPlaylistAsync method is called with the songId and playlistId parameters.
        var result =  await _songService.RemoveSongFromPlaylistAsync(playlistId, songId);

        // Assert - means to check the result
        // No Content is returned by the RemoveSongFromPlaylistAsync.
        Assert.IsType<NoContent>(result);
    }

    [Fact]
    public async Task RemoveSongFromPlaylist_ShouldReturnBadRequest_WhenSongRemoved()
    {
        // Arrange
        var songId = 99;
        var playlistId = 2;

        // The Setup method is used to set up the behavior of the mock object.
        _mockSongRepository.Setup(repo => repo.RemoveSongFromPlaylistAsync(playlistId, songId)).ReturnsAsync(Results.BadRequest());

        // Act - means to run the test
        // The RemoveSongFromPlaylistAsync method is called with the songId and playlistId parameters.
        var result = await _songService.RemoveSongFromPlaylistAsync(playlistId, songId);

        // Assert - means to check the result
        // Bad Request is returned by the RemoveSongFromPlaylistAsync when song does not exist on playlist.
        Assert.IsType<BadRequest>(result);
    }

    [Fact]
    public async Task AddSongToPlaylist_ShouldReturnOK_WhenSongAdded()
    {
        // Arrange
        var songId = 4;
        var playlistId = 3;

        // The Setup method is used to set up the behavior of the mock object.
        _mockSongRepository.Setup(repo => repo.AddSongToPlaylistAsync(playlistId, songId)).ReturnsAsync(Results.Created());

        // Act - means to run the test
        // The AddSongToPlaylistAsync method is called with the songId and playlistId parameters.
        var result = await _songService.AddSongToPlaylistAsync(playlistId, songId);

        // Assert - means to check the result
        // Created is returned when the song is added to the playlist.
        Assert.IsType<Created>(result);
    }

    [Fact]
    public async Task AddSongToPlaylist_ShouldReturnNotFound_WhenSongDoesNotExist()
    {
        // Arrange
        var songId = 99;
        var playlistId = 1;

        // The Setup method is used to set up the behavior of the mock object.
        _mockSongRepository.Setup(repo => repo.AddSongToPlaylistAsync(playlistId, songId)).ReturnsAsync(Results.NotFound());

        // Act - means to run the test
        // The AddSongToPlaylistAsync method is called with the songId and playlistId parameters.
        var result = await _songService.AddSongToPlaylistAsync(playlistId, songId);

        // Assert - means to check the result
        // Not Found is returned by the AddSongToPlaylistAsync when the song does not exist..
        Assert.IsType<NotFound>(result);
    }

    [Fact]
    public async Task AddSongToPlaylist_ShouldReturnNotFound_WhenPlaylistDoesNotExist()
    {
        // Arrange
        var songId = 3;
        var playlistId = 99;

        // The Setup method is used to set up the behavior of the mock object.
        _mockSongRepository.Setup(repo => repo.AddSongToPlaylistAsync(playlistId, songId)).ReturnsAsync(Results.NotFound());

        // Act - means to run the test
        // The AddSongToPlaylistAsync method is called with the songId and playlistId parameters.
        var result = await _songService.AddSongToPlaylistAsync(playlistId, songId);

        // Assert - means to check the result
        // Not Found is returned by the AddSongToPlay when the playlist does not exist..
        Assert.IsType<NotFound>(result);
    }

    [Fact]
    public async Task AddSongToPlaylist_ShouldReturnBadRequest_WhenSongAlreadyOnPlaylist()
    {
        // Arrange
        var songId = 4;
        var playlistId = 3;

        // The Setup method is used to set up the behavior of the mock object.
        _mockSongRepository.Setup(repo => repo.AddSongToPlaylistAsync(playlistId, songId)).ReturnsAsync(Results.BadRequest());

        // Act - means to run the test
        // The AddSongToPlaylistAsync method is called with the songId and playlistId parameters.
        var result = await _songService.AddSongToPlaylistAsync(playlistId, songId);

        // Assert - means to check the result
        // Bad Request is returned by the AddSongToPlay when the playlist does not exist..
        Assert.IsType<BadRequest>(result);
    }
}