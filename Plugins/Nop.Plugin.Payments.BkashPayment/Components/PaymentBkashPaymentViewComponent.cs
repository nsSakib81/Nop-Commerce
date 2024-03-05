using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.BkashPayment.Components
{
    [ViewComponent(Name = "BkashPayment")]
    public class PaymentBkashPaymentViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.BkashPayment/Views/PaymentInfo.cshtml");
        }
    }
}
