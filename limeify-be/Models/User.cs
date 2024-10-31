namespace Limeify.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Image {  get; set; }
        public bool Artist { get; set; }
    }
}