using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElGatoBackend.Controllers
{
    public class BreedsController : Controller
    {
        // GET: BreedsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BreedsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BreedsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BreedsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BreedsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BreedsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BreedsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BreedsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
