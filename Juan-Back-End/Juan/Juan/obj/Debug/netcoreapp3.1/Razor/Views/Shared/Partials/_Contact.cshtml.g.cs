#pragma checksum "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Partials\_Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae326b531b3a108f3845a9d2d8cfa09d486b9c1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__Contact), @"mvc.1.0.view", @"/Views/Shared/Partials/_Contact.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\_ViewImports.cshtml"
using Juan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae326b531b3a108f3845a9d2d8cfa09d486b9c1c", @"/Views/Shared/Partials/_Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb1030be5de95d240de52d5c4f3aad74a4c1400", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContactUs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"contact-message\">\r\n        <h2 class=\"contact-title\">tell us your project</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae326b531b3a108f3845a9d2d8cfa09d486b9c1c5019", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-6 col-md-6 col-sm-6"">
                    <label name=""Name"" class=""col-form-label""><span class=""text-danger""></span></label>
                    <input name=""Name"" placeholder=""Name *"" type=""text"" required>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6"">
                    <label name=""PhoneNumber"" class=""col-form-label""><span class=""text-danger""></span></label>
                    <input name=""PhoneNumber"" placeholder=""Phone *"" type=""text"" required>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6"">
                    <label name=""Email"" class=""col-form-label""><span class=""text-danger""></span></label>
                    <input name=""Email"" placeholder=""Email *"" type=""text"" required>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6"">
                    <label name=""Subject"" class=""col-form-label""><span class=""text-danger""></span></label");
                WriteLiteral(@">
                    <input name=""Subject"" placeholder=""Subject *"" type=""text"">
                </div>
                <div class=""col-12"">
                    <div class=""contact2-textarea text-center"">
                        <label name=""Message"" class=""col-form-label""><span class=""text-danger""></span></label>
                        <textarea placeholder=""Message *"" name=""Message"" class=""form-control2""");
                BeginWriteAttribute("required", " required=\"", 1633, "\"", 1644, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                    </div>
                    <div class=""contact-btn"">
                        <button class=""btn"" type=""submit"">Send Message</button>
                    </div>
                </div>
                <div class=""col-12 d-flex justify-content-center"">
                    <p class=""form-messege""></p>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591