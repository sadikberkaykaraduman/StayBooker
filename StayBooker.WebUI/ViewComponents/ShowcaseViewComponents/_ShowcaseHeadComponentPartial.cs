using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.ShowcaseViewComponents
{
    public class _ShowcaseHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
