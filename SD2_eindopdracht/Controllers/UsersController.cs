using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SD2_eindopdracht.Models;

namespace SD2_eindopdracht.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> _roleManager;
        
        public UsersController (Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager, Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager)
        {
            //define user and roles managers
            _userManager = userManager;
            _roleManager = roleManager;
        }

        //Index of users with role(s) and subscription type
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users
                .Include(u => u.Subscription) //include subscriptions table, to also how subscription name
                .ToListAsync();
            var usersWithRoles = new List<object>(); //create list of users with role(s), and subscription name

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                usersWithRoles.Add(new
                {
                    User = user,
                    Roles = roles
                });
            }
            return View (usersWithRoles);
        }

        //Delete view
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _userManager.Users == null)
            {
                return NotFound();
            }

            var user = await _userManager.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        //Delete action
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_userManager.Users == null)
            {
                return Problem("Geen gebruikers gevonden");
            }
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                //check if user has admin role
                var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");

                if (isAdmin)
                {
                    //if user is an admin, return problem
                    return Problem("Admins kunnen niet verwijderd worden");
                }
                else
                {
                    await _userManager.DeleteAsync(user);
                }
            }

            return RedirectToAction(nameof(Index));
        }

        //Edit view
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var allRoles = _roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);

            ViewBag.User = user; //selected user
            ViewBag.AllRoles = allRoles; //all available roles
            ViewBag.UserRoles = userRoles; //roles assigned to selected user

            return View();
        }

        //Add Role
        [HttpPost, ActionName("AddRole")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(string id, string selectedRole)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(selectedRole))
            {
                await _userManager.AddToRoleAsync(user, selectedRole);
            }

            return RedirectToAction("Edit", new { id = id });
        }

        //Delete Role
        [HttpPost, ActionName("RemoveRole")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveRole(string id, string userRole)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(userRole))
            {
                await _userManager.RemoveFromRoleAsync(user, userRole);
            }

            return RedirectToAction("Edit", new { id = id });
        }
    }
}
