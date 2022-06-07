using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_1.DAL;
using Practice_1.DAL.Interfaces;
using System.Diagnostics;
using System.Linq;

namespace Practice_1.Controllers
{
    public class RegistrateController : Controller
    {
        private readonly ILogger<RegistrateController> _logger;
        

        public RegistrateController(ILogger<RegistrateController> logger)
        {
            
            _logger = logger;
        }


        
        // GET: IdentificationController
        public ActionResult Registrate(string login)
        {
            return View("Registrate"); 
        }

        // GET: IdentificationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IdentificationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IdentificationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Registrate));
            }
            catch
            {
                return View();
            }
        }

        // GET: IdentificationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IdentificationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Registrate));
            }
            catch
            {
                return View();
            }
        }

        // GET: IdentificationController/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: IdentificationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Registrate));
            }
            catch
            {
                return View();
            }
        }
    }
}
