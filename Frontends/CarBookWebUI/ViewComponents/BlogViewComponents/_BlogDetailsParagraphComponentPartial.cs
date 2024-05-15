using Microsoft.AspNetCore.Mvc;

namespace CarBookWebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsParagraphComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
