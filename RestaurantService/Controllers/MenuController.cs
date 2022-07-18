using Microsoft.AspNetCore.Mvc;
using RestaurantService.Data;
using RestaurantService.Models;

namespace RestaurantService.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _db;
        [ActivatorUtilitiesConstructor]
        public MenuController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Menu> objCategoryList = _db.Menus;
            return View(objCategoryList);
        }
        // GET
        public IActionResult Create()
        {
            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Menu obj)
        {
            if(ModelState.IsValid)
            {
                _db.Menus.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var menuFromDb = _db.Menus.Find(id);
            if (menuFromDb == null) return NotFound();
            return View(menuFromDb);
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Menu obj)
        {
            if (ModelState.IsValid)
            {
                _db.Menus.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var menuFromDb = _db.Menus.Find(id);
            if (menuFromDb == null) return NotFound();
            return View(menuFromDb);
        }
        // POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Menus.Find(id);
            if(obj==null) return NotFound();
            if (ModelState.IsValid)
            {
                _db.Menus.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
