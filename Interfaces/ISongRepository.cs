namespace Limeify.Interfaces
{
    public interface ISongRepository
    {
        Task<IResult> RemoveSongFromPlaylistAsync(int songId, int playlistId);
        Task<IResult> AddSongToPlaylistAsync(int songId, int playlistId);
    }
}