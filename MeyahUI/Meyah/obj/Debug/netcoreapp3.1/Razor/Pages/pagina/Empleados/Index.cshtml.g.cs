#pragma checksum "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e6fe51f57a76ced81f6a6f31f742bfb6f09813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Meyah.Pages.pagina.Empleados.Pages_pagina_Empleados_Index), @"mvc.1.0.razor-page", @"/Pages/pagina/Empleados/Index.cshtml")]
namespace Meyah.Pages.pagina.Empleados
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
#line 1 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\_ViewImports.cshtml"
using Meyah;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e6fe51f57a76ced81f6a6f31f742bfb6f09813", @"/Pages/pagina/Empleados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7843b65d10051fb221273929a8e80ef20baf6afa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_pagina_Empleados_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml"
  
    Layout = "../Shared/Diseño_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Empleados</h1>
<table class=""table table-bordered table-striped table-condensed"">
    <thead>
        <tr>
            <th><strong>Id</strong></th>
            <th><strong>Nombre</strong></th>
            <th><strong>Apellido</strong></th>      
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml"
         foreach (var item in Model.EmpleadoList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml"
           Write(item.empleadoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml"
           Write(item.nombreemp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml"
           Write(item.apellidoem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td class=\" centered\" WIDTH=\"150\"> <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 731, "\"", 783, 2);
            WriteAttributeValue("", 738, "/pagina/Empleados/Details?id=", 738, 29, true);
#nullable restore
#line 24 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml"
WriteAttributeValue("", 767, item.empleadoId, 767, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>Detalles</strong></a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Index.cshtml"
        }        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meyah.Pages.pagina.Empleados.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Empleados.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Empleados.IndexModel>)PageContext?.ViewData;
        public Meyah.Pages.pagina.Empleados.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
