using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SD2_eindopdracht.Data;
using SD2_eindopdracht.Models;

namespace SD2_eindopdracht.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;

        public ItemsController(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            if (TempData.ContainsKey("ErrorMessage"))
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"].ToString(); //if tempdata has an error message, show in view
            }

            var items = await _context.Item
                .Include(i => i.Author)
                .Include(i => i.Category)
                .ToListAsync();

            return items != null
                ? View(items)
                : Problem("Entity set 'ApplicationDbContext.Item' is null.");
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Item == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [Authorize(Roles = "Admin, Employee")]
        // GET: Items/Create
        public IActionResult Create()
        {
            ViewBag.Authors = new SelectList(_context.Author, "Id", "FirstName", "LastName");
            ViewBag.Categories = new SelectList(_context.Category, "Id", "Name");
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin, Employee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,YearOfRelease,Stock,AuthorId,CategoryId,UserId")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Edit/5
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Item == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            ViewBag.Authors = new SelectList(_context.Author, "Id", "FirstName", "LastName");
            ViewBag.Categories = new SelectList(_context.Category, "Id", "Name");

            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin, Employee")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,YearOfRelease,Stock,AuthorId,CategoryId,UserId")] Item item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Authors = new SelectList(_context.Author, "Id", "FirstName", "LastName");
            ViewBag.Categories = new SelectList(_context.Category, "Id", "Name");

            return View(item);
        }

        // GET: Items/Delete/5
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Item == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [Authorize(Roles = "Admin, Employee")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Item == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Item'  is null.");
            }
            var item = await _context.Item.FindAsync(id);
            if (item != null)
            {
                _context.Item.Remove(item);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
          return (_context.Item?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        
        //Reserve item
        public async Task<IActionResult> Reserve(int id)
        {
            var currentUser = await _userManager.GetUserAsync(User); //get currently logged in users' id

            var item = await _context.Item.FindAsync(id); //get item id

            if (item == null || currentUser == null)
            {
                return Problem("Item or user not found");
            }

            if (item.Stock <= 0) //check if item is in stock
            {
                return Problem("Item not in stock"); //problem instead of redirect with tempdata, because link to items without stock is disabled in view. Normal users shouldn't have access to it.

            }

            var userSubscription = await _context.Subscription
                .SingleOrDefaultAsync(s => s.Id == currentUser.SubscriptionId); //get users' subscription type

            if (userSubscription == null)
            {
                TempData["ErrorMessage"] = "No subscription found, item was not added";
                return RedirectToAction("Index");
            }

            try
            {
                var userItem = new UserItem
                {
                    UserId = currentUser.Id.ToString(),
                    ItemId = item.Id,
                };

                int count = await _context.UserItem.CountAsync(ui => ui.UserId == currentUser.Id); //count amount of items added by user
                int maxItems = userSubscription.ItemsAtOnce.Value; //max items to be loaned out at a time

                if (maxItems != null && count >= maxItems)
                {
                    TempData["ErrorMessage"] = $"Max amount of items for this subscription is {maxItems}.";
                }
                else //if user has other subscription or budget subscription and 10 or less items, add to table userItems
                {
                    item.Stock--;
                    _context.UserItem.Add(userItem);
                    await _context.SaveChangesAsync();
                }
            } catch (Exception ex)
            {
                return Problem(ex.Message);
            }
            
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Sort(string sortBy)
        {
            IQueryable<Item> items = _context.Item
                .Include(i => i.Author)
                .Include(i => i.Category);

            switch(sortBy)
            {
                case "Title":
                    items = items.OrderBy(i => i.Title);
                    break;

                case "YearOfRelease":
                    items = items.OrderByDescending(i => i.YearOfRelease);
                    break;

                case "Category":
                    items = items.OrderBy(i => i.Category.Name);
                    break;

                case "AuthorFirstName":
                    items = items.OrderBy(i => i.Author.FirstName);
                    break;

                case "AuthorLastName":
                    items = items.OrderBy(i => i.Author.LastName);
                    break;

                case "Stock":
                    items = items.OrderByDescending(i => i.Stock);
                    break;

                case "NoZeroStock":
                    items = items.Where(i => i.Stock != 0);
                    break;

                default:
                    items = items.OrderBy(i => i.Title);
                    break;
            }

            var sortedItems = await items.ToListAsync();
            return View("Index", sortedItems);
        }

        public async Task<IActionResult> Search(string query)
        {
            var items = _context.Item
                .Include(i => i.Author)
                .Include(i => i.Category);

            var result = await items.
                Where(i =>
                i.Title.Contains(query) ||
                i.YearOfRelease.ToString().Contains(query) ||
                i.Category.Name.Contains(query) ||
                i.Author.FirstName.Contains(query) ||
                i.Author.LastName.Contains(query))
                .ToListAsync();
            return View("Index", result);
        }
    }
}
