#pragma checksum "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2496992eeffd3c6750e6368616e3a5f493054858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Quick_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Quick/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2496992eeffd3c6750e6368616e3a5f493054858", @"/Views/Shared/Components/Quick/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb1030be5de95d240de52d5c4f3aad74a4c1400", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Quick_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal"" id=""quick_view"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <!-- product details inner end -->
                <div class=""product-details-inner"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            <div class=""product-large-slider mb-20"">
");
#nullable restore
#line 15 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                 foreach (var item in Model.ProductImages.Where(m => m.IsMain))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"pro-large-img img-zoom\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2496992eeffd3c6750e6368616e3a5f4930548584989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 870, "~/assets/img/product/", 870, 21, true);
#nullable restore
#line 18 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
AddHtmlAttributeValue("", 891, item.Image, 891, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 20 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"pro-nav slick-row-5\">\r\n");
#nullable restore
#line 23 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                 foreach (var item in Model.ProductImages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"pro-nav-thumb\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2496992eeffd3c6750e6368616e3a5f4930548587375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1277, "~/assets/img/product/", 1277, 21, true);
#nullable restore
#line 25 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
AddHtmlAttributeValue("", 1298, item.Image, 1298, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div class=\"col-lg-7\">\r\n                            <div class=\"product-details-des\">\r\n                                <h3 class=\"pro-det-title\">");
#nullable restore
#line 31 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                <div class=""pro-review"">
                                    <span><a href=""#"">1 Review(s)</a></span>
                                </div>
                                <div class=""price-box"">
                                    <span class=""regular-price"">$");
#nullable restore
#line 36 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                                             Write((Model.Price-((Model.Price/100)*Model.ProductDiscount)).ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"old-price\"><del>$");
#nullable restore
#line 37 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                                              Write(Model.Price.ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></span>\r\n                                </div>\r\n                                <p>");
#nullable restore
#line 39 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <div class=""quantity-cart-box d-flex align-items-center mb-20"">
                                    <div class=""quantity"">
                                        <div class=""pro-qty""><input type=""text"" value=""1""></div>
                                    </div>
                                    <a href=""cart.html"" class=""btn btn-default"">Add To Cart</a>
                                </div>
                                <div class=""availability mb-20"">
                                    <h5 class=""cat-title"">Availability:</h5>
                                    <span>In Stock</span>
                                </div>
                                <div class=""share-icon"">
                                    <h5 class=""cat-title"">Share:</h5>
");
#nullable restore
#line 52 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                     foreach (var item in Model.socials)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 3189, "\"", 3202, 1);
#nullable restore
#line 54 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
WriteAttributeValue("", 3197, item, 3197, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 55 "C:\Users\FX516PM\Desktop\fazil048\Juan-Back-End\Juan\Juan\Views\Shared\Components\Quick\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- product details inner end -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
