using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Practice_1.DAL.Interfaces;
using Practice_1.DAL;
using System.Linq;

namespace Practice_1.Controllers
{
    public class MainPageController : Controller
    {
        private readonly ILogger<MainPageController> _logger;
        private readonly IStudentRepository _studentRepository;
        public MainPageController(ILogger<MainPageController> logger, IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }
        // GET: MainPageController
        public ActionResult MainPage(string login)
        {
            ApplicationContext _db = new ApplicationContext("Server=(localdb)\\MSSQLLocalDB;Database=Student;Trusted_Connection=True;");
            var result = _db.Register.Select(x => x.login_user);
            foreach (var x in result)
            {
                if (login == x)
                {
                    return View("FailedRegistrate");
                }
            }
            return View(_studentRepository.Select());
        }
        
        // GET: MainPageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MainPageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MainPageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(MainPage));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainPageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MainPageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(MainPage));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainPageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MainPageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("");
            }
            catch
            {
                return View();
            }
        }
    }
}
