using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.RoomViewComponents
{
    public class _RoomCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
