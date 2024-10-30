using Limeify.Models;

namespace Limeify.Data
{
    public class UserData
    {
        public static List<User> Users = new()
        {
            new User
            {
                Id = 1,
                Uid = "C0wunKp1sIQRM9YR48JnQPlNXt92",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Image = "https://example.com/images/john_doe.png",
                Artist = false
            },
            new User
            {
                Id = 2,
                Uid = "D1zpqWr2bJUPO7YP39LkWPqMYu64",
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Image = "https://example.com/images/jane_smith.png",
                Artist = false
            },
            new User
            {
                Id = 3,
                Uid = "E2fopHs3cIKQM8YS50MjYPmOZr85",
                FirstName = "Alice",
                LastName = "Brown",
                Email = "alice.brown@example.com",
                Image = "https://example.com/images/alice_brown.png",
                Artist = false
            },
            new User
            {
                Id = 4,
                Uid = "F3grqUt4dLKRN9ZT61NkZQqPBr96",
                FirstName = "Bob",
                LastName = "Johnson",
                Email = "bob.johnson@example.com",
                Image = "https://example.com/images/bob_johnson.png",
                Artist = false
            },
            new User
            {
                Id = 5,
                Uid = "G4hsvVv5eMPRO0AU72OlASrQCr07",
                FirstName = "Charlie",
                LastName = "Williams",
                Email = "charlie.williams@example.com",
                Image = "https://example.com/images/charlie_williams.png",
                Artist = false
            }
        };
    }
}