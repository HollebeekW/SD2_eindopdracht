using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SD2_eindopdracht.Data;
using SD2_eindopdracht.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BibliotheekS1117975;Trusted_Connection=True;MultipleActiveResultSets=true";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true) //disable need to confirm email (may be changed later)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

//role creation
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "Employee", "User" };
    var roleId = 1;

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

//user creation
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    var password = "Pass1!";

    if (await userManager.FindByEmailAsync("admin@email.com") == null)
    {
        var adminUser = new IdentityUser();
        adminUser.Email = "admin@email.com";
        adminUser.UserName = "admin@email.com"; //won't work without it, idk why
        adminUser.LockoutEnabled = false;
        adminUser.EmailConfirmed = true;

        await userManager.CreateAsync(adminUser, password);

        await userManager.AddToRoleAsync(adminUser, "Admin");
    }

    if (await userManager.FindByEmailAsync("employee@email.com") == null)
    {
        var adminUser = new IdentityUser();
        adminUser.Email = "employee@email.com";
        adminUser.UserName = "employee@email.com"; //same here, won't work without it
        adminUser.LockoutEnabled = false;
        adminUser.EmailConfirmed = true;

        await userManager.CreateAsync(adminUser, password);

        await userManager.AddToRoleAsync(adminUser, "Employee");
    }

    if (await userManager.FindByEmailAsync("user@email.com") == null)
    {
        var adminUser = new IdentityUser();
        adminUser.Email = "user@email.com";
        adminUser.UserName = "user@email.com"; //same here, won't work without it
        adminUser.LockoutEnabled = false;
        adminUser.EmailConfirmed = true;

        await userManager.CreateAsync(adminUser, password);

        await userManager.AddToRoleAsync(adminUser, "user");
    }
}

app.Run();
