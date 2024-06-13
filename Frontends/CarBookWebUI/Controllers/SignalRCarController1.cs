using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.Controllers
{
    public class SignalRCarController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
