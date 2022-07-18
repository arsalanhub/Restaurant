using Microsoft.AspNetCore.Mvc;

namespace RestaurantService.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
