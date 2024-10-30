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
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoJpfC3FIYyvcvdKVu0C7aCgqPG9N8EnnfLA&s",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt91"
            },
            new Playlist
            {
                Id = 2,
                Name = "Party Hits",
                CategoryId = 2,
                Image = "https://i1.sndcdn.com/artworks-myKVvYfZpg0PzyNa-ZUliJQ-t500x500.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92"
            },
            new Playlist
            {
                Id = 3,
                Name = "Throwback Classics",
                CategoryId = 3,
                Image = "https://i1.sndcdn.com/artworks-000223861579-icm151-t500x500.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt93"
            },
            new Playlist
            {
                Id = 4,
                Name = "Indie Discoveries",
                CategoryId = 4,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRSASIn6nOKM53C64poBVRru1Cc-oONhdTUiw&s",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt94"
            },
            new Playlist
            {
                Id = 5,
                Name = "Workout Energy",
                CategoryId = 5,
                Image = "https://www.funslurp.com/images/baby-buff-1.jpg",
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt95"
            }
        };
    }
}