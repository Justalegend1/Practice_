using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_1.DAL;
using Practice_1.Domain.Entity;
using System.Linq;

namespace Practice_1.Controllers
{
    public class FindVaccinationController : Controller
    {
        public readonly ApplicationContext _db = new ApplicationContext("Default");

        // GET: FindVaccinationController/Details/5
        [HttpPost]
        public ActionResult FindVaccination()
        {
            var result = _db.Certificate.Where(x => x.Type == null || x.Type == "Вакцинация").Select(x=>x).ToList();
            var Result = _db.Student.Where(x => x.Certificate_number == null).Select(x => x).ToList();
            return View(result);
        }

        // GET: FindVaccinationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FindVaccinationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(FindVaccination));
            }
            catch
            {
                return View();
            }
        }

        // GET: FindVaccinationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FindVaccinationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(FindVaccination));
            }
            catch
            {
                return View();
            }
        }

        // GET: FindVaccinationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FindVaccinationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(FindVaccination));
            }
            catch
            {
                return View();
            }
        }
    }
}
