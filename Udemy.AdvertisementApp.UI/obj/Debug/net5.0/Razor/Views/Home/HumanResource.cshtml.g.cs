#pragma checksum "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68ea5bcfb4ad1daca8b1bb4890374f8ce42736e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HumanResource), @"mvc.1.0.view", @"/Views/Home/HumanResource.cshtml")]
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
#line 2 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Udemy.AdvertisementApp.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\_ViewImports.cshtml"
using Udemy.AdvertisementApp.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ea5bcfb4ad1daca8b1bb4890374f8ce42736e7", @"/Views/Home/HumanResource.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e97ccb424cd00fca532e9277ba5cc0eaa21a30b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_HumanResource : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvertisementListDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container my-3\" style=\"margin-top:100px!important;\">\r\n\r\n    <div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 11 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
          
            bool firstRow = true;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 387, "\"", 408, 2);
            WriteAttributeValue("", 392, "heading-", 392, 8, true);
#nullable restore
#line 18 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 400, item.Id, 400, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapse-");
#nullable restore
#line 19 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                                                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-expanded", " aria-expanded=\"", 540, "\"", 567, 3);
            WriteAttributeValue("", 556, "(", 556, 1, true);
#nullable restore
#line 19 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 557, firstRow, 557, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 566, ")", 566, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 568, "\"", 601, 2);
            WriteAttributeValue("", 584, "collapse-", 584, 9, true);
#nullable restore
#line 19 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 593, item.Id, 593, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 20 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </h2>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 716, "\"", 738, 2);
            WriteAttributeValue("", 721, "collapse-", 721, 9, true);
#nullable restore
#line 23 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 730, item.Id, 730, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 739, "\"", 796, 3);
            WriteAttributeValue("", 747, "accordion-collapse", 747, 18, true);
            WriteAttributeValue(" ", 765, "collapse", 766, 9, true);
#nullable restore
#line 23 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue(" ", 774, firstRow?"show":"", 775, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 797, "\"", 831, 2);
            WriteAttributeValue("", 815, "heading-", 815, 8, true);
#nullable restore
#line 23 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 823, item.Id, 823, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-parent=\"#accordionExample\">\r\n                    <div class=\"accordion-body\">\r\n                        <strong class=\"float-xl-end\">");
#nullable restore
#line 25 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                                                Write(item.CreatedDate.ToString("dd-MM-yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br /><hr>\r\n                        ");
#nullable restore
#line 26 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <a href=\"#\">Başvur</a>\r\n                            </div>\r\n");
#nullable restore
#line 32 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-light text-center\">\r\n                                Başvuru için kayıt olmanız gerekmektedir.\r\n                                <a href=\"#\">Kayıt Ol</a>\r\n                            </div>\r\n");
#nullable restore
#line 39 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 44 "D:\NEA\D248.Udemy.AdvertisementApp\Udemy.AdvertisementApp\Udemy.AdvertisementApp.UI\Views\Home\HumanResource.cshtml"
            if (firstRow)
            {
                firstRow = false;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvertisementListDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
