using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.TeamViewComponents
{
    public class _TeamCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
