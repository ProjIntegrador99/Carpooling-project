#pragma checksum "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f04a178eb07fcbea149088202211f341987e13"
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
#line 1 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\_ViewImports.cshtml"
using Carpooling;

#line default
#line hidden
#line 2 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\_ViewImports.cshtml"
using Carpooling.Models;

#line default
#line hidden
#line 8 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f04a178eb07fcbea149088202211f341987e13", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdcc3f673c69201db89d12be5bc308777df7d56b", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(86, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(124, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(211, 4, true);
            WriteLiteral(">\n\n\n");
            EndContext();
            BeginContext(215, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ee0c3b00a1d472e9f2ab3540e2a7787", async() => {
                BeginContext(221, 58, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <title>Perfil</title>\n    ");
                EndContext();
                BeginContext(279, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "098273eded1e4940a3ae6b06bfce3895", async() => {
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
                BeginContext(329, 78, true);
                WriteLiteral("\n    <style>\n        h1 {\n            color: #efefef;\n        }\n    </style>\n\n");
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
            BeginContext(414, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(415, 9320, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391df47d080c43c5bf3a303b92a39364", async() => {
                BeginContext(421, 225, true);
                WriteLiteral("\n    <div class=\"container\">\n\n        <div class=\"card-profile\">\n            <div class=\"card-profile_visual\"></div>\n\n            <div class=\"card-profile_user-infos\">\n               \n                <span class=\"infos_name\">");
                EndContext();
                BeginContext(647, 29, false);
#line 34 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                    Write(UserManager.GetUserName(User));

#line default
#line hidden
                EndContext();
                BeginContext(676, 281, true);
                WriteLiteral(@"</span>

                <a href=""#""></a>
            </div>




            <div class=""card-profile_user-stats"">
                <div class=""stats-holder"">
                    <div class=""user-stats"">
                        <strong>Viajes</strong>
                        <span>");
                EndContext();
                BeginContext(958, 22, false);
#line 46 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                         Write(Model.ToList().Count());

#line default
#line hidden
                EndContext();
                BeginContext(980, 1083, true);
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
                            <div class=""user-stats"">
                                <st");
                WriteLiteral("rong>Nombre</strong>\n                                <span>");
                EndContext();
                BeginContext(2064, 86, false);
#line 85 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(2150, 228, true);
                WriteLiteral("</span>\n                            </div>\n                            <br />\n\n                            <div class=\"user-stats\">\n                                <strong>Apellido</strong>\n                                <span>");
                EndContext();
                BeginContext(2379, 88, false);
#line 91 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Apellido);

#line default
#line hidden
                EndContext();
                BeginContext(2467, 239, true);
                WriteLiteral("</span>\n                            </div>\n                            <br />\n\n\n                            <div class=\"user-stats\">\n                                <strong>Correo electrónico</strong>\n                                <span>");
                EndContext();
                BeginContext(2707, 85, false);
#line 98 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Email);

#line default
#line hidden
                EndContext();
                BeginContext(2792, 228, true);
                WriteLiteral("</span>\n                            </div>\n                            <br />\n\n                            <div class=\"user-stats\">\n                                <strong>Teléfono</strong>\n                                <span>");
                EndContext();
                BeginContext(3021, 91, false);
#line 104 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).PhoneNumber);

#line default
#line hidden
                EndContext();
                BeginContext(3112, 235, true);
                WriteLiteral("</span>\n                            </div>\n                            <br />\n\n                            <div class=\"user-stats\">\n                                <strong>Área de trabajo</strong>\n                                <span>");
                EndContext();
                BeginContext(3348, 84, false);
#line 110 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                 Write(UserManager.Users.First(j => j.UserName.Equals(@UserManager.GetUserName(User))).Area);

#line default
#line hidden
                EndContext();
                BeginContext(3432, 947, true);
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
                BeginContext(4379, 273, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e2c6a0bea584a1d9eaa72d521d237ea", async() => {
                    BeginContext(4580, 68, true);
                    WriteLiteral("\n                                Editar\n                            ");
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
                BeginContext(4652, 678, true);
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
                BeginContext(5331, 47, false);
#line 185 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(5378, 148, true);
                WriteLiteral("\n                                            </th>\n                                            <th>\n                                                ");
                EndContext();
                BeginContext(5527, 40, false);
#line 188 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Hora));

#line default
#line hidden
                EndContext();
                BeginContext(5567, 148, true);
                WriteLiteral("\n                                            </th>\n                                            <th>\n                                                ");
                EndContext();
                BeginContext(5716, 45, false);
#line 191 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.TipoViaje));

#line default
#line hidden
                EndContext();
                BeginContext(5761, 148, true);
                WriteLiteral("\n                                            </th>\n                                            <th>\n                                                ");
                EndContext();
                BeginContext(5910, 42, false);
#line 194 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(5952, 148, true);
                WriteLiteral("\n                                            </th>\n                                            <th>\n                                                ");
                EndContext();
                BeginContext(6101, 41, false);
#line 197 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.Cupos));

#line default
#line hidden
                EndContext();
                BeginContext(6142, 148, true);
                WriteLiteral("\n                                            </th>\n                                            <th>\n                                                ");
                EndContext();
                BeginContext(6291, 51, false);
#line 200 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                           Write(Html.DisplayNameFor(model => model.NombreConductor));

#line default
#line hidden
                EndContext();
                BeginContext(6342, 241, true);
                WriteLiteral("\n                                            </th>\n                                            <th></th>\n                                        </tr>\n                                    </thead>\n                                    <tbody>\n\n");
                EndContext();
#line 207 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                         foreach (var item in Model)
                                        {
                                            if (item.NombreConductor.Equals(@UserManager.GetUserName(User)))
                                            {

#line default
#line hidden
                BeginContext(6849, 154, true);
                WriteLiteral("                                            <tr>\n                                                <td>\n                                                    ");
                EndContext();
                BeginContext(7004, 46, false);
#line 213 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
                EndContext();
                BeginContext(7050, 160, true);
                WriteLiteral("\n                                                </td>\n                                                <td>\n                                                    ");
                EndContext();
                BeginContext(7211, 39, false);
#line 216 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Hora));

#line default
#line hidden
                EndContext();
                BeginContext(7250, 160, true);
                WriteLiteral("\n                                                </td>\n                                                <td>\n                                                    ");
                EndContext();
                BeginContext(7411, 44, false);
#line 219 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.TipoViaje));

#line default
#line hidden
                EndContext();
                BeginContext(7455, 160, true);
                WriteLiteral("\n                                                </td>\n                                                <td>\n                                                    ");
                EndContext();
                BeginContext(7616, 41, false);
#line 222 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(7657, 160, true);
                WriteLiteral("\n                                                </td>\n                                                <td>\n                                                    ");
                EndContext();
                BeginContext(7818, 40, false);
#line 225 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Cupos));

#line default
#line hidden
                EndContext();
                BeginContext(7858, 160, true);
                WriteLiteral("\n                                                </td>\n                                                <td>\n                                                    ");
                EndContext();
                BeginContext(8019, 50, false);
#line 228 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.NombreConductor));

#line default
#line hidden
                EndContext();
                BeginContext(8069, 164, true);
                WriteLiteral("\n                                                </td>\n\n\n\n\n                                                <td>\n                                                    ");
                EndContext();
                BeginContext(8233, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "484ecaf5d2844ccfbfbfa2370ca6521f", async() => {
                    BeginContext(8297, 9, true);
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
#line 235 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
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
                BeginContext(8310, 60, true);
                WriteLiteral("\n                                                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8370, "\"", 8441, 2);
                WriteAttributeValue("", 8380, "location.href=\'https://localhost:44396/Viajes/Edit/\'+", 8380, 53, true);
#line 236 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
WriteAttributeValue("", 8433, item.Id, 8433, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8442, 95, true);
                WriteLiteral(" class=\"btn btn-info\">Edit</button>\n                                                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8537, "\"", 8611, 2);
                WriteAttributeValue("", 8547, "location.href=\'https://localhost:44396/Viajes/Details/\'+", 8547, 56, true);
#line 237 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
WriteAttributeValue("", 8603, item.Id, 8603, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8612, 98, true);
                WriteLiteral(" class=\"btn btn-info\">Details</button>\n                                                    <button");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8710, "\"", 8783, 2);
                WriteAttributeValue("", 8720, "location.href=\'https://localhost:44396/Viajes/Delete/\'+", 8720, 55, true);
#line 238 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
WriteAttributeValue("", 8775, item.Id, 8775, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8784, 38, true);
                WriteLiteral(" class=\"btn btn-info\">Delete</button>\n");
                EndContext();
                BeginContext(9308, 104, true);
                WriteLiteral("                                                </td>\n                                            </tr>\n");
                EndContext();
#line 244 "C:\Users\Alejandro Narvaez\Source\Repos\Carpooling-project\Carpooling\Views\User\Profile.cshtml"
                                            }
                                        }

#line default
#line hidden
                BeginContext(9500, 228, true);
                WriteLiteral("                                    </tbody>\n                                </table>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                    </div>\n                </div>\n\n            </div>\n\n        </div>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n    </div>\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
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
            BeginContext(9735, 6, true);
            WriteLiteral("\n\n\n\n\n\n");
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
