#pragma checksum "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77ac9f3f55e161c8884dda2e636ccb5c0c03e7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetaTagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetaTagsPartial.cshtml")]
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
#line 3 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77ac9f3f55e161c8884dda2e636ccb5c0c03e7e2", @"/Views/Shared/MetaTagsPartial.cshtml")]
    #nullable restore
    public class Views_Shared_MetaTagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 7 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 8 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>Base Title</title>\r\n");
#nullable restore
#line 12 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 320, "\"", 350, 1);
#nullable restore
#line 16 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 330, ViewBag.Description, 330, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 423, "\"", 450, 1);
#nullable restore
#line 22 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 433, ViewBag.Keywords, 433, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 23 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
