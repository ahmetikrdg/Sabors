#pragma checksum "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Shared\Components\VideoOne\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a626a4abd8420415fe5a58d41e9a75936cd1a0be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VideoOne_default), @"mvc.1.0.view", @"/Views/Shared/Components/VideoOne/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a626a4abd8420415fe5a58d41e9a75936cd1a0be", @"/Views/Shared/Components/VideoOne/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"569868dba2ab1ffe56df63abbed74752be026ec9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VideoOne_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Shared\Components\VideoOne\default.cshtml"
 foreach (var item in Model.Videos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"td_wrapper_player td_wrapper_playlist_player_youtube\" data-first-video=\"\" data-autoplay=\"1\">\r\n        <div id=\"player_youtube\" style=\"height: 100%\">\r\n            <iframe id=\"iframesbNNlZXTIfg\"");
            BeginWriteAttribute("src", " src=\"", 277, "\"", 322, 2);
            WriteAttributeValue("", 283, "https://www.youtube.com/embed/", 283, 30, true);
#nullable restore
#line 7 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Shared\Components\VideoOne\default.cshtml"
WriteAttributeValue("", 313, item.Url, 313, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\"");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 419, "\"", 437, 0);
            EndWriteAttribute();
            WriteLiteral("></iframe>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\Ahmet\OneDrive\Masaüstü\Sabor-2-main\Sabor2\SABOR PROJESİ\Sabor\Sabor\Views\Shared\Components\VideoOne\default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
