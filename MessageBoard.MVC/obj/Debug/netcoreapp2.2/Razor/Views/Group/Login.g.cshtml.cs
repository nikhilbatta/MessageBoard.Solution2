#pragma checksum "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4bdc718a337855ef6dcc521dcfbc6f1ef8ff55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Login), @"mvc.1.0.view", @"/Views/Group/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/Login.cshtml", typeof(AspNetCore.Views_Group_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4bdc718a337855ef6dcc521dcfbc6f1ef8ff55", @"/Views/Group/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6423bb468518fcccaba76c533014b62fd70ab5", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageBoard.Entities.User1>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(70, 33, false);
#line 5 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(109, 40, false);
#line 6 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.HiddenFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(155, 39, false);
#line 7 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.HiddenFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(200, 38, false);
#line 8 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.LabelFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(244, 40, false);
#line 9 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.TextBoxFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(290, 38, false);
#line 10 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(334, 40, false);
#line 11 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.TextBoxFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(380, 36, false);
#line 12 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(Html.HiddenFor(model => model.Token));

#line default
#line hidden
            EndContext();
            BeginContext(425, 73, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new item\" class=\"btn btn-default\" />\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
}

#line default
#line hidden
            BeginContext(501, 45, false);
#line 19 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Login.cshtml"
Write(await Html.PartialAsync("_MapPartial", Model));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageBoard.Entities.User1> Html { get; private set; }
    }
}
#pragma warning restore 1591
