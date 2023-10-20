using SD2_eindopdracht.Models;

namespace SD2_eindopdracht.Data
{
    public static class Seeder
    {
        public static void CategorySeeder(ApplicationDbContext context)
        {
            if (context.Category.Any())
            {
                return;
            }

            var categories = new string[] { "Boek", "CD", "Game", "DVD", "Blu-Ray" };
            var categoryId = 1;

            foreach (var category in categories)
            {
                context.Category.Add(new Category
                {
                    Id = categoryId,
                    Name = category
                });

                categoryId++;
                
            }

            context.SaveChanges();
        }
    }
}
