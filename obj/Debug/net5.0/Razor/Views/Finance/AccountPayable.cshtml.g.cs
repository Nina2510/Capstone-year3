#pragma checksum "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab796d5339ad3fed49c393cba0dcfaf9789adde0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_AccountPayable), @"mvc.1.0.view", @"/Views/Finance/AccountPayable.cshtml")]
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
#nullable restore
#line 1 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab796d5339ad3fed49c393cba0dcfaf9789adde0", @"/Views/Finance/AccountPayable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4bf2ce06d2348b1b31570fc36637b69493ab809", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_AccountPayable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Capstonetest1.Models.AccountPayable>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Finance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ledger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab796d5339ad3fed49c393cba0dcfaf9789adde04536", async() => {
                WriteLiteral("Back to General Ledger Page");
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
            WriteLiteral("\r\n</div>\r\n\r\n<center><h1>Account Payable</h1></Center>\r\n\r\n<center>\r\n<div class=\"input-group-append\">\r\n");
#nullable restore
#line 16 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
 using(Html.BeginForm("AccountPayable","Finance", FormMethod.Get)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"date\" name=\"pay_date\" value=\"2022-03-31\" min=\"2022-03-01\" max=\"2022-05-01\"/>\r\n    <input type=\"submit\" name=\"submit\" value=\"Search\"/>\r\n");
#nullable restore
#line 19 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</center>

<center>
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
#line 32 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayNameFor(model => model.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayNameFor(model => model.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayNameFor(model => model.ref_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayFor(modelItem => item.Action));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayFor(modelItem => item.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
#nullable restore
#line 72 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
                 if(@item.Debit == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <pre>\r\n            </pre>\r\n");
#nullable restore
#line 75 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <pre>\r\n                ");
#nullable restore
#line 78 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayFor(modelItem => item.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </pre>\r\n");
#nullable restore
#line 80 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n");
#nullable restore
#line 83 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
                 if(@item.Credit == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <pre>\r\n            </pre>\r\n");
#nullable restore
#line 86 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <pre>\r\n                ");
#nullable restore
#line 89 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </pre>\r\n");
#nullable restore
#line 91 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
           Write(Html.DisplayFor(modelItem => item.ref_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n");
#nullable restore
#line 98 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\AccountPayable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Capstonetest1.Models.AccountPayable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
