using Microsoft.AspNetCore.Mvc;

namespace StayBooker.WebUI.ViewComponents.ShowcaseViewComponents
{
    public class _ShowcaseScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
