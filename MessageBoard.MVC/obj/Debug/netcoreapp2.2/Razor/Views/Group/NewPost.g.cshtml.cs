#pragma checksum "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb881edaf4b2816b4a705c007b6c541a0c25619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_NewPost), @"mvc.1.0.view", @"/Views/Group/NewPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/NewPost.cshtml", typeof(AspNetCore.Views_Group_NewPost))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb881edaf4b2816b4a705c007b6c541a0c25619", @"/Views/Group/NewPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b6423bb468518fcccaba76c533014b62fd70ab5", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_NewPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageBoard.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(67, 35, false);
#line 5 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.LabelFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(108, 37, false);
#line 6 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.TextBoxFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(151, 34, false);
#line 7 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.LabelFor(model => model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(191, 36, false);
#line 8 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.TextBoxFor(model => model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(233, 38, false);
#line 9 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.LabelFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(277, 40, false);
#line 10 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.TextBoxFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(323, 40, false);
#line 11 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.LabelFor(model => model.DateOfPost));

#line default
#line hidden
            EndContext();
            BeginContext(369, 42, false);
#line 12 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.TextBoxFor(model => model.DateOfPost));

#line default
#line hidden
            EndContext();
            BeginContext(412, 52, true);
            WriteLiteral("    <input id=\"GroupId\" name=\"GroupId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 464, "\"", 485, 1);
#line 13 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
WriteAttributeValue("", 472, ViewBag.Data, 472, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(486, 4, true);
            WriteLiteral(" />\n");
            EndContext();
            BeginContext(495, 39, false);
#line 14 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
Write(Html.TextBoxFor(model => model.user.Id));

#line default
#line hidden
            EndContext();
            BeginContext(536, 73, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new item\" class=\"btn btn-default\" />\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/MessageBoard.Solution2/MessageBoard.MVC/Views/Group/NewPost.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageBoard.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
