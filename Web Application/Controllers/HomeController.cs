using Microsoft.AspNetCore.Mvc;

namespace Web_Application.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public IActionResult PendingPage()
        {
            return View();
        }
    }
}
