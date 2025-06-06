using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.ContactViewComponents
{
    public class _ContactCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
