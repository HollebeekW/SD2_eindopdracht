using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SD2_eindopdracht.Data;
using SD2_eindopdracht.Models;
using Microsoft.IdentityModel.Tokens;

//Wesley Hollebeek S1117975

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
    options.SignIn.RequireConfirmedAccount = false)
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

// Role creation
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "Employee", "User" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

// User creation
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    var password = "Pass1!"; // can be changed 

    if (await userManager.FindByEmailAsync("admin@email.com") == null)
    {
        var adminUser = new ApplicationUser();
        adminUser.Email = "admin@email.com";
        adminUser.UserName = "admin@email.com";
        adminUser.LockoutEnabled = false;
        adminUser.EmailConfirmed = true;

        await userManager.CreateAsync(adminUser, password);

        await userManager.AddToRoleAsync(adminUser, "Admin");
    }

    if (await userManager.FindByEmailAsync("employee@email.com") == null)
    {
        var employeeUser = new ApplicationUser();
        employeeUser.Email = "employee@email.com";
        employeeUser.UserName = "employee@email.com";
        employeeUser.LockoutEnabled = false;
        employeeUser.EmailConfirmed = true;

        await userManager.CreateAsync(employeeUser, password);

        await userManager.AddToRoleAsync(employeeUser, "Employee");
    }

    if (await userManager.FindByEmailAsync("user@email.com") == null)
    {
        var user = new ApplicationUser();
        user.Email = "user@email.com";
        user.UserName = "user@email.com";
        user.LockoutEnabled = false;
        user.EmailConfirmed = true;
        user.SubscriptionId = 2;

        await userManager.CreateAsync(user, password);

        await userManager.AddToRoleAsync(user, "User");
    }
}

//adding role to seeded users
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    var seededUsers = userManager.Users.ToList();

    //if 
    if (seededUsers.Any())
    {
        foreach (var user in seededUsers)
        {
            await userManager.AddToRoleAsync(user, "User");
        }
    }
}

app.Run();