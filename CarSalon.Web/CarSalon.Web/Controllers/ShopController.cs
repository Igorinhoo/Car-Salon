using Microsoft.AspNetCore.Mvc;

namespace CarSalon.Web.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Order()
        {
            return View();
        }
    }
}
