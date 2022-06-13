using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_1.DAL;
using Practice_1.Domain.Entity;
using System.Linq;

namespace Practice_1.Controllers
{
    public class IdentificationController : Controller
    {

        private readonly ILogger<IdentificationController> _logger;
        private readonly ApplicationContext _db = new ApplicationContext("Default");
        public static bool LogIn = false;
        public IdentificationController(ILogger<IdentificationController> logger)
        {
            _logger = logger;
        }
        // GET: IdentificationController
        
        public IActionResult Identification(string login, string password)
        {
            var logins = _db.Register.Select(x => x.login_user);
            var passwords = _db.Register.Select(x => x.password_user);
            if (login != null && logins.Contains(login)&& passwords.Contains(password))
            {
                RegistrateController.LogIn = true;
                return Redirect("/Students/Index");
            }
            else
            {
                return View();
            }
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
                return RedirectToAction(nameof(Identification));
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
                return RedirectToAction(nameof(Identification));
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
                return RedirectToAction(nameof(Identification));
            }
            catch
            {
                return View();
            }
        }
    }
}
