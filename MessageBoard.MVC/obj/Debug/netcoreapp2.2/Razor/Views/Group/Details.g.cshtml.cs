#pragma checksum "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d59e40a01aeb51a9c3a0b447f2eadd28d31dc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Details), @"mvc.1.0.view", @"/Views/Group/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/Details.cshtml", typeof(AspNetCore.Views_Group_Details))]
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
#line 1 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
using MessageBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d59e40a01aeb51a9c3a0b447f2eadd28d31dc7", @"/Views/Group/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6423bb468518fcccaba76c533014b62fd70ab5", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
  
    int counter = 0;

#line default
#line hidden
            BeginContext(53, 19, true);
            WriteLiteral("<h1>Welcome To The ");
            EndContext();
            BeginContext(73, 11, false);
#line 5 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
              Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(84, 12, true);
            WriteLiteral(" Group</h1>\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
 foreach(Post post in @Model.Posts)
{

#line default
#line hidden
            BeginContext(134, 13, true);
            WriteLiteral("    <p> Post ");
            EndContext();
            BeginContext(149, 9, false);
#line 8 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
         Write(++counter);

#line default
#line hidden
            EndContext();
            BeginContext(159, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(172, 9, false);
#line 9 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
  Write(post.Body);

#line default
#line hidden
            EndContext();
            BeginContext(181, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
}

#line default
#line hidden
            BeginContext(189, 88, false);
#line 11 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/Details.cshtml"
Write(Html.ActionLink("new post for this group", "NewPost", "Group", new {id = Model.GroupId}));

#line default
#line hidden
            EndContext();
            BeginContext(277, 1, true);
            WriteLiteral("\n");
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