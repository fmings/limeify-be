﻿namespace Limeify.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public string Image {  get; set; }
        public List<Song> Songs { get; set; }
    }
}