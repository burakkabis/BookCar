using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkimizda";
            ViewBag.v2 = "Vizyonumuz & Misyonumuz";

            return View();
        }
    }
}
