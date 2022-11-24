using Microsoft.AspNetCore.Mvc;

namespace CarSalon.Web.Controllers
{
    public class AuthorisationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
