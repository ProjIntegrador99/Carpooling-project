#pragma checksum "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "961b022c5b09184e345fb8eb2d945b5a2d54b08a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Profile.cshtml", typeof(AspNetCore.Views_User_Profile))]
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
#line 8 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"961b022c5b09184e345fb8eb2d945b5a2d54b08a", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc258e17165142058097e41256c0acca7422077", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Carpooling.Models.Viaje>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:\'Times New Roman\', Times, serif ;color: white; background-color:crimson; border: crimson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("solicitar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(222, 7, true);
            WriteLiteral(">\r\n\r\n\r\n");
            EndContext();
            BeginContext(229, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042344e64550482780908d4000035234", async() => {
                BeginContext(235, 61, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Perfil</title>\r\n    ");
                EndContext();
                BeginContext(296, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "451f51d1555d4c21999e065f8b4723d4", async() => {
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
                BeginContext(346, 85, true);
                WriteLiteral("\r\n    <style>\r\n        h1 {\r\n            color: #efefef;\r\n        }\r\n    </style>\r\n\r\n");
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
            BeginContext(438, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(440, 9594, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82475b78ac2d4756bedb0845f80c128d", async() => {
                BeginContext(446, 233, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n\r\n        <div class=\"card-profile\">\r\n            <div class=\"card-profile_visual\"></div>\r\n\r\n            <div class=\"card-profile_user-infos\">\r\n               \r\n                <span class=\"infos_name\">");
                EndContext();
                BeginContext(680, 29, false);
#line 34 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                    Write(UserManager.GetUserName(User));

#line default
#line hidden
                EndContext();
                BeginContext(709, 293, true);
                WriteLiteral(@"</span>

                <a href=""#""></a>
            </div>




            <div class=""card-profile_user-stats"">
                <div class=""stats-holder"">
                    <div class=""user-stats"">
                        <strong>Viajes</strong>
                        <span>");
                EndContext();
                BeginContext(1003, 22, false);
#line 46 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                         Write(Model.ToList().Count());

#line default
#line hidden
                EndContext();
                BeginContext(1025, 1122, true);
                WriteLiteral(@"</span>
                    </div>


                    <div class=""avatar"">
                        <img src=""https://www.infobae.com/new-resizer/CBId-A7fnDmhj2kKbIX0eTAVV50=/750x0/filters:quality(100)/s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2016/07/06212701/iron-man-1920-1024x576.jpg"">
                    </div>

                    <div class=""user-stats"">
                        <strong>Puntuación</strong>
                        <span>0</span>
                    </div>

                </div>
            </div>

        </div>

    </div>


    <div class=""cont"">


        <div class=""derecha"">


            <div class=""info-profile2"">
                <h1 align=""Center"" color=""#ffffff"">Informacion de Usuario </h1>
                <br /><br /><br />

                <div class=""info-profile_user-stats"">
                    <div class=""stats-holder"">



                        <td>
                            <div class=""user-stats""");
                WriteLiteral(">\r\n                                <strong>Nombre</strong>\r\n                                <span>");
                EndContext();
                BeginContext(2148, 86, false);
#line 85 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(2234, 234, true);
                WriteLiteral("</span>\r\n                            </div>\r\n                            <br />\r\n\r\n                            <div class=\"user-stats\">\r\n                                <strong>Apellido</strong>\r\n                                <span>");
                EndContext();
                BeginContext(2469, 88, false);
#line 91 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Apellido);

#line default
#line hidden
                EndContext();
                BeginContext(2557, 246, true);
                WriteLiteral("</span>\r\n                            </div>\r\n                            <br />\r\n\r\n\r\n                            <div class=\"user-stats\">\r\n                                <strong>Correo electrónico</strong>\r\n                                <span>");
                EndContext();
                BeginContext(2804, 85, false);
#line 98 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Email);

#line default
#line hidden
                EndContext();
                BeginContext(2889, 234, true);
                WriteLiteral("</span>\r\n                            </div>\r\n                            <br />\r\n\r\n                            <div class=\"user-stats\">\r\n                                <strong>Teléfono</strong>\r\n                                <span>");
                EndContext();
                BeginContext(3124, 91, false);
#line 104 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).PhoneNumber);

#line default
#line hidden
                EndContext();
                BeginContext(3215, 241, true);
                WriteLiteral("</span>\r\n                            </div>\r\n                            <br />\r\n\r\n                            <div class=\"user-stats\">\r\n                                <strong>Área de trabajo</strong>\r\n                                <span>");
                EndContext();
                BeginContext(3457, 84, false);
#line 110 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Area);

#line default
#line hidden
                EndContext();
                BeginContext(3541, 984, true);
                WriteLiteral(@"</span>
                            </div>


                            <br />
                            <div class=""user-stats"">
                                <strong>Calificación pasajero</strong>
                                <span>4.5</span>
                            </div>
                            <br />
                        </td>

                        <td>

                            <br />
                            <br />
                            <div class=""user-stats"">
                                <strong>Calificación conductor</strong>
                                <span>4.5</span>
                            </div>
                            <br />

                           


                            <br />



                            <br />
                            <br />

                        </td>


                        <div class=""text-left"">

                            ");
                EndContext();
                BeginContext(4525, 275, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0aea0377d74496c85416d3094bb7d49", async() => {
                    BeginContext(4726, 70, true);
                    WriteLiteral("\r\n                                Editar\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4800, 714, true);
                WriteLiteral(@"

                        </div>



                    </div>
                </div>

            </div>

        </div>



    </div>


    <div class=""cont1"">


        <div class=""derecha"">


            <div class=""info-profile3"">
                <h1 align=""Center"" color=""#ffffff"">Publicaciones </h1>
                <br /><br /><br />

                <div class=""info-profile_user-stats"">
                    <div class=""stats-holder"">


                        <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>
                                                ");
                EndContext();
                BeginContext(5515, 47, false);
#line 185 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(5562, 151, true);
                WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
                EndContext();
                BeginContext(5714, 40, false);
#line 188 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Hora));

#line default
#line hidden
                EndContext();
                BeginContext(5754, 151, true);
                WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
                EndContext();
                BeginContext(5906, 45, false);
#line 191 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.TipoViaje));

#line default
#line hidden
                EndContext();
                BeginContext(5951, 151, true);
                WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
                EndContext();
                BeginContext(6103, 42, false);
#line 194 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(6145, 151, true);
                WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
                EndContext();
                BeginContext(6297, 41, false);
#line 197 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Cupos));

#line default
#line hidden
                EndContext();
                BeginContext(6338, 151, true);
                WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
                EndContext();
                BeginContext(6490, 51, false);
#line 200 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.NombreConductor));

#line default
#line hidden
                EndContext();
                BeginContext(6541, 248, true);
                WriteLiteral("\r\n                                            </th>\r\n                                            <th></th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n\r\n");
                EndContext();
#line 207 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                         foreach (var item in Model)
                                        {
                                            if (item.NombreConductor.Equals(@UserManager.GetUserName(User)))
                                            {

#line default
#line hidden
                BeginContext(7059, 156, true);
                WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(7216, 46, false);
#line 213 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(7262, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(7426, 39, false);
#line 216 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Hora));

#line default
#line hidden
                EndContext();
                BeginContext(7465, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(7629, 44, false);
#line 219 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.TipoViaje));

#line default
#line hidden
                EndContext();
                BeginContext(7673, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(7837, 41, false);
#line 222 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(7878, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(8042, 40, false);
#line 225 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Cupos));

#line default
#line hidden
                EndContext();
                BeginContext(8082, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(8246, 50, false);
#line 228 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.NombreConductor));

#line default
#line hidden
                EndContext();
                BeginContext(8296, 171, true);
                WriteLiteral("\r\n                                                </td>\r\n\r\n\r\n\r\n\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(8467, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ae887d046d4758851ede0a2ef8c86a", async() => {
                    BeginContext(8531, 9, true);
                    WriteLiteral("Solicitar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 235 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
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
                BeginContext(8544, 61, true);
                WriteLiteral("\r\n                                                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8605, "\"", 8676, 2);
                WriteAttributeValue("", 8615, "location.href=\'https://localhost:44396/Viajes/Edit/\'+", 8615, 53, true);
#line 236 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
WriteAttributeValue("", 8668, item.Id, 8668, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8677, 96, true);
                WriteLiteral(" class=\"btn btn-info\">Edit</button>\r\n                                                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8773, "\"", 8847, 2);
                WriteAttributeValue("", 8783, "location.href=\'https://localhost:44396/Viajes/Details/\'+", 8783, 56, true);
#line 237 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
WriteAttributeValue("", 8839, item.Id, 8839, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8848, 99, true);
                WriteLiteral(" class=\"btn btn-info\">Details</button>\r\n                                                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8947, "\"", 9020, 2);
                WriteAttributeValue("", 8957, "location.href=\'https://localhost:44396/Viajes/Delete/\'+", 8957, 55, true);
#line 238 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
WriteAttributeValue("", 9012, item.Id, 9012, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9021, 39, true);
                WriteLiteral(" class=\"btn btn-info\">Delete</button>\r\n");
                EndContext();
                BeginContext(9549, 106, true);
                WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
                EndContext();
#line 244 "C:\Users\User\Source\Repos\ProjIntegrador99\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                            }
                                        }

#line default
#line hidden
                BeginContext(9745, 282, true);
                WriteLiteral(@"                                    </tbody>
                                </table>
















                    </div>
                </div>

            </div>

        </div>














    </div>















");
                EndContext();
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
            EndContext();
            BeginContext(10034, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<Usuario> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<Usuario> SignInManager { get; private set; }
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
