using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SD2_eindopdracht.Models;
using System.Reflection.Emit;


namespace SD2_eindopdracht.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Subscription> Subscription { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Boek" },
                new Category { Id = 2, Name = "CD" },
                new Category { Id = 3, Name = "Game" },
                new Category { Id = 4, Name = "DVD" },
                new Category { Id = 5, Name = "Blu-Ray" }
                );
        }
    }

}