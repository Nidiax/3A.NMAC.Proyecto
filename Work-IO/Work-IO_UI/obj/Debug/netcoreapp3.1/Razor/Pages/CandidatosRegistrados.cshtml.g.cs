#pragma checksum "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a2c2f35ff2572a82a9c8e3bd407b2261f17f9b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Work_IO_UI.Pages.Pages_CandidatosRegistrados), @"mvc.1.0.razor-page", @"/Pages/CandidatosRegistrados.cshtml")]
namespace Work_IO_UI.Pages
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
#line 1 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\_ViewImports.cshtml"
using Work_IO_UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a2c2f35ff2572a82a9c8e3bd407b2261f17f9b7", @"/Pages/CandidatosRegistrados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"491b9dfa16b479aa804522414c01710c9525beb8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CandidatosRegistrados : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
  
    ViewData["Title"] = "CandidatosRegistrados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Candidatos Registrados</h1>\r\n");
#nullable restore
#line 8 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
 if (Model.Candidatos.Any())
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-info table-striped\">\r\n        <!--Head-->\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">");
#nullable restore
#line 14 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 15 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 16 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 17 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().Fecha_Nam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 18 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().Estado_civil));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 20 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 21 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().NSS));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 22 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                           Write(Html.DisplayNameFor(x => x.Candidatos.FirstOrDefault().RFC));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n               \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 28 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
             foreach (var item in Model.Candidatos)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 31 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                               Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 32 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.Fecha_Nam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.Estado_civil));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.Curp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.NSS));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
                   Write(Html.DisplayFor(m => item.RFC));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 47 "C:\git-proyecto\3A.NMAC.Proyecto\Work-IO\Work-IO_UI\Pages\CandidatosRegistrados.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Work_IO_UI.Pages.CandidatosRegistradosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO_UI.Pages.CandidatosRegistradosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO_UI.Pages.CandidatosRegistradosModel>)PageContext?.ViewData;
        public Work_IO_UI.Pages.CandidatosRegistradosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591