#pragma checksum "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9886c5cbf12dc3808d4533020cb7d6cd02a3d5eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_OpcConfirmOrder), @"mvc.1.0.view", @"/Views/Checkout/OpcConfirmOrder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9886c5cbf12dc3808d4533020cb7d6cd02a3d5eb", @"/Views/Checkout/OpcConfirmOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d1b9cf4fa5ba34fd858c89c406a07634618cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_OpcConfirmOrder : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CheckoutConfirmModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"checkout-data\">\r\n    ");
#nullable restore
#line 3 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.OpCheckoutConfirmTop }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
     if (!string.IsNullOrEmpty(Model.MinOrderTotalWarning) || Model.Warnings.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"section confirm-order\">\r\n");
#nullable restore
#line 7 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
             if (!string.IsNullOrEmpty(Model.MinOrderTotalWarning))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <span class=\"min-order-warning\">");
#nullable restore
#line 10 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                                               Write(Model.MinOrderTotalWarning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n");
#nullable restore
#line 12 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
             if (Model.Warnings.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"message-error\">\r\n                    <ul>\r\n");
#nullable restore
#line 17 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                         foreach (var warning in Model.Warnings)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 19 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                           Write(warning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 25 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 26 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.OpCheckoutConfirmBottom }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"section order-summary\">\r\n        ");
#nullable restore
#line 28 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
   Write(await Component.InvokeAsync("OrderSummary", new { prepareAndDisplayOrderReviewData = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
     if (string.IsNullOrEmpty(Model.MinOrderTotalWarning) && Model.TermsOfServiceOnOrderConfirmPage)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"terms-of-service-warning-box\"");
            BeginWriteAttribute("title", " title=\"", 1343, "\"", 1380, 1);
#nullable restore
#line 32 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
WriteAttributeValue("", 1351, T("Checkout.TermsOfService"), 1351, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none;\">\r\n            <p>");
#nullable restore
#line 33 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
          Write(T("Checkout.TermsOfService.PleaseAccept"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"terms-of-service\">\r\n            <input id=\"termsofservice\" type=\"checkbox\" name=\"termsofservice\"/>\r\n            <label for=\"termsofservice\">");
#nullable restore
#line 37 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                                   Write(T("Checkout.TermsOfService.IAccept"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 38 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
             if (Model.TermsOfServicePopup)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"read\" id=\"read-terms\">");
#nullable restore
#line 40 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                                           Write(T("Checkout.TermsOfService.Read"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                <script>
                    $(document).ready(function() {
                        $('#read-terms').on('click', function(e) {
                            e.preventDefault();
                            displayPopupContentFromUrl('");
#nullable restore
#line 45 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                                                   Write(Url.RouteUrl("TopicPopup", new {SystemName = "conditionsofuse"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 45 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                                                                                                                        Write(T("Checkout.TermsOfService"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n                        });\r\n                    });\r\n                </script>\r\n");
#nullable restore
#line 49 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"read\" id=\"read-terms\"");
            BeginWriteAttribute("href", " href=\"", 2370, "\"", 2467, 1);
#nullable restore
#line 52 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
WriteAttributeValue("", 2377, Url.RouteUrl("Topic", new { SeName = await Html.GetTopicSeNameAsync("conditionsofuse") }), 2377, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
                                                                                                                                             Write(T("Checkout.TermsOfService.Read"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 53 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 55 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Checkout\OpcConfirmOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutConfirmModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
