using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertyManager.Data;
using PropertyManager.Models;

namespace PropertyManager.Controllers
{
    public class AnalystsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnalystsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Analysts
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var analyst = _context.Analysts.Where(a => a.IdentityUserId == userId);
            if(analyst == null)
            {
                return View("Create");
            }
            else
            {
                var properties = _context.Properties.Where(p => p.WorkOrderCount >= 1).ToList();
                return View(properties);
            }
           
        }

        // GET: Analysts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var property = await _context.Properties.Where(p => p.Id == id).FirstOrDefaultAsync();
            if (property == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Analysts/Create
        public IActionResult Create()
        {
            Analyst analyst = new Analyst();
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id");
            return View(analyst);
        }

        // POST: Analysts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdentityUserId")] Analyst analyst)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                analyst.IdentityUserId = userId;
                _context.Add(analyst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", analyst.IdentityUserId);
            return View(analyst);
        }

        // GET: Analysts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analyst = await _context.Analysts.FindAsync(id);
            if (analyst == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", analyst.IdentityUserId);
            return View(analyst);
        }

        // POST: Analysts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdentityUserId")] Analyst analyst)
        {
            if (id != analyst.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(analyst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnalystExists(analyst.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", analyst.IdentityUserId);
            return View(analyst);
        }

        // GET: Analysts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var analyst = await _context.Analysts
                .Include(a => a.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (analyst == null)
            {
                return NotFound();
            }

            return View(analyst);
        }

        // POST: Analysts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var analyst = await _context.Analysts.FindAsync(id);
            _context.Analysts.Remove(analyst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnalystExists(int id)
        {
            return _context.Analysts.Any(e => e.Id == id);
        }

        public IActionResult Graph()
        {
            var workOrders = _context.Properties.Where(w => w.WorkOrderCount >= 1).ToList();

            return View(workOrders);
        }

        public IActionResult CreateRec()
        {
            Reccomendation reccomend = new Reccomendation();
            List<Property> properties = _context.Properties.Where(p => p.WorkOrderCount > 0).ToList();
            ViewData["Property"] = new SelectList(properties, "Id", "Address");
            return View(reccomend);
        }

        [HttpPost]
        public IActionResult CreateRec(Reccomendation reccomend)
        {
            _context.Add(reccomend);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
