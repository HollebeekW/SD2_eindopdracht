using Microsoft.AspNetCore.Identity;
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

            builder.Entity<Category>().HasData(Seeder.CategorySeeder()); //seed categories

            builder.Entity<Subscription>().HasData(Seeder.SubscriptionSeeder()); //seed subscription types
            
            Seeder.Init(20, 100, 100); //20 authors, 100 items and 100 users

            builder.Entity<Author>().HasData(Seeder.AuthorList); //seed authors with fake data
            builder.Entity<Item>().HasData(Seeder.ItemList); //seed items with fake data
            builder.Entity<ApplicationUser>().HasData(Seeder.ApplicationUserList); //seed users with fake data

        }
    }

}