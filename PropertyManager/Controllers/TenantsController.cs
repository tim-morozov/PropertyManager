using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PropertyManager.Data;
using PropertyManager.Models;

namespace PropertyManager.Controllers
{
    public class TenantsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public static readonly HttpClient httpClient = new HttpClient();

        public TenantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tenants
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var tenant = _context.Tenants.Where(t => t.IdentityUserId == userId).FirstOrDefault();
            if(tenant == null)
            {
                return RedirectToAction(nameof(Create));
            }
            else
            {
                return View(tenant);
            }
        }

        // GET: Tenants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tenant = await _context.Tenants
                .Include(t => t.IdentityUser)
                .Include(t => t.Property)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tenant == null)
            {
                return NotFound();
            }

            return View(tenant);
        }

        // GET: Tenants/Create
        public IActionResult Create()
        {
            var tenant = new Tenant();
            List<Property> properties = _context.Properties.Select(p => p).ToList();
           
            
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id");
            ViewData["Property"] = new SelectList(properties, "Id", "Address");
            return View(tenant);
        }

        // POST: Tenants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,ZipCode,IdentityUserId,PropertyId")] Tenant tenant)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var IdentityUser = _context.Users.Where(i => i.Id == userId).FirstOrDefault();
                tenant.IdentityUserId = userId;
                tenant.IdentityUser = IdentityUser;
                var prop = _context.Properties.Where(p => p.Id == tenant.PropertyId).FirstOrDefault();
                tenant.Property = prop;
                var tenAddr = tenant.Property.Address + ", " + tenant.Property.City + ", " + tenant.Property.State + ", " + tenant.Property.ZipCode;

                HttpResponseMessage response = await httpClient.GetAsync("https://maps.googleapis.com/maps/api/geocode/json?address=" + tenAddr + "&key=" + API_Key.APIKEY);
                var result = await response.Content.ReadAsStringAsync();
                var parseResult = JObject.Parse(result);
                var lat = parseResult["results"][0]["geometry"]["location"]["lat"].Value<double>();
                var lng = parseResult["results"][0]["geometry"]["location"]["lng"].Value<double>();

                tenant.Property.lat = lat;
                tenant.Property.lng = lng;


                _context.Add(tenant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", tenant.IdentityUserId);
            ViewData["Property"] = new SelectList(_context.Set<Property>(), "Id", "Id", tenant.PropertyId);
            return View(tenant);
        }

        // GET: Tenants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tenant = await _context.Tenants.FindAsync(id);
            if (tenant == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", tenant.IdentityUserId);
            ViewData["PropertyId"] = new SelectList(_context.Set<Property>(), "Id", "Id", tenant.PropertyId);
            return View(tenant);
        }

        // POST: Tenants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,ZipCode,IdentityUserId,PropertyId")] Tenant tenant)
        {
            if (id != tenant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tenant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TenantExists(tenant.Id))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Id", tenant.IdentityUserId);
            ViewData["PropertyId"] = new SelectList(_context.Set<Property>(), "Id", "Id", tenant.PropertyId);
            return View(tenant);
        }

        // GET: Tenants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tenant = await _context.Tenants
                .Include(t => t.IdentityUser)
                .Include(t => t.Property)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tenant == null)
            {
                return NotFound();
            }

            return View(tenant);
        }

        // POST: Tenants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tenant = await _context.Tenants.FindAsync(id);
            _context.Tenants.Remove(tenant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TenantExists(int id)
        {
            return _context.Tenants.Any(e => e.Id == id);
        }

        public IActionResult WorkOrder()
        {   
            WorkOrder workOrder = new WorkOrder();
            return View(workOrder);
        }
        [HttpPost]
        public IActionResult WorkOrder(WorkOrder workOrder)
        {
           var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var tenant = _context.Tenants.Where(t => t.IdentityUserId == userId).FirstOrDefault();
            var property = _context.Properties.Where(p => p.Id == tenant.PropertyId).FirstOrDefault();
            workOrder.IsComplete = false;
            workOrder.TenantId = tenant.Id;
            workOrder.Tenant = tenant;
            property.WorkOrderCount++;
            _context.WorkOrders.Add(workOrder);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
