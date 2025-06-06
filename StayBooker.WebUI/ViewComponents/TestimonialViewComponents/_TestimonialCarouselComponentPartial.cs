using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
