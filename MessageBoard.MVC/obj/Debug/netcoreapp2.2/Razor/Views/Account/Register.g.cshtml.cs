#pragma checksum "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d3c0d0eb0e17da1476c3d94424a06f068b85f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 1 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
using MessageBoard.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d3c0d0eb0e17da1476c3d94424a06f068b85f1", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6423bb468518fcccaba76c533014b62fd70ab5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 37, true);
            WriteLiteral("\n<h2>Register a new user</h2>\n<hr />\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(165, 33, false);
#line 9 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
Write(Html.LabelFor(user => user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(204, 34, false);
#line 10 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
Write(Html.TextBoxFor(user=> user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(245, 35, false);
#line 12 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
Write(Html.LabelFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(286, 38, false);
#line 13 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user=> user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(331, 42, false);
#line 15 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
Write(Html.LabelFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(379, 45, false);
#line 16 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
Write(Html.PasswordFor(user=> user.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(426, 45, true);
            WriteLiteral("    <input type=\"submit\" value=\"Register\" />\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Register.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591