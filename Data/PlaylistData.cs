using Limeify.Models;

namespace Limeify.Data
{
    public class PlaylistData
    {
        public static List<Playlist> Playlists = new()
        {
            new Playlist
            {
                Id = 1,
                Name = "Chill Vibes",
                CategoryId = 1,
                Image = "https://example.com/images/chill_vibes.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt91"
            },
            new Playlist
            {
                Id = 2,
                Name = "Party Hits",
                CategoryId = 2,
                Image = "https://example.com/images/party_hits.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92"
            },
            new Playlist
            {
                Id = 3,
                Name = "Throwback Classics",
                CategoryId = 3,
                Image = "https://example.com/images/throwback_classics.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt93"
            },
            new Playlist
            {
                Id = 4,
                Name = "Indie Discoveries",
                CategoryId = 4,
                Image = "https://example.com/images/indie_discoveries.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt94"
            },
            new Playlist
            {
                Id = 5,
                Name = "Workout Energy",
                CategoryId = 5,
                Image = "https://example.com/images/workout_energy.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt95"
            }
        };
    }
}