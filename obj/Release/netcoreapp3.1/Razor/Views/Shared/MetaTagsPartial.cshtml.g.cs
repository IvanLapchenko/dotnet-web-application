#pragma checksum "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21de656e6da7b3fb07545d65a7dd4969d2f193ee"
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
using WebApp.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21de656e6da7b3fb07545d65a7dd4969d2f193ee", @"/Views/Shared/MetaTagsPartial.cshtml")]
    public class Views_Shared_MetaTagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginWriteAttribute("content", " content=\"", 328, "\"", 358, 1);
#nullable restore
#line 16 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 338, ViewBag.Description, 338, 20, false);

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
            BeginWriteAttribute("content", " content=\"", 431, "\"", 458, 1);
#nullable restore
#line 22 "C:\Users\Ivan\source\repos\WebApp\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 441, ViewBag.Keywords, 441, 17, false);

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
