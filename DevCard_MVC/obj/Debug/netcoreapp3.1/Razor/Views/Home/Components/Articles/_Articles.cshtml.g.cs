#pragma checksum "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Articles\_Articles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab274dc2fd8358734bab99cb00dada0edf0c6597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Articles__Articles), @"mvc.1.0.view", @"/Views/Home/Components/Articles/_Articles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab274dc2fd8358734bab99cb00dada0edf0c6597", @"/Views/Home/Components/Articles/_Articles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520493a69a7d20751d0e9831363d66b394bf2f41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Articles__Articles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevCard_MVC.Models.Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"latest-blog-section p-3 p-lg-5\">\n    <div class=\"container\">\n        <h2 class=\"section-title font-weight-bold mb-5\">آخرین مقالات</h2>\n        <div class=\"row\">\n");
#nullable restore
#line 6 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Articles\_Articles.cshtml"
            foreach (var article in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 mb-5\">\n                <div class=\"card blog-post-card\">\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 417, "\"", 456, 2);
            WriteAttributeValue("", 423, "assets/images/blog/", 423, 19, true);
#nullable restore
#line 10 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Articles\_Articles.cshtml"
WriteAttributeValue("", 442, article.Image, 442, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 457, "\"", 477, 1);
#nullable restore
#line 10 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Articles\_Articles.cshtml"
WriteAttributeValue("", 463, article.Title, 463, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">\n                            <a class=\"theme-link\" href=\"blog-post.html\">\n                                ");
#nullable restore
#line 14 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Articles\_Articles.cshtml"
                           Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </a>\n                        </h5>\n                        <p class=\"card-text\">\n                           ");
#nullable restore
#line 18 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Articles\_Articles.cshtml"
                      Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                        <p class=\"mb-0\"><a class=\"more-link\" href=\"blog-post.html\">ادامه مطلب</a></p>\n                    </div>\n                </div>\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\Shaghayegh\source\repos\DeletedFolder\DevCard\DevCard_MVC\Views\Home\Components\Articles\_Articles.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevCard_MVC.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
