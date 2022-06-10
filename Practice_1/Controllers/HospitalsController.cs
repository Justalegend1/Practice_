using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practice_1.DAL;
using Practice_1.Domain.Entity;

namespace Practice_1.Controllers
{
    public class HospitalsController : Controller
    {
        private readonly ApplicationContext _context;

        public HospitalsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Hospitals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hospital.ToListAsync());
        }

        // GET: Hospitals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospital
                .FirstOrDefaultAsync(m => m.Hospital_ID == id);
            if (hospital == null)
            {
                return NotFound();
            }

            return View(hospital);
        }

        // GET: Hospitals/Create
        public IActionResult Create()
        {
            ViewBag.City_ID = new SelectList(_context.City, "City_ID", "City_Name");
            return View();
        }

        // POST: Hospitals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Hospital_ID,Hospital_Name,City_code,Street,House_number,Corpus,Phone_Fax_number,E_Mail,Website_address")] Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospital);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.City_ID = new SelectList(_context.City, "City_ID", "City_Name");
            return View(hospital);
        }

        // GET: Hospitals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospital.FindAsync(id);
            if (hospital == null)
            {
                return NotFound();
            }
            ViewBag.City_ID = new SelectList(_context.City, "City_ID", "City_Name");
            return View(hospital);
        }

        // POST: Hospitals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Hospital_ID,Hospital_Name,City_code,Street,House_number,Corpus,Phone_Fax_number,E_Mail,Website_address")] Hospital hospital)
        {
            if (id != hospital.Hospital_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospital);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospitalExists(hospital.Hospital_ID))
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
            return View(hospital);
        }

        // GET: Hospitals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospital
                .FirstOrDefaultAsync(m => m.Hospital_ID == id);
            if (hospital == null)
            {
                return NotFound();
            }

            return View(hospital);
        }

        // POST: Hospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hospital = await _context.Hospital.FindAsync(id);
            _context.Hospital.Remove(hospital);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospitalExists(int id)
        {
            return _context.Hospital.Any(e => e.Hospital_ID == id);
        }
    }
}
