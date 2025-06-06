using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.ServiceViewComponents
{
    public class _ServiceCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
