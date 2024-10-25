using Limeify.Interfaces;

namespace Limeify.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public async Task<IResult> RemoveSongFromPlaylistAsync(int playlistId, int songId)
        {
            return await _songRepository.RemoveSongFromPlaylistAsync(songId, playlistId);
        }

        public async Task<IResult> AddSongToPlaylistAsync(int songId, int playlistId)
        {
            return await _songRepository.AddSongToPlaylistAsync(songId, playlistId);
        }
    }
}
