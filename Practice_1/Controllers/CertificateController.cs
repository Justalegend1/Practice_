using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practice_1.Controllers
{
    public class CertificateController : Controller
    {
        private readonly ILogger<CertificateController> _logger;

        public CertificateController(ILogger<CertificateController> logger)
        {
            _logger = logger;
        }
        // GET: CertificateController
        public ActionResult Certificate()
        {
            return View();
        }

        // GET: CertificateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CertificateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Certificate));
            }
            catch
            {
                return View();
            }
        }

        // GET: CertificateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CertificateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Certificate));
            }
            catch
            {
                return View();
            }
        }

        // GET: CertificateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CertificateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Certificate));
            }
            catch
            {
                return View();
            }
        }
    }
}
