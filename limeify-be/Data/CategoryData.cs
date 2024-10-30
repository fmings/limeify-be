using Limeify.Models;

namespace Limeify.Data
{
    public class CategoryData
    {
        public static List<Category> Categories = new()
        {
            new Category
            {
                Id = 1,
                Name = "Relaxing"
            },
            new Category
            {
                Id = 2,
                Name = "Dance"
            },
            new Category
            {
                Id = 3,
                Name = "Classics"
            },
            new Category
            {
                Id = 4,
                Name = "Indie"
            },
            new Category
            {
                Id = 5,
                Name = "Workout"
            }
        };
    }
}