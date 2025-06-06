using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
