#pragma checksum "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e908e8556749ff760edb015d7bb41abdc970d26b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Productses), @"mvc.1.0.view", @"/Views/Home/Productses.cshtml")]
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
#line 1 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\_ViewImports.cshtml"
using Sabor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\_ViewImports.cshtml"
using Sabor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\_ViewImports.cshtml"
using Sabor.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e908e8556749ff760edb015d7bb41abdc970d26b", @"/Views/Home/Productses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"569868dba2ab1ffe56df63abbed74752be026ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Productses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
 foreach (var p in Model.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e908e8556749ff760edb015d7bb41abdc970d26b5444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 204, "~/img/", 204, 6, true);
#nullable restore
#line 9 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
AddHtmlAttributeValue("", 210, p.Image, 210, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                              Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e908e8556749ff760edb015d7bb41abdc970d26b7468", async() => {
                WriteLiteral("İçerik");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Urunid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                                                WriteLiteral(p.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Urunid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Urunid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Urunid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <nav aria-label=\"Page navigation example\">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 23 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                 for (int i = 0; i < Model.pageInfo.TotalPages(); i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                     if (string.IsNullOrEmpty(Model.pageInfo.CurrentCategory))//kategori dolumu boşmu
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 860, "\"", 924, 2);
            WriteAttributeValue("", 868, "page-item", 868, 9, true);
#nullable restore
#line 27 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
WriteAttributeValue(" ", 877, Model.pageInfo.CurrentPage==i+1?"active":"", 878, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            WriteLiteral("\r\n");
            WriteLiteral("                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1199, "\"", 1231, 2);
            WriteAttributeValue("", 1206, "/Sbr/Urunler?pages=", 1206, 19, true);
#nullable restore
#line 30 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
WriteAttributeValue("", 1225, i+1, 1225, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
            WriteLiteral("\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 32 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 35 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 1623, "\"", 1687, 2);
            WriteAttributeValue("", 1631, "page-item", 1631, 9, true);
#nullable restore
#line 38 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
WriteAttributeValue(" ", 1640, Model.pageInfo.CurrentPage==i+1?"active":"", 1641, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1739, "\"", 1803, 4);
            WriteAttributeValue("", 1746, "/Sbr/Urunler/", 1746, 13, true);
#nullable restore
#line 39 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
WriteAttributeValue("", 1759, Model.pageInfo.CurrentCategory, 1759, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1790, "?pages=", 1790, 7, true);
#nullable restore
#line 39 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
WriteAttributeValue("", 1797, i+1, 1797, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 40 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 43 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Home\Productses.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
