#pragma checksum "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18e389d07ebbc192df263e116bea008f7df1f670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Businesses_Index), @"mvc.1.0.view", @"/Views/Businesses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Businesses/Index.cshtml", typeof(AspNetCore.Views_Businesses_Index))]
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
#line 1 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/_ViewImports.cshtml"
using BizLookupMvc;

#line default
#line hidden
#line 2 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/_ViewImports.cshtml"
using BizLookupMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e389d07ebbc192df263e116bea008f7df1f670", @"/Views/Businesses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8843a0a05d307e23ba039b06dc14e77843379e", @"/Views/_ViewImports.cshtml")]
    public class Views_Businesses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/businesses"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 379, true);
            WriteLiteral(@"
<h1>All Businesses:</h1>

<table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Industry</th>
                <th>Hours</th>
                <th>Address</th>
                <th>Website</th>
                <th>Phone</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
             foreach (Business business in Model)
            {

#line default
#line hidden
            BeginContext(485, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(531, 19, false);
#line 24 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
                   Write(business.BusinessId);

#line default
#line hidden
            EndContext();
            BeginContext(550, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(581, 13, false);
#line 25 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
                   Write(business.Name);

#line default
#line hidden
            EndContext();
            BeginContext(594, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(625, 17, false);
#line 26 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
                   Write(business.Industry);

#line default
#line hidden
            EndContext();
            BeginContext(642, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(673, 14, false);
#line 27 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
                   Write(business.Hours);

#line default
#line hidden
            EndContext();
            BeginContext(687, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(718, 16, false);
#line 28 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
                   Write(business.Address);

#line default
#line hidden
            EndContext();
            BeginContext(734, 32, true);
            WriteLiteral("</td>\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 766, "\"", 786, 1);
#line 29 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
WriteAttributeValue("", 773, business.URL, 773, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(787, 4, true);
            WriteLiteral("><p>");
            EndContext();
            BeginContext(792, 12, false);
#line 29 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
                                              Write(business.URL);

#line default
#line hidden
            EndContext();
            BeginContext(804, 40, true);
            WriteLiteral("</p></a></td>\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 844, "\"", 870, 2);
            WriteAttributeValue("", 851, "tel:", 851, 4, true);
#line 30 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
WriteAttributeValue("", 855, business.Phone, 855, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(871, 4, true);
            WriteLiteral("><p>");
            EndContext();
            BeginContext(876, 14, false);
#line 30 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
                                                    Write(business.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(890, 64, true);
            WriteLiteral("</p></a></td>\n                    <td><a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 954, "\"", 1003, 2);
            WriteAttributeValue("", 961, "/Businesses/Details/", 961, 20, true);
#line 31 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
WriteAttributeValue("", 981, business.BusinessId, 981, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1004, 52, true);
            WriteLiteral("><p>View Details</p></a></td>\n                </tr>\n");
            EndContext();
#line 33 "/Users/nathanschrader/Desktop/testproj/BizLookup.Solution/BizLookupMvc/Views/Businesses/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1070, 55, true);
            WriteLiteral("        </tbody>\n    </table>\n\n<h1>New Business:</h1>\n\n");
            EndContext();
            BeginContext(1125, 462, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18e389d07ebbc192df263e116bea008f7df1f6709406", async() => {
                BeginContext(1166, 414, true);
                WriteLiteral(@"
  <label for=""name"">Business Name</label>
  <input id=""name"" name=""name"" type=""text"">
  <label for=""industry"">Business Industry</label>
  <input id=""industry"" name=""industry"" type=""text"">
  <label for=""hours"">Business Hours</label>
  <input id=""hours"" name=""hours"" type=""text"">
  <label for=""address"">Business Address</label>
  <input id=""address"" name=""address"" type=""text"">
  <button type=""submit"">Go!</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1587, 3, true);
            WriteLiteral("\n\n\n");
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
