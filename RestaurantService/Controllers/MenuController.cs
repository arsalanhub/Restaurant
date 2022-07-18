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
    }
}
