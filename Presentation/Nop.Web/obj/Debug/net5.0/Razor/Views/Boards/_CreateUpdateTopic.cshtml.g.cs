#pragma checksum "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f61ab392a6f328fe666b518f0e20737f77a113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards__CreateUpdateTopic), @"mvc.1.0.view", @"/Views/Boards/_CreateUpdateTopic.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
using Nop.Core.Domain.Forums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f61ab392a6f328fe666b518f0e20737f77a113", @"/Views/Boards/_CreateUpdateTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d1b9cf4fa5ba34fd858c89c406a07634618cfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Boards__CreateUpdateTopic : Nop.Web.Framework.Mvc.Razor.NopRazorPage<EditForumTopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message-error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forum-topic-title-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forum-post-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper __Nop_Web_Framework_TagHelpers_Public_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.NopBBCodeEditorTagHelper __Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.TextAreaTagHelper __Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.NopGenerateCaptchaTagHelper __Nop_Web_Framework_TagHelpers_Public_NopGenerateCaptchaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
  
    //page class
    Html.AppendPageCssClassParts("html-forum-edit-page");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
Write(await Component.InvokeAsync("ForumBreadcrumb", new { forumId = Model.ForumId, forumTopicId = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page forum-edit-page\">\r\n    <div class=\"page-title\">\r\n");
#nullable restore
#line 11 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
         if (Model.IsEdit)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 13 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
           Write(T("Forum.EditTopic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 14 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 17 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
           Write(T("Forum.NewTopic"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 18 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"page-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f61ab392a6f328fe666b518f0e20737f77a11314099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 21 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7f61ab392a6f328fe666b518f0e20737f77a11315747", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7f61ab392a6f328fe666b518f0e20737f77a11317421", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 23 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ForumId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"fieldset\">\r\n            <div class=\"form-fields\">\r\n                <div class=\"inputs\">\r\n                    <label>");
#nullable restore
#line 27 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                      Write(T("Forum.ForumName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    <strong>");
#nullable restore
#line 28 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                       Write(Model.ForumName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </div>\r\n                <div class=\"inputs\">\r\n                    <label>");
#nullable restore
#line 31 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                      Write(T("Forum.TopicTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7f61ab392a6f328fe666b518f0e20737f77a11320247", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 32 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subject);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f61ab392a6f328fe666b518f0e20737f77a11321813", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 33 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subject);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"inputs\">\r\n");
#nullable restore
#line 36 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                     if (Model.ForumEditor == EditorType.BBCodeEditor)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-bb-code-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7f61ab392a6f328fe666b518f0e20737f77a11323763", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.NopBBCodeEditorTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper);
#nullable restore
#line 38 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Text);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_NopBBCodeEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f61ab392a6f328fe666b518f0e20737f77a11325553", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            __Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper);
#nullable restore
#line 40 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Text);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Nop_Web_Framework_TagHelpers_Public_TextAreaTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For;
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f61ab392a6f328fe666b518f0e20737f77a11327532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 41 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Text);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 43 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                 if (Model.IsCustomerAllowedToSetTopicPriority)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"inputs\">\r\n                        <label>");
#nullable restore
#line 46 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                          Write(T("Forum.Priority"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f61ab392a6f328fe666b518f0e20737f77a11329795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 47 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TopicTypeId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.TopicPriorities, "Value", "Text", Model.TopicTypeId));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 49 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                 if (Model.IsCustomerAllowedToSubscribe)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"inputs reversed\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7f61ab392a6f328fe666b518f0e20737f77a11332451", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 53 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subscribed);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f61ab392a6f328fe666b518f0e20737f77a11333941", async() => {
#nullable restore
#line 54 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                                               Write(T("Forum.NotifyWhenSomeonePostsInThisTopic"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
            __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_LabelTagHelper);
#nullable restore
#line 54 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Subscribed);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For;
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 56 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                 if (Model.DisplayCaptcha)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-captcha", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7f61ab392a6f328fe666b518f0e20737f77a11336633", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Public_NopGenerateCaptchaTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.NopGenerateCaptchaTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_NopGenerateCaptchaTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"buttons\">\r\n            <button type=\"submit\" class=\"button-1 submit-topic-button\">");
#nullable restore
#line 64 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                                                                  Write(T("Forum.Submit"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            <button type=\"button\" class=\"button-2 cancel-topic-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2690, "\"", 2795, 3);
            WriteAttributeValue("", 2700, "setLocation(\'", 2700, 13, true);
#nullable restore
#line 65 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
WriteAttributeValue("", 2713, Url.RouteUrl("ForumSlug", new { id = Model.ForumId, slug = Model.ForumSeName }), 2713, 80, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2793, "\')", 2793, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "C:\Users\Piyash\Downloads\nopCommerce_4.40.4_Source\Presentation\Nop.Web\Views\Boards\_CreateUpdateTopic.cshtml"
                                                                                                                                                                            Write(T("Forum.Cancel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditForumTopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591