#pragma checksum "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c971c9f87d15de8e1c0f6683dac65a91845fcea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendMessage), @"mvc.1.0.view", @"/Views/Message/SendMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c971c9f87d15de8e1c0f6683dac65a91845fcea", @"/Views/Message/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14edc655b6b69e79e4128d2c23e36dcefe0ae42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"
  
    ViewData["Title"] = "SendMessage";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Yeni Mesaj Oluştur</h3>\r\n");
#nullable restore
#line 8 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"
 using (Html.BeginForm("SendMessage", "Message", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"
Write(Html.Label("Alıcı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"text\" class=\"form-control\" />\r\n");
#nullable restore
#line 15 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"
Write(Html.Label("Konu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"
Write(Html.TextBoxFor(x => x.Subject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"
Write(Html.TextAreaFor(x => x.MessageDetails, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <button class=\"btn btn-success\">Gönder</button>\r\n");
#nullable restore
#line 24 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Message\SendMessage.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591
