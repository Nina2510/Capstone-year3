#pragma checksum "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb9b344cca2c9337fe53992fa25af21746ed7dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_InventoryLedger), @"mvc.1.0.view", @"/Views/Finance/InventoryLedger.cshtml")]
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
#line 1 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb9b344cca2c9337fe53992fa25af21746ed7dc", @"/Views/Finance/InventoryLedger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4bf2ce06d2348b1b31570fc36637b69493ab809", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_InventoryLedger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Capstonetest1.Models.InventoryLedger>>
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
#line 4 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fb9b344cca2c9337fe53992fa25af21746ed7dc4544", async() => {
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
            WriteLiteral(@"
</div>
<Center>
<h1>Inventory</h1>
</Center>

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
#line 25 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayNameFor(model => model.ref_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n                     ");
#nullable restore
#line 28 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n                     ");
#nullable restore
#line 31 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayNameFor(model => model.Explaination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n                     ");
#nullable restore
#line 34 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayNameFor(model => model.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n                     ");
#nullable restore
#line 37 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayNameFor(model => model.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n                     ");
#nullable restore
#line 40 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  </tr>\r\n                  </thead>\r\n                  <tbody>\r\n\r\n");
#nullable restore
#line 46 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                   foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                  <th>\r\n                     ");
#nullable restore
#line 49 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayFor(modelItem => item.ref_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n                     ");
#nullable restore
#line 52 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n                     ");
#nullable restore
#line 55 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayFor(modelItem => item.Explaination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  <th>\r\n");
#nullable restore
#line 58 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                 if(@item.Debit == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <pre>\r\n                  </pre>\r\n");
#nullable restore
#line 61 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                    }
                   else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <pre>\r\n                ");
#nullable restore
#line 64 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
           Write(Html.DisplayFor(modelItem => item.Debit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </pre>\r\n");
#nullable restore
#line 66 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\r\n                <th>\r\n");
#nullable restore
#line 69 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                 if(@item.Credit == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <pre>\r\n                </pre>\r\n");
#nullable restore
#line 72 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <pre>\r\n                ");
#nullable restore
#line 75 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
           Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </pre>\r\n");
#nullable restore
#line 77 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\r\n\r\n                  <th>\r\n                     ");
#nullable restore
#line 81 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                Write(Html.DisplayFor(modelItem => item.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </th>\r\n                  </tr>");
#nullable restore
#line 83 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\InventoryLedger.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Capstonetest1.Models.InventoryLedger>> Html { get; private set; }
    }
}
#pragma warning restore 1591
