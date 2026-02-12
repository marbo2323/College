using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using College.Data;
using College.Models;

namespace College.Controllers
{
    public class DelinquentsController : Controller
    {
        private readonly CollegeContext _context;

        public DelinquentsController(CollegeContext context)
        {
            _context = context;
        }

        // GET: Delinquents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Delinquent.ToListAsync());
        }

        // GET: Delinquents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delinquent = await _context.Delinquent
                .FirstOrDefaultAsync(m => m.DelinquentsId == id);
            if (delinquent == null)
            {
                return NotFound();
            }

            return View(delinquent);
        }

        // GET: Delinquents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Delinquents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DelinquentsId,FirstName,LastName,EventDate,isStudent,PunishmentType,PunishmentLenght,Description")] Delinquent delinquent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delinquent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(delinquent);
        }

        // GET: Delinquents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delinquent = await _context.Delinquent.FindAsync(id);
            if (delinquent == null)
            {
                return NotFound();
            }
            return View(delinquent);
        }

        // POST: Delinquents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DelinquentsId,FirstName,LastName,EventDate,isStudent,PunishmentType,PunishmentLenght,Description")] Delinquent delinquent)
        {
            if (id != delinquent.DelinquentsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(delinquent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DelinquentExists(delinquent.DelinquentsId))
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
            return View(delinquent);
        }

        // GET: Delinquents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var delinquent = await _context.Delinquent
                .FirstOrDefaultAsync(m => m.DelinquentsId == id);
            if (delinquent == null)
            {
                return NotFound();
            }

            return View(delinquent);
        }

        // POST: Delinquents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var delinquent = await _context.Delinquent.FindAsync(id);
            if (delinquent != null)
            {
                _context.Delinquent.Remove(delinquent);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DelinquentExists(int id)
        {
            return _context.Delinquent.Any(e => e.DelinquentsId == id);
        }
    }
}
