#pragma checksum "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64cc122f13118a64599adef0b71a5b9cad50f345"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Projects__Projects), @"mvc.1.0.view", @"/Views/Home/Components/Projects/_Projects.cshtml")]
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
#line 1 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64cc122f13118a64599adef0b71a5b9cad50f345", @"/Views/Home/Components/Projects/_Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520493a69a7d20751d0e9831363d66b394bf2f41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Projects__Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevCard_MVC.Models.Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"featured-section p-3 p-lg-5\">\r\n    <div class=\"container\">\r\n        <h2 class=\"section-title font-weight-bold mb-5\">خاص ترین پروژه ها</h2>\r\n        <div class=\"row\">\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
             foreach (var project in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6 mb-5"">
                    <div class=""card project-card"">
                        <div class=""row no-gutters"">
                            <div class=""col-lg-4 card-img-holder"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 553, "\"", 595, 2);
            WriteAttributeValue("", 559, "assets/images/project/", 559, 22, true);
#nullable restore
#line 15 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
WriteAttributeValue("", 581, project.Image, 581, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\"");
            BeginWriteAttribute("alt", " alt=\"", 613, "\"", 632, 1);
#nullable restore
#line 15 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
WriteAttributeValue("", 619, project.Name, 619, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-lg-8"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">
                                        <a href=""project.html"" class=""theme-link"">
                                            ");
#nullable restore
#line 21 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                       Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </h5>\r\n                                    <p class=\"card-text\">\r\n                                        ");
#nullable restore
#line 25 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                   Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"card-text\"><small class=\"text-muted\">مشتری : ");
#nullable restore
#line 27 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
                                                                                      Write(project.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Projects\_Projects.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevCard_MVC.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
