#pragma checksum "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6232a213fafa04d2aa49030acdf5dd0d3dc065da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_JustView), @"mvc.1.0.view", @"/Views/Users/JustView.cshtml")]
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
#line 1 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\_ViewImports.cshtml"
using HaftalıkRaporu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\_ViewImports.cshtml"
using HaftalıkRaporu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\_ViewImports.cshtml"
using HaftalıkRaporu.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6232a213fafa04d2aa49030acdf5dd0d3dc065da", @"/Views/Users/JustView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7faed0280878f5ae1af11ccc5b65d2bcb0d775da", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_JustView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Satir>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
  
    ViewData["Title"] = "JustView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
 foreach (var item in Model.Take(1))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Rapor Adı : ");
#nullable restore
#line 13 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
              Write(item.Rapor.RaporTanimi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>Raporlayan Kişi/Kişiler : ");
#nullable restore
#line 14 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                            Write(item.Rapor.RaporlayanKisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>Raporun Düzenlenme Tarihi : ");
#nullable restore
#line 15 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                              Write(item.Rapor.DuzenlenmeTarihi.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"

    if (item.Rapor.Durumu == false)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Rapor Durumu : <b class=\"text-warning\"> Gönderilmedi</b> </p>\r\n");
#nullable restore
#line 22 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
    }
    else
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Rapor Durumu : <b class=\"text-success\">Gönderildi</b>  </p>\r\n");
#nullable restore
#line 28 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
    }


}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card mb-4"">
    <div class=""card-header"">
        <i class=""fas fa-table mr-1""></i>
        Rapornuzun Detayları
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"">
                <tr>
                    <th>   ID  </th>

                    <th>   Önem Dercesi</th>
                    <th>   Başlangış tarihi </th>
                    <th>   Bitiş tarihi </th>
                    <th>   Talep Sahibi </th>
                    <th>   Planlanmış Bitirme Tarihi </th>
                    <th>Yapılan İşler / Aksiyonlar</th>
                    <th>Süre Aşımı/Timeout</th>
                    <th>Haftalık Harcanan Süre (Saat)</th>
                    <th>   Durumu </th>
                    <th>   Yorumlar/Öneriler </th>





                </tr>
");
#nullable restore
#line 59 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                 foreach (var x in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 62 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                        <td>");
#nullable restore
#line 64 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.OnemDerecesi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 65 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.BaslangisTar.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 66 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.BitisTar.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 67 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.TalepSahibi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.BlanlanmisTar.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.YapilanIsler);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 70 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                         if (x.Timeout == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Süre aşımı Yok</td>\r\n");
#nullable restore
#line 73 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Süre aşımı var</td>\r\n");
#nullable restore
#line 77 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td>");
#nullable restore
#line 79 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.HarcananSure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 81 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                         if (@x.Durumu == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td> Tamamlanmadı</td>\r\n");
#nullable restore
#line 84 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                         if (@x.Durumu == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td> Tamamlandı</td>\r\n");
#nullable restore
#line 88 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 89 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                       Write(x.Yorumlar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Abdulrahman Alothman\Desktop\Haftalık Raporu 2\HaftalıkRaporu\HaftalıkRaporu\Views\Users\JustView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<a href=\"/Users/GelenRaporlar\" class=\"btn btn-secondary\">Geri Dön</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Satir>> Html { get; private set; }
    }
}
#pragma warning restore 1591
