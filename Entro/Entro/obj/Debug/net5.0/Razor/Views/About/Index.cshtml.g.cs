#pragma checksum "C:\Users\FX505GT\Desktop\ASP.NET\Entro\Entro\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d13881886221d8a85aec464b5b4bd55466f7e5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\FX505GT\Desktop\ASP.NET\Entro\Entro\Views\_ViewImports.cshtml"
using Entro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\ASP.NET\Entro\Entro\Views\_ViewImports.cshtml"
using Entro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d13881886221d8a85aec464b5b4bd55466f7e5d", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"978389c083d6e6e33e5cabaca45dcd92b1d82ecb", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entro.Models.ViewModels.HomeRelated>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\FX505GT\Desktop\ASP.NET\Entro\Entro\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""backgro_mh"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""heding"">
                    <h2>About</h2>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- about  -->
<div id=""about"" class=""about"">
    <div class=""container"">
        <div class=""row display_boxflex"">
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12"">
                <div class=""about-box"">
                    <h2>");
#nullable restore
#line 25 "C:\Users\FX505GT\Desktop\ASP.NET\Entro\Entro\Views\About\Index.cshtml"
                   Write(Model.about.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>\r\n                        ");
#nullable restore
#line 27 "C:\Users\FX505GT\Desktop\ASP.NET\Entro\Entro\Views\About\Index.cshtml"
                   Write(Model.about.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <a href=""Javascript:void(0)"">Read More</a>
                </div>
            </div>
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12"">
                <div class=""about-box"">
                    <figure><img");
            BeginWriteAttribute("src", " src=\"", 983, "\"", 1014, 2);
            WriteAttributeValue("", 989, "images/", 989, 7, true);
#nullable restore
#line 34 "C:\Users\FX505GT\Desktop\ASP.NET\Entro\Entro\Views\About\Index.cshtml"
WriteAttributeValue("", 996, Model.about.Image, 996, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" /></figure>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!-- end abouts -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entro.Models.ViewModels.HomeRelated> Html { get; private set; }
    }
}
#pragma warning restore 1591