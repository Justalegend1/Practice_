using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_1.DAL;
using Practice_1.DAL.Interfaces;
using Practice_1.Domain.Entity;
using System.Diagnostics;
using System.Linq;

namespace Practice_1.Controllers
{
    public class RegistrateController : Controller
    {
        private readonly ILogger<RegistrateController> _logger;
        private readonly ApplicationContext _db = new ApplicationContext("Default");
        public static bool LogIn = false;

        public RegistrateController(ILogger<RegistrateController> logger)
        {
            
            _logger = logger;
        }


        [HttpPost]
        // GET: IdentificationController
        public IActionResult Registrate(string login, string password)
        {
            LogIn = false;
            var user = _db.Register.Select(x=>x.login_user);
            if (login != null && !user.Contains(login))
            {
                Register register = new Register { login_user = login, password_user = password, admin = false };
                _db.Add(register);
                _db.SaveChanges();
                LogIn = true;
                return Redirect("/Students/Index");
            }
            else
            {
                return View("Registrate");
            }
        }
        public ActionResult Registrate()
        {
            LogIn = false;
            return View();
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
