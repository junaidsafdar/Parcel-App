#pragma checksum "/Users/junaid/Projects/ProAdvantages/ProAdvantages/Views/Home/Parcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3ac953c877236a50b891b11b53e21d908a0adb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Parcel), @"mvc.1.0.view", @"/Views/Home/Parcel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Parcel.cshtml", typeof(AspNetCore.Views_Home_Parcel))]
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
#line 1 "/Users/junaid/Projects/ProAdvantages/ProAdvantages/Views/_ViewImports.cshtml"
using ProAdvantages;

#line default
#line hidden
#line 2 "/Users/junaid/Projects/ProAdvantages/ProAdvantages/Views/_ViewImports.cshtml"
using ProAdvantages.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3ac953c877236a50b891b11b53e21d908a0adb6", @"/Views/Home/Parcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4361c285c0b11f5a6d41191d2c7df1a768353930", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Parcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/junaid/Projects/ProAdvantages/ProAdvantages/Views/Home/Parcel.cshtml"
  
    ViewData["Title"] = "Parcel";

#line default
#line hidden
            BeginContext(42, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(47, 17, false);
#line 4 "/Users/junaid/Projects/ProAdvantages/ProAdvantages/Views/Home/Parcel.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(76, 19, false);
#line 5 "/Users/junaid/Projects/ProAdvantages/ProAdvantages/Views/Home/Parcel.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(95, 369, true);
            WriteLiteral(@"</h3>

<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title=""Phone"">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
");
            EndContext();
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