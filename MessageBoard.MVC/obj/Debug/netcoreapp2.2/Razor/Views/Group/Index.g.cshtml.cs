#pragma checksum "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84568a0847fa6ac4cce1207d8d5df472f8725566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Index), @"mvc.1.0.view", @"/Views/Group/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/Index.cshtml", typeof(AspNetCore.Views_Group_Index))]
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
#line 1 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/_ViewImports.cshtml"
using MessageBoard.MVC;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/_ViewImports.cshtml"
using MessageBoard.MVC.Models;

#line default
#line hidden
#line 1 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Index.cshtml"
using MessageBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84568a0847fa6ac4cce1207d8d5df472f8725566", @"/Views/Group/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6423bb468518fcccaba76c533014b62fd70ab5", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Index.cshtml"
 foreach(Group group in @Model)
{

#line default
#line hidden
            BeginContext(63, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(71, 72, false);
#line 5 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Index.cshtml"
  Write(Html.ActionLink($"{@group.Title}", "Details", new { id = group.GroupId}));

#line default
#line hidden
            EndContext();
            BeginContext(143, 6, true);
            WriteLiteral(" </p>\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Index.cshtml"
}

#line default
#line hidden
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
