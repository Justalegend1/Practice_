using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_1.DAL;
using System;
using System.Linq;

namespace Practice_1.Controllers
{
    public class FindController : Controller
    {
        public readonly ApplicationContext _db = new ApplicationContext("Default");
        // GET: FindController
        [HttpGet]
        public ActionResult Find()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Find(DateTime datetime)
        {
            var result = _db.Certificate.ToList().Where(x => x.The_beginning_of_the_action >= datetime);
            return View(result);
        }
        // GET: FindController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FindController/Create
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: FindController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Find));
            }
            catch
            {
                return View();
            }
        }

        // GET: FindController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FindController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Find));
            }
            catch
            {
                return View();
            }
        }

        // GET: FindController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FindController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Find));
            }
            catch
            {
                return View();
            }
        }
    }
}
