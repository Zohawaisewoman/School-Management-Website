using Microsoft.AspNetCore.Mvc;

namespace School_management_system_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
