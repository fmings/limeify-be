using Microsoft.EntityFrameworkCore;
using Limeify.Models;
using Limeify.Data;
using Limeify.DTOs;

namespace limeify_be
{
    public class LimeifyDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PlaylistSongDTO> PlaylistSongs { get; set; }

        public LimeifyDbContext(DbContextOptions<LimeifyDbContext> context) : base(context) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(AlbumData.Albums);
            modelBuilder.Entity<Artist>().HasData(ArtistData.Artists);
            modelBuilder.Entity<Category>().HasData(CategoryData.Categories);
            modelBuilder.Entity<Genre>().HasData(GenreData.Genres);
            modelBuilder.Entity<Playlist>().HasData(PlaylistData.Playlists);
            modelBuilder.Entity<Song>().HasData(SongData.Songs);
            modelBuilder.Entity<User>().HasData(UserData.Users);

        }

    }

}
