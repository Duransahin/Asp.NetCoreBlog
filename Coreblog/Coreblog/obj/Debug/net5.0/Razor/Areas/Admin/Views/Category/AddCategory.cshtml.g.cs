#pragma checksum "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef6f19df36e949d7c17396f625de7cc259a1973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_AddCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef6f19df36e949d7c17396f625de7cc259a1973", @"/Areas/Admin/Views/Category/AddCategory.cshtml")]
    public class Areas_Admin_Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Yeni Kategory Girişi</h3>\r\n");
#nullable restore
#line 8 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm("AddCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 style=\"color:red\"> ");
#nullable restore
#line 12 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
                      Write(Html.ValidationMessageFor(x => x.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 15 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
Write(Html.TextAreaFor(x => x.CategoryDescription, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 style=\"color:red\"> ");
#nullable restore
#line 17 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"
                      Write(Html.ValidationMessageFor(x => x.CategoryDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <br />\r\n    <br />\r\n    <button class=\"btn btn-success\">Kaydet</button>\r\n");
#nullable restore
#line 21 "C:\Users\duran\Desktop\Projeler\Coreblog\Coreblog\Areas\Admin\Views\Category\AddCategory.cshtml"



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
