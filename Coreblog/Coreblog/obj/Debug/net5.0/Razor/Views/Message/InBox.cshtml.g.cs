#pragma checksum "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a3fb0bf56ffe20e0eeffc909e4fa0f6039e2abb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#line 1 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\_ViewImports.cshtml"
using Coreblog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\_ViewImports.cshtml"
using Coreblog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a3fb0bf56ffe20e0eeffc909e4fa0f6039e2abb", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14edc655b6b69e79e4128d2c23e36dcefe0ae42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Kutusu</h1>\r\n\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Gönderen</th>\r\n        <th>Tarih</th>\r\n        <th>Mesajı Aç </th>\r\n\r\n\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
           Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
           Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
            Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 640, "\"", 686, 2);
            WriteAttributeValue("", 647, "/Message/MessageDetails/", 647, 24, true);
#nullable restore
#line 28 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
WriteAttributeValue("", 671, item.MessageID, 671, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Mesajı Aç</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\InBox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Message/SendMessage/\" class=\"btn btn-primary\" style=\"margin-top:10px\">Yeni Mesaj Oluştur</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591