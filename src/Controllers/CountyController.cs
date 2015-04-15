using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using aspnetefdemo;

namespace src.Controllers
{
    public class CountyController : Controller
    {
        private DemoContext db = new DemoContext();

        // GET: County
        public IActionResult Index()
        {
            return View(db.Countries.ToList());
        }

        // GET: County/Details/5
        public IActionResult Details(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Country country = db.Countries.Single(m => m.Id == id);
            if (country == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(country);
        }

        // GET: County/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: County/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country country)
        {
            if (ModelState.IsValid)
            {
                db.Countries.Add(country);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(country);
        }

        // GET: County/Edit/5
        public IActionResult Edit(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Country country = db.Countries.Single(m => m.Id == id);
            if (country == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(country);
        }

        // POST: County/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                ////db.ChangeTracker.StateManager.GetOrCreateEntry(country).EntityState = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(country);
        }

        // GET: County/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(System.Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(404);
            }

            Country country = db.Countries.Single(m => m.Id == id);
            if (country == null)
            {
                return new HttpStatusCodeResult(404);
            }

            return View(country);
        }

        // POST: County/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(System.Int32 id)
        {
            Country country = db.Countries.Single(m => m.Id == id);
            db.Countries.Remove(country);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
