using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
