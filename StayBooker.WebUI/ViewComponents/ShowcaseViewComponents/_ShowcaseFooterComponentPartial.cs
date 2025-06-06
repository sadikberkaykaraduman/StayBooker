using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.ShowcaseViewComponents
{
    public class _ShowcaseFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
