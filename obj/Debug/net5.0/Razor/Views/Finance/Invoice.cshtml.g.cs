#pragma checksum "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10703d131c2855dcd5e4b14b2cd0c8203b8b7fce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance_Invoice), @"mvc.1.0.view", @"/Views/Finance/Invoice.cshtml")]
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
#line 1 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10703d131c2855dcd5e4b14b2cd0c8203b8b7fce", @"/Views/Finance/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4bf2ce06d2348b1b31570fc36637b69493ab809", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Capstonetest1.Models.Invoice>>
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
#line 4 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
  
    ViewData["Title"] = "Invoice";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10703d131c2855dcd5e4b14b2cd0c8203b8b7fce4528", async() => {
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
            WriteLiteral("\r\n</div>\r\n<h1>Invoice</h1>\r\n\r\n<center>\r\n<h2>Type Invoice Number</h2>\r\n");
#nullable restore
#line 16 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
 using(Html.BeginForm("Invoice","Finance", FormMethod.Get)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"string\" name=\"invoice_search\"");
            BeginWriteAttribute("value", " value=\"", 469, "\"", 477, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n    <input type=\"submit\" name=\"submit\" value=\"Search\"/>\r\n");
#nullable restore
#line 19 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</center>\r\n<br>\r\n<br>\r\n            <!-- Main content -->\r\n            <div class=\"invoice p-3 mb-3\">\r\n              <!-- title row -->\r\n              <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                  <h4>\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 795, "\"", 803, 0);
            EndWriteAttribute();
            WriteLiteral("></i>Paid Sale Invoice\r\n                    <small class=\"float-right\">Date:");
#nullable restore
#line 30 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                           Write(Html.DisplayFor(modelItem => item.invoice_date));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </small>
                  </h4>
                </div>
                <!-- /.col -->
              </div>
              <!-- info row -->
              <div class=""row invoice-info"">
                <div class=""col-sm-4 invoice-col"">
                  <address>
                    <strong>Tax Payer:</strong>
");
#nullable restore
#line 40 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                      foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.taxpayer_id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\r\n                    <strong>Customer ID:</strong>\r\n");
#nullable restore
#line 43 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.customer_id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\r\n                    <strong>Customer name:</strong>\r\n");
#nullable restore
#line 46 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                     foreach(var item in Model){ 

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.customer_name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\r\n                  </address>\r\n                </div>\r\n                <!-- /.col -->\r\n                <div class=\"col-sm-4 invoice-col\">\r\n\r\n                  <address>\r\n                    <strong>Customer Address</strong><br>\r\n");
#nullable restore
#line 55 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.customer_address));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </address>\r\n                </div>\r\n                <!-- /.col -->\r\n                <div class=\"col-sm-4 invoice-col\">\r\n                  <b>Invoice No: ");
#nullable restore
#line 60 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                  foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                        Write(Html.DisplayFor(modelItem => item.Invoice_no));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br>\r\n                  <br>\r\n                  <b>PO_Number No:</b> ");
#nullable restore
#line 62 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                        foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.po_number));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                  <b>Payment No:</b> ");
#nullable restore
#line 63 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                      foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Payment_NO));

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
                </div>
                <!-- /.col -->
              </div>
              <!-- /.row -->

              <!-- Table row -->
              <div class=""row"">
                <div class=""col-12 table-responsive"">
                  <table class=""table table-striped"">
                    <thead>
                    <tr>
                      <th>Qty</th>
                      <th>Type</th>
                      <th>Price/Liters</th>
                      <th>Total Price</th>
                    </tr>
                    </thead>
                    <tbody>
                    <tr>
                      <td>");
#nullable restore
#line 83 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                           foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Litres));

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td>");
#nullable restore
#line 84 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                           foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.pretrol_type));

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td>");
#nullable restore
#line 85 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                           foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Price_Litres));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      <td>");
#nullable restore
#line 86 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                           foreach(var item in Model){

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\Finance\Invoice.cshtml"
                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                    </tbody>
                  </table>
                </div>
                <!-- /.col -->
              </div>
              <!-- /.row -->

              <!-- this row will not appear when printing -->
              <div class=""row no-print"">
                <div class=""col-12"">
                  <a href=""invoice-print.html"" rel=""noopener"" target=""_blank"" class=""btn btn-default""><i class=""fas fa-print""></i> Print</a>
                  <button type=""button"" class=""btn btn-success float-right""><i class=""far fa-credit-card""></i> Submit
                    Payment
                  </button>
                  <button type=""button"" class=""btn btn-primary float-right"" style=""margin-right: 5px;"">
                    <i class=""fas fa-download""></i> Generate PDF
                  </button>
                </div>
              </div>
            </div>
            <!-- /.invoice -->
          </div><!-- /.col -->
        </div><!-- /.row -->
");
            WriteLiteral("      </div><!-- /.container-fluid -->\r\n    </section>\r\n    <!-- /.content -->\r\n  </div>\r\n  <!-- /.content-wrapper -->\r\n  <footer class=\"main-footer no-print\">\r\n    <div class=\"float-right d-none d-sm-block\">\r\n      <b></b>\r\n    </div>\r\n    <strong>  <a");
            BeginWriteAttribute("href", " href=\"", 4921, "\"", 4928, 0);
            EndWriteAttribute();
            WriteLiteral("></a>.</strong>\r\n  </footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Capstonetest1.Models.Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591