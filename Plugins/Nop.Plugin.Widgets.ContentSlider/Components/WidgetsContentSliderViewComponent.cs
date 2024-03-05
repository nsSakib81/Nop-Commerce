using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.ContentSlider.Components
{
    [ViewComponent(Name = "ContentSlider")]
    public class WidgetsContentSliderViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Widgets.ContentSlider/Views/PublicInfo.cshtml");
        }
    }
}
