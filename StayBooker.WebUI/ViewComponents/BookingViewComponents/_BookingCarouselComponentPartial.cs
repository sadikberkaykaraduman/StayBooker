using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.BookingViewComponents
{
    public class _BookingCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
