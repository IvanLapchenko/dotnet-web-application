#pragma checksum "C:\Users\Ivan\source\repos\WebApp\Views\Shared\BannerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13ef4301c40f9c2cc21caa1caffb2e4470661365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BannerPartial), @"mvc.1.0.view", @"/Views/Shared/BannerPartial.cshtml")]
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
#line 1 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\BannerPartial.cshtml"
using WebApp.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ef4301c40f9c2cc21caa1caffb2e4470661365", @"/Views/Shared/BannerPartial.cshtml")]
    public class Views_Shared_BannerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"banner\">\r\n\t<div class=\"inner\">\r\n\t\t<div class=\"logo\"><span class=\"icon fa-gem\"></span></div>\r\n\t\t<h2>This is ");
#nullable restore
#line 5 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\BannerPartial.cshtml"
               Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t<p>Another free + fully responsive site template by <a href=\"http://html5up.net\">HTML5 UP</a></p>\r\n\t</div>\r\n</section>");
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