﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SD2_eindopdracht.Data;
using SD2_eindopdracht.Models;

namespace SD2_eindopdracht.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public SubscriptionsController(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Subscriptions
        public async Task<IActionResult> Index()
        {
            if (TempData.ContainsKey("SuccessMessage"))
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"].ToString();
            }
            if (TempData.ContainsKey("ErrorMessage"))
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"].ToString();
            }

            return _context.Subscription != null ? 
                          View(await _context.Subscription.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Subscription'  is null.");
        }

        // GET: Subscriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Subscription == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // GET: Subscriptions/Create
        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subscriptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Create([Bind("Id,Name,MinAge,MaxAge,ItemsAtOnce,YearlyItems,LoanPeriod,Extensions,ReservationPrice,DailyFine,SubscriptionPrice")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subscription);
        }

        // GET: Subscriptions/Edit/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Subscription == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            return View(subscription);
        }

        // POST: Subscriptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,MinAge,MaxAge,ItemsAtOnce,YearlyItems,LoanPeriod,Extensions,ReservationPrice,DailyFine,SubscriptionPrice")] Subscription subscription)
        {
            if (id != subscription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subscription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriptionExists(subscription.Id))
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
            return View(subscription);
        }

        // GET: Subscriptions/Delete/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Subscription == null)
            {
                return NotFound();
            }

            var subscription = await _context.Subscription
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            return View(subscription);
        }

        // POST: Subscriptions/Delete/5
        [Authorize(Roles = "Admin,Employee")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Subscription == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Subscription'  is null.");
            }
            var subscription = await _context.Subscription.FindAsync(id);

            var usersWithSubscription = await _userManager.Users //get list of users subscribed to the to be deleted subscription
                .Where(u => u.SubscriptionId == subscription.Id)
                .ToListAsync();

            if (subscription != null)
            {
                foreach (var user in usersWithSubscription)
                {
                    user.SubscriptionId = null; //remove subscription for every user in list
                }

                _context.Subscription.Remove(subscription);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubscriptionExists(int id)
        {
          return (_context.Subscription?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [Authorize]
        public async Task<IActionResult> ChangeSubscription(int id)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {
                return Problem("No User Found");
            }

            int newSubscriptionId = id;

            if (currentUser.SubscriptionId == newSubscriptionId)
            {
                TempData["ErrorMessage"] = "You already have this subscription, please choose another one";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                currentUser.SubscriptionId = newSubscriptionId;
                await _context.SaveChangesAsync();
            } catch (Exception ex)
            {
                return Problem(ex.Message);
            }
            

            TempData["SuccessMessage"] = "Successfully changed subscription type";
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> StopSubscription()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {
                return Problem("No User Found");
            }

            if (currentUser.SubscriptionId == 0)
            {
                TempData["ErrorMessage"] = "Choose a subscription first";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                currentUser.SubscriptionId = null;
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Subscription successfully stopped";
            } catch(Exception ex)
            {
                return Problem(ex.Message);
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
