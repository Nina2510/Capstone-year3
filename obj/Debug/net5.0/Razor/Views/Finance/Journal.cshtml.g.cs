#pragma checksum "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a8989a12486f4caa06a328ab40d377b3f0dbc87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_Journal), @"mvc.1.0.view", @"/Views/Finance/Journal.cshtml")]
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
#line 1 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\_ViewImports.cshtml"
using Capstonetest1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\_ViewImports.cshtml"
using Capstonetest1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8989a12486f4caa06a328ab40d377b3f0dbc87", @"/Views/Finance/Journal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4bf2ce06d2348b1b31570fc36637b69493ab809", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_Journal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Capstonetest1.Models.Journal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Finance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
  
    ViewData["Title"] = "Journal";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a8989a12486f4caa06a328ab40d377b3f0dbc874348", async() => {
                WriteLiteral("Back to Finance Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<center><h1>General Journal</h1></center>\r\n\r\n<center>\r\n<div class=\"input-group-append\">\r\n");
#nullable restore
#line 16 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
 using(Html.BeginForm("Journal","Finance", FormMethod.Get)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"date\" name=\"sel_date\" value=\"2022-03-31\" min=\"2022-03-01\" max=\"2022-05-01\"/>\r\n    <input type=\"submit\" name=\"submit\" value=\"Search\"/>\r\n");
#nullable restore
#line 19 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</center>
  <div class=""row"">
          <div class=""col-12"">
            <div class=""card"">
              <div class=""card-header"">
                <div class=""card-body"">
                <table class=""table table-bordered"">
        <thead>
            <tr>
            <th>
                ");
#nullable restore
#line 30 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayNameFor(model => model.ref_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayNameFor(model => model.Truck_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayNameFor(model => model.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayNameFor(model => model.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayFor(modelItem => item.ref_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n             <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayFor(modelItem => item.Truck_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
#nullable restore
#line 68 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
                 if(@item.Action == "Sale"){

#line default
#line hidden
#nullable disable
            WriteLiteral("<pre>\r\nAccount Receivable           ");
#nullable restore
#line 70 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n      Sale Revenue         &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;");
#nullable restore
#line 72 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</pre>\r\n");
#nullable restore
#line 74 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<pre>\r\nCost of Goods Sold           ");
#nullable restore
#line 77 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
                        Write(Html.DisplayFor(modelItem => item.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n         Inventory         &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;");
#nullable restore
#line 79 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</pre>\r\n");
#nullable restore
#line 81 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 84 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 87 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayFor(modelItem => item.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 90 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
           Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Journal.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Capstonetest1.Models.Journal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
