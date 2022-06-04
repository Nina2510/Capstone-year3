#pragma checksum "C:\Users\MBComputer\Desktop\Capstonetest1\Views\DayDashboard\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dee78273a7a22e1cc02b3b3c046ade43a6b168ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DayDashboard_index), @"mvc.1.0.view", @"/Views/DayDashboard/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dee78273a7a22e1cc02b3b3c046ade43a6b168ef", @"/Views/DayDashboard/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4bf2ce06d2348b1b31570fc36637b69493ab809", @"/Views/_ViewImports.cshtml")]
    public class Views_DayDashboard_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MBComputer\Desktop\Capstonetest1\Views\DayDashboard\index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Operation Dashboard</h1>\r\n\r\n<right>\r\n");
            WriteLiteral(@"</right>

<input type=""date"" name=""selDate"" id=""selDate"" value=""2022-03-31"" min=""2022-03-01"" max=""2022-05-01""/>
<button onclick=""myFunction()"">Search</button>

        <!-- Small boxes (Stat box) -->
        <div class=""row"">
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-secondary"">
              <div class=""inner"">
                <h3 id=""DieselVolDaily""></><sup style=""font-size: 20px""></sup></h3>

                <p>Daily Diesel Volume</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
              </div>
");
            WriteLiteral(@"              <div class=""small-box-footer""></div>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-secondary"">
              <div class=""inner"">
                <h3 id=""Gas95VolDaily""></><sup style=""font-size: 20px""></sup></h3>

                <p>Daily Gas95 Volume</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
              </div>
");
            WriteLiteral(@"              <div class=""small-box-footer""></div>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-secondary"">
              <div class=""inner"">
                <h3 id=""DAvgDieselCycle""></><sup style=""font-size: 20px""></sup></h3>

                <p>AVG Diesel Cycle Time</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-clock""></i>
              </div>
");
            WriteLiteral(@"              <div class=""small-box-footer""></div>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-secondary"">
              <div class=""inner"">
                <h3 id=""DAvgGas95Cycle""></><sup style=""font-size: 20px""></sup></h3>

                <p>AVG GAS95 Cycle Time</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-clock""></i>
              </div>
");
            WriteLiteral("              <div class=\"small-box-footer\"></div>\r\n            </div>\r\n          </div>\r\n          <!-- ./col -->\r\n        </div>\r\n\r\n");
            WriteLiteral(@"        <div class=""row"">
        <!-- BAR CHART -->
            <div class=""card card-secondary col-md-6"">
              <div class=""card-header"">
                <h3 class=""card-title"">Average waiting time at each station</h3>

              </div>
              <div class=""card-body"">
                <div class=""chart"">
                  <canvas id=""barChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%; display: block; width: 491px;"" width=""491"" height=""250"" class=""chartjs-render-monitor""></canvas>
                </div>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->

        <!-- BAR CHART 2-->
            <div class=""card card-secondary col-md-6"">
              <div class=""card-header"">
                <h3 class=""card-title"">Number of failed time at each station</h3>

              </div>
              <div class=""card-body"">
                <div class=""chart"">
                  <canvas id=""bar");
            WriteLiteral(@"Chart2"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%; display: block; width: 491px;"" width=""491"" height=""250"" class=""chartjs-render-monitor""></canvas>
                </div>
              </div>
              <!-- /.card-body -->
            </div>
            <!-- /.card -->
            </div>

");
            WriteLiteral(@"
        <div class=""row"">
          <div class=""col-md-6"">
            <!-- small box -->
            <div class=""small-box bg-secondary"">
              <div class=""inner"">
                <h3 id=""Dtruckin""></><sup style=""font-size: 20px""></sup></h3>

                <p>Truck in</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
              </div>
");
            WriteLiteral(@"              <div class=""small-box-footer""></div>
            </div>
          </div>
          <!-- ./col -->
          <div class=""col-md-6"">
            <!-- small box -->
            <div class=""small-box bg-secondary"">
              <div class=""inner"">
                <h3 id=""dtruckout""></><sup style=""font-size: 20px""></sup></h3>

                <p>Truck out</p>
              </div>
              <div class=""icon"">
                <i class=""ion ion-stats-bars""></i>
              </div>
");
            WriteLiteral(@"              <div class=""small-box-footer""></div>
            </div>
          </div>
        </div>


<script type=""text/javascript"">
  var SW = 1.2345;
  var IW = 1.2345;
  var DW = 1.2345;
  var GW = 1.2345;
  var OW = 1.2345;
  let showData = [];

  var failDiesel = 0;
  var failGas95 = 0;
  let showData2 = [];

async function myFunction(){
  var x = document.getElementById(""selDate"").value;
  fetch(`https://localhost:5001/api/pi/getDieselVolDaily/${x}`)
  .then(response => response.json())
  .then(data => {
  document.getElementById(""DieselVolDaily"").innerHTML = data.result[0].values;
  });

  fetch(`https://localhost:5001/api/pi/getGas95lVolDaily/${x}`)
  .then(response => response.json())
  .then(data => {
  document.getElementById(""Gas95VolDaily"").innerHTML = data.result[0].values;
  });

  fetch(`https://localhost:5001/api/pi/dailyDieselAvgCycle/${x}`)
  .then(response => response.json())
  .then(data => {
  document.getElementById(""DAvgDieselCycle"").innerHTML = da");
            WriteLiteral(@"ta.result[0].values;
  });

  fetch(`https://localhost:5001/api/pi/dailyGas95AvgCycle/${x}`)
  .then(response => response.json())
  .then(data => {
  document.getElementById(""DAvgGas95Cycle"").innerHTML = data.result[0].values;
  });

  fetch(`https://localhost:5001/api/pi/noTruckIn/${x}`)
  .then(response => response.json())
  .then(data => {
  document.getElementById(""Dtruckin"").innerHTML = data.result[0].values;
  });

  fetch(`https://localhost:5001/api/pi/noTruckOut/${x}`)
  .then(response => response.json())
  .then(data => {
  document.getElementById(""dtruckout"").innerHTML = data.result[0].values;
  });

  // GRAPH 1

  await fetch(`https://localhost:5001/api/pi/avgSalesWaiting/${x}`)
  .then(response => response.json())
  .then(data => SW = data.result[0].values)
  .then(() => showData = [])
  .then(() => showData.push(SW))
  .then(() => console.log(SW));

  await fetch(`https://localhost:5001/api/pi/avgInwbWaiting/${x}`)
  .then(response => response.json())
  .then(data");
            WriteLiteral(@" => IW = data.result[0].values)
  .then(() => showData.push(IW))
  .then(() => console.log(IW));

  await fetch(`https://localhost:5001/api/pi/avgDieselWaiting/${x}`)
  .then(response => response.json())
  .then(data => DW = data.result[0].values)
  .then(() => showData.push(DW))
  .then(() => console.log(DW));

  await fetch(`https://localhost:5001/api/pi/avgGas95Waiting/${x}`)
  .then(response => response.json())
  .then(data => GW = data.result[0].values)
  .then(() => showData.push(GW))
  .then(() => console.log(GW));

  await fetch(`https://localhost:5001/api/pi/avgOutwbWaiting/${x}`)
  .then(response => response.json())
  .then(data => OW = data.result[0].values)
  .then(() => showData.push(OW))
  .then(() => console.log(OW));

  // GRAPH 2
  await fetch(`https://localhost:5001/api/pi/noFailedDiesel/${x}`)
  .then(response => response.json())
  .then(data => failDiesel = data.result[0].values)
  .then(() => showData2 = [])
  .then(() => showData2.push(failDiesel))
  .then(() ");
            WriteLiteral(@"=> console.log(failDiesel));

  await fetch(`https://localhost:5001/api/pi/noFailedGas95/${x}`)
  .then(response => response.json())
  .then(data => failGas95 = data.result[0].values)
  .then(() => showData2.push(failGas95))
  .then(() => console.log(failGas95));


  console.log(showData);

  var data1 = {
    labels  : ['Sales Office', 'Inbound WB', 'Diesel Bay', 'Gasohol95 Bay', 'Outbound WB'],
    datasets : [
    {
      label               : 'Minutes',
      backgroundColor     : 'rgba(60,141,188,0.9)',
      borderColor         : 'rgba(60,141,188,0.8)',
      pointRadius         : false,
      pointColor          : '#3b8bba',
      pointStrokeColor    : 'rgba(60,141,188,1)',
      pointHighlightFill  : '#fff',
      pointHighlightStroke: 'rgba(60,141,188,1)',
      data :  Object.values(showData)
    }
    ]
  }

  var data2 = {
    labels : ['DIESEL Bay', 'GASOHOL95 Bay'],
    datasets : [
    {
      label               : 'Time',
      backgroundColor     : 'rgba(60,14");
            WriteLiteral(@"1,188,0.9)',
      borderColor         : 'rgba(60,141,188,0.8)',
      pointRadius         : false,
      pointColor          : '#3b8bba',
      pointStrokeColor    : 'rgba(60,141,188,1)',
      pointHighlightFill  : '#fff',
      pointHighlightStroke: 'rgba(60,141,188,1)',
      data :  Object.values(showData2)
    }
    ]
  }
  //-------------
    //- BAR CHART -
    //-------------
");
            WriteLiteral(@"    var barChartCanvas = document.getElementById('barChart').getContext('2d');
    var barChartData = $.extend(true, {}, data1)
    var temp0 = data1.datasets
    barChartData.datasets = temp0

    var barChartOptions = {
      responsive              : true,
      maintainAspectRatio     : false,
      datasetFill             : false
    }

    new Chart(barChartCanvas, {
      type: 'bar',
      data: barChartData,
      options: barChartOptions
    })

  //-------------
    //- BAR CHART 2-
    //-------------
  var barChartCanvas2 = document.getElementById('barChart2').getContext('2d');
    var barChartData2 = $.extend(true, {}, data2)
    var temp1 = data2.datasets
    barChartData2.datasets = temp1

    var barChartOptions2 = {
      responsive              : true,
      maintainAspectRatio     : false,
      datasetFill             : false,
      scales: {
        yAxes: [{
            display: true,
            ticks: {
                min: 0, // minimum value
       ");
            WriteLiteral("         max: 10 // maximum value\r\n            }\r\n        }]\r\n    }\r\n    }\r\n\r\n    new Chart(barChartCanvas2, {\r\n      type: \'bar\',\r\n      data: barChartData2,\r\n      options: barChartOptions2\r\n    })\r\n\r\n}\r\n</script>\r\n");
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