using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.CommentViewComponents
{
    public class _CommentCarouselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
