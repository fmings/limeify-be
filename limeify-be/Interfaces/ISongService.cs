namespace Limeify.Interfaces
{
    public interface ISongService
    {
        Task<IResult> RemoveSongFromPlaylistAsync(int playlistId, int songId);
        Task<IResult> AddSongToPlaylistAsync(int songId, int playlistId);
    }
}