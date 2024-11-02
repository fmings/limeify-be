using Xunit;
using Moq;
using Limeify.Interfaces;
using Limeify.Services;

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
    public void Test1()
    {

    }
}