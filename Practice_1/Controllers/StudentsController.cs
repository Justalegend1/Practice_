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
    public class StudentsController : Controller
    {
        private readonly ApplicationContext _context = new ApplicationContext("Default");

        public StudentsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Student_ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.SexId = new SelectList(_context.Sex, "ID_sex", "sex");
            ViewBag.City_ID = new SelectList(_context.City, "City_ID", "City_Name");
            ViewBag.Direction_ID = new SelectList(_context.Direction, "ID_Direction", "Name_Direction");
            ViewBag.Group_ID = new SelectList(_context.Group, "ID_Group", "group");
            ViewBag.ID_basis_study = new SelectList(_context.Basis_of_study, "ID_basis_study", "Basis_study");
            ViewBag.ID_form_study = new SelectList(_context.Form_of_study, "ID_form_study", "Study_form");
            ViewBag.Certificate_number = new SelectList(_context.Certificate, "Certificate_number", "Certificate_number");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Student_ID,Surname,Name,Middle_name,Birth_date,Sex_ID,City_ID,Direction_ID,Group_ID,ID_basis_study,ID_form_study,ID_Reason_deduction,Passport_data,Contract_number,Certificate_number,E_mail,Phone_number,Course")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewBag.SexId = new SelectList(_context.Sex, "ID_sex", "sex");
            ViewBag.City_ID = new SelectList(_context.City, "City_ID", "City_Name");
            ViewBag.Direction_ID = new SelectList(_context.Direction, "ID_Direction", "Name_Direction");
            ViewBag.Group_ID = new SelectList(_context.Group, "ID_Group", "group");
            ViewBag.ID_basis_study = new SelectList(_context.Basis_of_study, "ID_basis_study", "Basis_study");
            ViewBag.ID_form_study = new SelectList(_context.Form_of_study, "ID_form_study", "Study_form");
            ViewBag.Certificate_number = new SelectList(_context.Certificate, "Certificate_number", "Certificate_number");
            return View(student);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Student_ID,Surname,Name,Middle_name,Birth_date,Sex_ID,City_ID,Direction_ID,Group_ID,ID_basis_study,ID_form_study,ID_Reason_deduction,Passport_data,Contract_number,Certificate_number,E_mail,Phone_number,Course")] Student student)
        {
            if (id != student.Student_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Student_ID))
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
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Student_ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Student_ID == id);
        }
    }
}
