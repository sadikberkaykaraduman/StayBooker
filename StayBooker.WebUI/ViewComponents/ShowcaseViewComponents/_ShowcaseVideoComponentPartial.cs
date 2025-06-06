using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.ShowcaseViewComponents
{
    public class _ShowcaseVideoComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
