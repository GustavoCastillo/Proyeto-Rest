#pragma checksum "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f310535276951a1b5f06add51d97baf8435c990c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
#line 1 "C:\Backup\REST-Course\Proyecto\client\Views\_ViewImports.cshtml"
using client;

#line default
#line hidden
#line 2 "C:\Backup\REST-Course\Proyecto\client\Views\_ViewImports.cshtml"
using client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f310535276951a1b5f06add51d97baf8435c990c", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9f85395c65758c7930ba537410c3f2750bee7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebClient.Models.BookDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 115, true);
            WriteLiteral("\r\n    <h1>Book Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(200, 43, false);
#line 14 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.book.Id));

#line default
#line hidden
            EndContext();
            BeginContext(243, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(305, 39, false);
#line 17 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.book.Id));

#line default
#line hidden
            EndContext();
            BeginContext(344, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(405, 45, false);
#line 20 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(450, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(512, 41, false);
#line 23 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(553, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(614, 52, false);
#line 26 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.book.Description));

#line default
#line hidden
            EndContext();
            BeginContext(666, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(728, 48, false);
#line 29 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.book.Description));

#line default
#line hidden
            EndContext();
            BeginContext(776, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(837, 49, false);
#line 32 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.book.Category));

#line default
#line hidden
            EndContext();
            BeginContext(886, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(948, 45, false);
#line 35 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.book.Category));

#line default
#line hidden
            EndContext();
            BeginContext(993, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1041, 59, false);
#line 40 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.book.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1108, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f310535276951a1b5f06add51d97baf8435c990c7438", async() => {
                BeginContext(1130, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1146, 83, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
            BeginContext(1354, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1397, 50, false);
#line 53 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.review.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1515, 48, false);
#line 56 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.review.Votes));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 89, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n            <tr>\r\n");
            EndContext();
#line 61 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                 using (Html.BeginForm("CreateReview", "Book",new { review = Model.review, Idlibro = Model.book.Id, enctype = "multipart/form-data" },FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(1840, 89, true);
            WriteLiteral("                    <th>\r\n                        <label class=\"control-label\"></label>\r\n");
            EndContext();
            BeginContext(2002, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2027, 66, false);
#line 66 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                   Write(Html.TextBoxFor(m=> m.review.Comment, new {@class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2188, 116, true);
            WriteLiteral("                    </th>\r\n                    <th>\r\n                        <label class=\"control-label\"></label>\r\n");
            EndContext();
            BeginContext(2404, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2429, 104, false);
#line 72 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                   Write(Html.TextBoxFor(m => m.review.Votes, new { @class = "form-control",@type="number", @min="0", @max="5" }));

#line default
#line hidden
            EndContext();
            BeginContext(2533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2626, 168, true);
            WriteLiteral("                    </th>\r\n                    <th>\r\n                        <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n                    </th>\r\n");
            EndContext();
#line 78 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(2813, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 82 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
             foreach (var item in Model.bookReviews)
            {

#line default
#line hidden
            BeginContext(2936, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
            BeginContext(3087, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(3138, 42, false);
#line 89 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(3180, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3260, 40, false);
#line 92 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Votes));

#line default
#line hidden
            EndContext();
            BeginContext(3300, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 95 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                         using (@Html.BeginForm("DeleteReview", "Book", new { id = item.Id, Idlibro = Model.book.Id, enctype = "multipart/form-data" }, FormMethod.Post))
                        {

#line default
#line hidden
            BeginContext(3553, 91, true);
            WriteLiteral("                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n");
            EndContext();
#line 98 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(3671, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 101 "C:\Backup\REST-Course\Proyecto\client\Views\Book\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(3736, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebClient.Models.BookDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
