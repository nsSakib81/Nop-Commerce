using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.NagadPayment.Components
{
    [ViewComponent(Name = "PaymentNagadPayment")]
    public class PaymentNagadPaymentViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.NagadPayment/Views/NagadPaymentInfo.cshtml");
        }
    }
}
