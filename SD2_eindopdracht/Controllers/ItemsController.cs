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

            return _context.Item != null ? 
                          View(await _context.Item.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Item'  is null.");
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

            if (item != null && currentUser != null)
            {
                if (item.Stock >  0) //check if item is in stock
                {
                    var userItem = new UserItem
                    {
                        UserId = currentUser.Id.ToString(),
                        ItemId = item.Id,
                    };

                    int Count = await _context.UserItem.CountAsync(ui => ui.UserId == currentUser.Id); //count amount of items added by user

                    if (currentUser.SubscriptionId == 2 && Count >= 10) //if user has "Budget" subscription, max amount of items to be loaned out is 10. If over max ammount, return error
                    {
                        TempData["ErrorMessage"] = "Maximale items voor dit abbonement is 10. Verwijder een item of verander je abbonement";
                    }
                    else //if user has other subscription or budget subscription and 10 or less items, add to table userItems
                    {
                        item.Stock--;
                        _context.UserItem.Add(userItem);
                        await _context.SaveChangesAsync();
                    }
                    
                    
                }
                else
                {
                    TempData["ErrorMessage"] = "Item is niet op voorraad"; //error if user is somehow able to reserve item 
                }
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
