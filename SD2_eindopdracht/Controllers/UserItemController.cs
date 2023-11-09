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

            if (currentUser.IsBlocked == true)
            {
                TempData["ErrorMessage"] = "User is blocked,";
                return RedirectToAction("Index", "Items");
            }

            var subscriptionId = currentUser.SubscriptionId ?? 0; //check subscription Id

            if (subscriptionId == 0)
            {
                TempData["ErrorMessage"] = "No Subscription found"; //return error if empty (no subscription linked to user)
                return RedirectToAction("Index", "Items");
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
                //get subscription that belongs to user
                var userSubscription = _context.Subscription
                    .SingleOrDefault(s => s.Id == currentUser.SubscriptionId);

                //default price is 0
                decimal cost = 0;

                //if value for price is anything other than 0, get value from database
                if (userSubscription.ReservationPrice != 0) 
                {
                    cost = userSubscription.ReservationPrice;
                }

                return cost * quantity; //total price = amount of items times cost
            }

            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"].ToString();
            }
            if (TempData.ContainsKey("ErrorMessage"))
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"].ToString();
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

            try
            {
                item.Stock++; //add one to stock of deleted item

                _context.UserItem.Remove(userItem);
                _context.SaveChanges();
            } catch (Exception ex)
            {
                Problem(ex.Message);
            }
            

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
                try
                {
                    _context.UserItem.Remove(item);
                    _context.SaveChanges();
                } catch (Exception ex)
                {
                    Problem(ex.Message);
                }
                
            }

            TempData["Message"] = "Items reserved!"; //message to be delivered back to index

            return RedirectToAction("Index");
        }
    }
}
