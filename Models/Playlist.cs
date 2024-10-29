namespace Limeify.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Image {  get; set; }
        public string Uid { get; set; }
        public bool IsPublic { get; set; }
        public List<Song> Songs { get; set; }
    }
}