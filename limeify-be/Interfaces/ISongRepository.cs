namespace Limeify.Interfaces
{
    public interface ISongRepository
    {
        Task<IResult> RemoveSongFromPlaylistAsync(int playlistId, int songId);
        Task<IResult> AddSongToPlaylistAsync(int songId, int playlistId);
    }
}