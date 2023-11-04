using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SD2_eindopdracht.Data;
using SD2_eindopdracht.Models;
using System.Drawing.Text;

namespace SD2_eindopdracht.Controllers
{
    [Authorize]
    public class UserItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;

        public UserItemController(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //Index
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null) //check if user is logged in
            {
                return Problem("Niet ingelogd");
            }

            var subscriptionId = currentUser.SubscriptionId ?? 0; //check subscription Id

            if (subscriptionId == null)
            {
                return Problem("Geen abbonement gekozen"); //return error if empty (no subscription linked to user)
            }

            var userItems = _context.UserItem
                .Where(ui => ui.UserId == currentUser.Id)
                .Include(ui => ui.Item)
                .ToList();

            var reservedItems = userItems
                .GroupBy(ui => ui.Item)
                .Select(group => new
                {
                    Item = group.Key,
                    Quantity = group.Count(),
                    CostPerItem = CalculatePrice(subscriptionId, group.Count())
                })
                .ToList();

            decimal CalculatePrice(int subscriptionId, int quantity)
            {
                decimal cost = 0;

                if (subscriptionId != 4) //if subscription type is anything other than "Top", price per item is 25 cents
                {
                    cost = 0.25m;
                }

                return cost * quantity; //total price = amount of items times cost
            }

            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"].ToString();
            }

            return View(reservedItems);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Id)
        {
            string currentUserId = User.Identity.GetUserId(); //get current logged users' id 

            if (currentUserId == null)
            {
                return Problem("User Id not found"); //return error if user is not logged in
            }

            UserItem userItem = _context.UserItem
                .Include(ui => ui.Item)
                .FirstOrDefault(ui => ui.UserId == currentUserId && ui.ItemId == Id);

            if (userItem == null)
            {
                return Problem("Item not found");
            }

            var item = userItem.Item;

            if (item == null)
            {
                return Problem("Item not found");
            }
            item.Stock++; //add one to stock of deleted item

            _context.UserItem.Remove(userItem);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Order()
        {
            string currentUserId = User.Identity.GetUserId();

            if (currentUserId == null)
            {
                return Problem("User Id not found");
            }

            var userItems = _context.UserItem
                .Where(ui => ui.UserId == currentUserId)
                .ToList();

            foreach (var item in userItems )
            {
                _context.UserItem.Remove(item);
                _context.SaveChanges();
            }

            TempData["Message"] = "Items gereserveerd!"; //message to be delivered back to index

            return RedirectToAction("Index");
        }
    }
}
