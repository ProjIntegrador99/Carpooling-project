#pragma checksum "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11407c66b32395cafe1a5fd81316457f0f0372cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Viajes_Index), @"mvc.1.0.view", @"/Views/Viajes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Viajes/Index.cshtml", typeof(AspNetCore.Views_Viajes_Index))]
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
#line 1 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\_ViewImports.cshtml"
using Carpooling;

#line default
#line hidden
#line 2 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\_ViewImports.cshtml"
using Carpooling.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11407c66b32395cafe1a5fd81316457f0f0372cd", @"/Views/Viajes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc258e17165142058097e41256c0acca7422077", @"/Views/_ViewImports.cshtml")]
    public class Views_Viajes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Carpooling.Models.Viaje>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 45, true);
            WriteLiteral("\r\n<h2>Muro de publicaciones</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(180, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88de7f46d4714014aa2c290738b707eb", async() => {
                BeginContext(203, 16, true);
                WriteLiteral("Publica tu cupo!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 144, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" style=\"width: 100%; text-align:center;\">\r\n    <thead>\r\n        <tr>\r\n            <th colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(368, 47, false);
#line 17 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(415, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(483, 40, false);
#line 20 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hora));

#line default
#line hidden
            EndContext();
            BeginContext(523, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(591, 45, false);
#line 23 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoViaje));

#line default
#line hidden
            EndContext();
            BeginContext(636, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(704, 42, false);
#line 26 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(746, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(814, 41, false);
#line 29 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cupos));

#line default
#line hidden
            EndContext();
            BeginContext(855, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(923, 51, false);
#line 32 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreConductor));

#line default
#line hidden
            EndContext();
            BeginContext(974, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1092, 60, true);
            WriteLiteral("        <tr>\r\n            <td colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(1153, 46, false);
#line 41 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 67, true);
            WriteLiteral("\r\n            </td>\r\n            <td colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(1267, 39, false);
#line 44 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hora));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 67, true);
            WriteLiteral("\r\n            </td>\r\n            <td colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(1374, 44, false);
#line 47 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoViaje));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 67, true);
            WriteLiteral("\r\n            </td>\r\n            <td colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(1486, 41, false);
#line 50 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 67, true);
            WriteLiteral("\r\n            </td>\r\n            <td colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(1595, 40, false);
#line 53 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cupos));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 67, true);
            WriteLiteral("\r\n            </td>\r\n            <td colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(1703, 50, false);
#line 56 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreConductor));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 67, true);
            WriteLiteral("\r\n            </td>\r\n            <td colspan=\"2\">\r\n                ");
            EndContext();
            BeginContext(1820, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a27f499f5912428cac42cd4ec78373e5", async() => {
                BeginContext(1865, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1873, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1893, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3b53ea4ea7a42aaa9708b1032b4d248", async() => {
                BeginContext(1941, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1952, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1972, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f55246c07e244199622de3ebed2bde3", async() => {
                BeginContext(2019, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2029, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\Viajes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2068, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Carpooling.Models.Viaje>> Html { get; private set; }
    }
}
#pragma warning restore 1591
