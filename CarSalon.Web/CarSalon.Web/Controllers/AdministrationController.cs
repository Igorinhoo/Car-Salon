using Microsoft.AspNetCore.Mvc;

namespace CarSalon.Web.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
    }
}
