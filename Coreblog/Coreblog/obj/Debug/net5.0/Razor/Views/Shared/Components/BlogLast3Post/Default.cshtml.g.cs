#pragma checksum "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1353fb692c8422f1ae33223c0508c7239e1c5426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1353fb692c8422f1ae33223c0508c7239e1c5426", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14edc655b6b69e79e4128d2c23e36dcefe0ae42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h3>Son Postlar</h3>\r\n\r\n\r\n\r\n    <div class=\"blog-grids row mb-3\">\r\n        <div class=\"col-md-5 blog-grid-left\">\r\n            <a href=\"single.html\">\r\n                <img src=\"/web/images/4.jpg\" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 301, "\"", 307, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
         foreach (var item in Model)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-7 blog-grid-right"">

                <h5>
                    <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                </h5>
                <div class=""sub-meta"">
                    <span>
                        <i class=""far fa-clock""></i> 20 Jan, 2018
                    </span>
                </div>
            </div>
");
#nullable restore
#line 29 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Views\Shared\Components\BlogLast3Post\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
