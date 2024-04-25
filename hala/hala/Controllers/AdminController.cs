using Microsoft.AspNetCore.Mvc;

namespace hala.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
