#pragma checksum "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\Home\MenuAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cd92afc2ce9549a97b07e3bc130439aa77cec21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MenuAdmin), @"mvc.1.0.view", @"/Views/Home/MenuAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MenuAdmin.cshtml", typeof(AspNetCore.Views_Home_MenuAdmin))]
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
#line 1 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\_ViewImports.cshtml"
using SistemaVotacionAutomatizada;

#line default
#line hidden
#line 2 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\_ViewImports.cshtml"
using SistemaVotacionAutomatizada.Models;

#line default
#line hidden
#line 3 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd92afc2ce9549a97b07e3bc130439aa77cec21", @"/Views/Home/MenuAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"439ddd1d1e3d9184a92c3aa1f620fcd6d9a8c4eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MenuAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<h1>Menú Administrador</h1>\r\n\r\n");
            EndContext();
            BeginContext(31, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cd92afc2ce9549a97b07e3bc130439aa77cec214488", async() => {
                BeginContext(37, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(43, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9cd92afc2ce9549a97b07e3bc130439aa77cec214871", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(96, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(105, 542, true);
            WriteLiteral(@"

<div class=""card-deck"">
    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRj7c05VnN6Jhy4ftISKsql3RUJWVCDtyRBtPZ9URk3u5z8QSJ0""
                 class=""card-img-top"" alt=""Ciudadanos Image"">
            <div class=""card-body"">
                <h5 class=""card-title"">Ciudadanos</h5>
                <p class=""card-text"">Crear y editar ciudadanos del padrón electoral</p>
            </div>
            <div class=""card-body"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 647, "\"", 687, 1);
#line 17 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\Home\MenuAdmin.cshtml"
WriteAttributeValue("", 654, Url.Action("Index","Ciudadanos"), 654, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(688, 613, true);
            WriteLiteral(@" class=""btn btn-primary"">Acceder</a>
            </div>
        </div>
    </div>

    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR7b0XTsjRYCIzYSSQCaC9RmZWv-QMM5AcTqkayALwWc7GcRqze""
                 class=""card-img-top"" alt=""Candidatos Image"">
            <div class=""card-body"">
                <h5 class=""card-title"">Candidatos</h5>
                <p class=""card-text"">Seleccionar los ciudadanos que optan por puestos políticos</p>
            </div>
            <div class=""card-body"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1301, "\"", 1341, 1);
#line 31 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\Home\MenuAdmin.cshtml"
WriteAttributeValue("", 1308, Url.Action("Index","Candidatos"), 1308, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1342, 586, true);
            WriteLiteral(@" class=""btn btn-primary"">Acceder</a>
            </div>
        </div>
    </div>

    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""https://www.netclipart.com/pp/m/17-179524_political-clipart-voting-ballot-elections-icon.png""
                 class=""card-img-top"" alt=""Elecciones Image"">
            <div class=""card-body"">
                <h5 class=""card-title"">Elecciones</h5>
                <p class=""card-text"">Administrar los procesos electorales del país</p>
            </div>
            <div class=""card-body"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1928, "\"", 1968, 1);
#line 45 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\Home\MenuAdmin.cshtml"
WriteAttributeValue("", 1935, Url.Action("Index","Elecciones"), 1935, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1969, 659, true);
            WriteLiteral(@" class=""btn btn-primary"">Acceder</a>
            </div>
        </div>
    </div>
</div>

<div class=""card-deck"">
    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""https://cdn4.iconfinder.com/data/icons/election-world-flat/64/senate-congress-government-senator-political-512.png""
                 class=""card-img-top"" alt=""Puestos Image"">
            <div class=""card-body"">
                <h5 class=""card-title"">Puestos Electivos</h5>
                <p class=""card-text"">Crear y editar los puestos electivos disponibles del estado</p>
            </div>
            <div class=""card-body"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2628, "\"", 2673, 1);
#line 61 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\Home\MenuAdmin.cshtml"
WriteAttributeValue("", 2635, Url.Action("Index","PuestoElectivos"), 2635, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2674, 641, true);
            WriteLiteral(@" class=""btn btn-primary"">Acceder</a>
            </div>
        </div>
    </div>

    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""https://cdn4.iconfinder.com/data/icons/baseball-18/64/29_versus_team_emblem_baseball_player_match_sport-512.png""
                 class=""card-img-top"" alt=""Partidos Image"">
            <div class=""card-body"">
                <h5 class=""card-title"">Partidos Políticos</h5>
                <p class=""card-text"">Administrar los partidos políticos aprobados por la Junta Central Electoral</p>
            </div>
            <div class=""card-body"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3315, "\"", 3353, 1);
#line 75 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\Home\MenuAdmin.cshtml"
WriteAttributeValue("", 3322, Url.Action("Index","Partidos"), 3322, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3354, 674, true);
            WriteLiteral(@" class=""btn btn-primary"">Acceder</a>
            </div>
        </div>
    </div>

    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""https://cdn4.iconfinder.com/data/icons/united-states-presidential-election/97/usa-us-united-states-america-american-election-politics-elections_51-512.png""
                 class=""card-img-top"" alt=""Resultados Image"">
            <div class=""card-body"">
                <h5 class=""card-title"">Resultados Elecciones</h5>
                <p class=""card-text"">Visualización de los resultados de las elecciones ejecutadas</p>
            </div>
            <div class=""card-body"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4028, "\"", 4073, 1);
#line 89 "C:\Users\blask\source\repos\ITLA\C#Intermedio\Votacion_Automatizada-master\SistemaVotacionAutomatizada\Views\Home\MenuAdmin.cshtml"
WriteAttributeValue("", 4035, Url.Action("Index","VotosElecciones"), 4035, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4074, 94, true);
            WriteLiteral(" class=\"btn btn-primary\">Acceder</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
