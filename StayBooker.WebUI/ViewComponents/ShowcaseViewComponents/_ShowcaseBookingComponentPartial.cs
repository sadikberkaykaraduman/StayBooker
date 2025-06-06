using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.ShowcaseViewComponents
{
    public class _ShowcaseBookingComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
