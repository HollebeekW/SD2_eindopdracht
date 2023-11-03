using Bogus;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SD2_eindopdracht.Models;
using System.Net.Cache;

namespace SD2_eindopdracht.Data
{
    public static class Seeder
    {
        public static List<Author> AuthorList = new List<Author>();
        public static List<Item> ItemList = new List<Item>();
        public static List<IdentityUser> IdentityUserList = new List<IdentityUser>();
        public static List<ApplicationUser> ApplicationUserList = new List<ApplicationUser>();

        //seed categories
        public static Category[] CategorySeeder()
        {
            var categories = new string[] { "Boek", "CD", "Game", "DVD", "Blu-Ray" };
            var categoryId = 1;
            var categoryList = new List<Category>();

            foreach (var categoryName in categories)
            {
                categoryList.Add(new Category
                {
                    Id = categoryId,
                    Name = categoryName
                });

                categoryId++;
            }

            return categoryList.ToArray();
        }

        //seed subscription types
        public static Subscription[] SubscriptionSeeder()
        {
            var subscriptions = new[]
            {
                //Jeugd
                new Subscription
                {
                    Id = 1,
                    Name = "Jeugd",
                    MinAge = 0,
                    MaxAge = 17,
                    YearlyItems = null,
                    ItemsAtOnce = null,
                    LoanPeriod = 3,
                    Extensions = 3,
                    ReservationPrice = 0.25m,
                    DailyFine = 0m,
                    SubscriptionPrice = 0m
                },

                //Budget
                new Subscription
                {
                    Id = 2,
                    Name = "Budget",
                    MinAge = 18,
                    MaxAge = null,
                    YearlyItems = 10,
                    ItemsAtOnce = 10,
                    LoanPeriod = 3,
                    Extensions = 1,
                    ReservationPrice = 0.25m,
                    DailyFine = 0.30m,
                    SubscriptionPrice = 1m
                },

                //Basis
                new Subscription
                {
                    Id = 3,
                    Name = "Basis",
                    MinAge = 18,
                    MaxAge = null,
                    YearlyItems = null,
                    ItemsAtOnce = null,
                    LoanPeriod = 3,
                    Extensions = 3,
                    ReservationPrice = 0.25m,
                    DailyFine = 0.30m,
                    SubscriptionPrice = 4m
                },

                //Top
                new Subscription
                {
                    Id = 4,
                    Name = "Top",
                    MinAge = 18,
                    MaxAge = null,
                    YearlyItems = null,
                    ItemsAtOnce= null,
                    LoanPeriod = 3,
                    Extensions = 5,
                    ReservationPrice = 0m,
                    DailyFine = 0m,
                    SubscriptionPrice = 6m
                }
            };

            return subscriptions.ToArray();
        }
       
        public static async Task Init(int AuthorCount, int ItemCount,int UserCount) //2 values, for amount of authors, items and users
        {
            //fake authors
            var authorId = 1;
            var authorFaker = new Faker<Author>()
                .RuleFor(a => a.Id, f => authorId++) //auto increment id
                .RuleFor(a => a.FirstName, f => f.Name.FirstName()) //random first name
                .RuleFor(a => a.LastName, f => f.Name.LastName()); //random last name

            //fake items
            var itemId = 1;
            var itemFaker = new Faker<Item>()
                .RuleFor(i => i.Id, f => itemId++) //auto increment id
                .RuleFor(i => i.Title, f => f.Commerce.ProductName()) //product name may be changed
                .RuleFor(i => i.Description, f => f.Commerce.ProductDescription()) //product desciption may be changed
                .RuleFor(i => i.YearOfRelease, f => f.Random.Number(2000,2023))
                .RuleFor(i => i.Stock, f => f.Random.Number(0,10))
                .RuleFor(i => i.AuthorId, f => f.Random.Number(1, AuthorList.Count)) //random number between 1 and amount of existing authors
                .RuleFor(i => i.CategoryId, f => f.Random.Number(1, 5)); //random number between 1 and 5, because there are 5 categories when seeding

            //fake users
            var userId = 1;
            var userFaker = new Faker<ApplicationUser>()
                .RuleFor(u => u.Id, f => (userId++).ToString())
                .RuleFor(u => u.UserName, f => f.Internet.UserName())
                .RuleFor(u => u.NormalizedUserName, (f, u) => u.UserName.ToUpper())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.NormalizedEmail, (f, u) => u.Email.ToUpper())
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.Age, f => f.Random.Number(12, 80))
                .RuleFor(u => u.SubscriptionId, (f, u) =>
                {
                    if (u.Age >= 18)
                    {
                        return f.Random.Number(2, 4); //if age is 18+, don't allow jeugd subscription
                    }
                    else
                    {
                        return 1; //if age is lower than 18, only allow jeugd subscription
                    }
                });

            //generate authors and items, amount is set in DbContext
            AuthorList = authorFaker.Generate(AuthorCount);
            ItemList = itemFaker.Generate(ItemCount);
            ApplicationUserList = userFaker.Generate(UserCount);

        }
    }
}
