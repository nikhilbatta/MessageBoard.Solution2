#pragma checksum "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "775061f7a0f6342fa159142f6ff6b47dfa636502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 1 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml"
using MessageBoard.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775061f7a0f6342fa159142f6ff6b47dfa636502", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6423bb468518fcccaba76c533014b62fd70ab5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(54, 42, true);
            WriteLiteral("\n<h2>Log in with your account</h2>\n<hr />\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(129, 27, false);
#line 9 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(162, 29, false);
#line 10 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(198, 30, false);
#line 12 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(234, 33, false);
#line 13 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(269, 67, true);
            WriteLiteral("    <input type=\"submit\" value=\"Log in\" class=\"btn btn-default\" />\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Account/Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
