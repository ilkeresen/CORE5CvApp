#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\ServiceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b82929402765effa281a8109105b43d1d4910d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\_ViewImports.cshtml"
using Core5BlogApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\_ViewImports.cshtml"
using Core5BlogApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\ServiceList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b82929402765effa281a8109105b43d1d4910d4", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6aacfefcee79e604603c6f5a9c8f1b20d25e936", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n    <div class=\"container\">\r\n\r\n        <div class=\"section-title\">\r\n            <h2>Hizmetlerim</h2>\r\n            <p>HİZMETLERİM</p>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\ServiceList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch mt-4\">\r\n                    <div class=\"icon-box\">\r\n                        <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 464, "\"", 489, 1);
#nullable restore
#line 19 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\ServiceList\Default.cshtml"
WriteAttributeValue("", 472, item.ServiceIcon, 472, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 533, "\"", 540, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\ServiceList\Default.cshtml"
                                  Write(item.ServiceHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                        <p>\r\n                            ");
#nullable restore
#line 22 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\ServiceList\Default.cshtml"
                       Write(item.ServiceContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\ServiceList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
