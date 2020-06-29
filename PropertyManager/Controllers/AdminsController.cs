using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PropertyManager.Data;
using PropertyManager.Models;

namespace PropertyManager.Controllers
{
    public class AdminsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public static readonly HttpClient httpClient = new HttpClient();

        public AdminsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admins
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var admin = _context.Admins.Where(a => a.IdentityUserId == userId).FirstOrDefault();
            if(admin == null)
            {
                return View("Create");
            }
            else
            {
             var jobs = _context.WorkOrders.Select(j => j).Include(j => j.Tenant).ThenInclude(j => j.Property).ToListAsync();
             return View(await jobs);
            }
        }

        // GET: Admins/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = _context.WorkOrders.Where(j => j.Id == id).Include(j => j.Tenant).Include(j => j.Tenant.Property).FirstOrDefault();
            
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id");
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdentityUserId")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var identityUser = _context.Users.Where(i => i.Id == userId).FirstOrDefault();
                admin.IdentityUserId = userId;
                admin.IdentityUser = identityUser;
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", admin.IdentityUserId);
            return View(admin);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", admin.IdentityUserId);
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdentityUserId")] Admin admin)
        {
            if (id != admin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(admin.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", admin.IdentityUserId);
            return View(admin);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .Include(a => a.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admin = await _context.Admins.FindAsync(id);
            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminExists(int id)
        {
            return _context.Admins.Any(e => e.Id == id);
        }

        public IActionResult AssignWork(int id)
        {
            List<Contractor> contractors = _context.Contractors.Select(c => c).ToList();
            var job = _context.WorkOrders.Where(j => j.Id == id).FirstOrDefault();
            ViewData["Contractors"] = new SelectList(contractors, "Id", "Type");
            return View(job);
        }
        [HttpPost]
        public IActionResult AssignWork(int id, WorkOrder job)
        {
            _context.WorkOrders.Update(job);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ViewRecs()
        {
            var recs = _context.Reccomendations.Select(r => r).Include(r => r.Property).ToList();
            return View(recs);
        }
        
        public IActionResult RecDetails(int id)
        {
            var rec = _context.Reccomendations.Where(r => r.Id == id).Include(r => r.Property).FirstOrDefault();
            return View(rec);
        }

        public IActionResult CreateProperty()
        {
            Property property = new Property();
            return View(property);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProperty(Property property)
        {
            var Addr = property.Address + ", " + property.City + ", " + property.State + ", " + property.ZipCode;
            HttpResponseMessage response = await httpClient.GetAsync("https://maps.googleapis.com/maps/api/geocode/json?address=" + Addr + "&key=" + API_Key.APIKEY);
            var result = await response.Content.ReadAsStringAsync();
            var parseResult = JObject.Parse(result);
            var lat = parseResult["results"][0]["geometry"]["location"]["lat"].Value<double>();
            var lng = parseResult["results"][0]["geometry"]["location"]["lng"].Value<double>();
            property.lat = lat;
            property.lng = lng;
            property.IsOccupied = false;
            _context.Properties.Add(property);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
