#pragma checksum "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b388d12ec0ef00a05158d48b1d1b2bc041acf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Meyah.Pages.pagina.Empleados.Pages_pagina_Empleados_Details), @"mvc.1.0.razor-page", @"/Pages/pagina/Empleados/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b388d12ec0ef00a05158d48b1d1b2bc041acf3", @"/Pages/pagina/Empleados/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7843b65d10051fb221273929a8e80ef20baf6afa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_pagina_Empleados_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
  
    Layout = "../Shared/Dise??o_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"hidden\">");
#nullable restore
#line 6 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
              Write(Model.Empleado.empleadoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1 class=\"text-center\">Detalles Empleado</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b388d12ec0ef00a05158d48b1d1b2bc041acf34037", async() => {
                WriteLiteral("\r\n    \r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b388d12ec0ef00a05158d48b1d1b2bc041acf34311", async() => {
                    WriteLiteral("\r\n\r\n\r\n            <div class=\"col-md-5\"></div>\r\n            <a class=\"btn btn-info \"");
                    BeginWriteAttribute("href", " href=\"", 331, "\"", 390, 2);
                    WriteAttributeValue("", 338, "/pagina/Empleados/Edit?id=", 338, 26, true);
#nullable restore
#line 14 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
WriteAttributeValue("", 364, Model.Empleado.empleadoId, 364, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@"> Editar</a> |
            <input class=""btn btn-danger"" type=""button"" data-toggle=""modal"" data-target=""#myModal"" value=""Eliminar"">
            <div class=""col-md-5""></div>
            <br />
            
            <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                            <h4 class=""modal-title"" id=""myModalLabel"">Alerta</h4>
                        </div>
                        <div class=""modal-body"">
                            ??Desea eliminar el producto: """);
#nullable restore
#line 27 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
                                                     Write(Model.Empleado.nombreemp);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
                                                                               Write(Model.Empleado.apellidoem);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"""?
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-info"" data-dismiss=""modal"">Eliminar</button> |
                            <input class=""btn btn-danger"" name=""button"" type=""submit"" value=""Cancelar"" />
                        </div>
                    </div>
                </div>
            </div>
            <br />
   



            <div class=""form-group"">
                <div class=""col-md-6"">
                    <label for=""nombreProducto""><strong>Nombre:</strong></label>
                    <input type=""text"" class=""form-control"" id=""exampleFormControlInput1""");
                    BeginWriteAttribute("value", " value=\"", 1964, "\"", 1997, 1);
#nullable restore
#line 44 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
WriteAttributeValue("", 1972, Model.Empleado.nombreemp, 1972, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"">
                </div>
                

                <div class=""col-md-6"">
                    <label for=""exampleFormControlInput1""><strong>Apellido:</strong></label>
                    <input type=""text"" class=""form-control"" id=""exampleFormControlInput1""");
                    BeginWriteAttribute("value", " value=\"", 2288, "\"", 2322, 1);
#nullable restore
#line 50 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
WriteAttributeValue("", 2296, Model.Empleado.apellidoem, 2296, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"">
                </div>
                <br />
                <br />
                <br />

            </div>
            
            <div class=""form-group"">
                <div class=""col-md-6"">
                    <label><strong>Tel??fono:</strong></label>
                    <input type=""text"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 2678, "\"", 2710, 1);
#nullable restore
#line 61 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
WriteAttributeValue("", 2686, Model.Empleado.telefono, 2686, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"" />
                    <span class=""text-danger""></span>
                </div>
                

                <div class=""col-md-6"">
                    <label><strong>Fecha de Nacimiento:</strong></label>
                    <input type=""text"" class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 3008, "\"", 3067, 1);
#nullable restore
#line 68 "C:\Users\ANGEL\Desktop\MeyahUI\Meyah\Pages\pagina\Empleados\Details.cshtml"
WriteAttributeValue("", 3016, Model.Empleado.fechanacimiento.ToShortDateString(), 3016, 51, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" disabled=""disabled"" />
                    <span class=""text-danger""></span>
                    <br />
                    <br />
                    <br />

                </div>
                
            </div>
            

            <!--
          <div class=""col py-3 px-lg-5 border bg-light""> <button type=""submit"" class=""btn btn-round btn-warning col-lg-3"">Eliminar</button></div>
        <div class=""col py-3 px-lg-5 border bg-light""><button type=""submit"" class=""btn btn-round btn-danger col-lg-3"">Cancelar</button></div>-->

        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meyah.Pages.pagina.Empleados.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Empleados.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Meyah.Pages.pagina.Empleados.DetailsModel>)PageContext?.ViewData;
        public Meyah.Pages.pagina.Empleados.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
