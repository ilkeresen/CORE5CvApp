#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\HomeList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9275b8f3143c837c8093666f3860fb6a23941223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomeList/Default.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\HomeList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9275b8f3143c837c8093666f3860fb6a23941223", @"/Views/Shared/Components/HomeList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6aacfefcee79e604603c6f5a9c8f1b20d25e936", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Home>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 6 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\HomeList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1><a href=\"/ShowCase/ShowCase/Index/\">");
#nullable restore
#line 8 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\HomeList\Default.cshtml"
                                           Write(item.HomeHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h1>\r\n        <h2>");
#nullable restore
#line 9 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\HomeList\Default.cshtml"
       Write(item.HomeContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 10 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\HomeList\Default.cshtml"
                                                                                 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Navbar -->
    <nav id=""navbar"" class=""navbar"">
        <ul>
            <li><a class=""nav-link active"" href=""#header"">AnaSayfa</a></li>
            <li><a class=""nav-link"" href=""#about"">Hakkımda</a></li>
            <li><a class=""nav-link"" href=""#resume"">Özgeçmişim</a></li>
            <li><a class=""nav-link"" href=""#services"">Hizmetlerim</a></li>
            <li><a class=""nav-link"" href=""#portfolio"">Referanslarım</a></li>
            <li><a class=""nav-link"" href=""#contact"">İletişim</a></li>
            <li><a class=""nav-link"" href=""/Writer/Login/Index/"">Yazar Giriş</a></li>
        </ul>
        <i class=""bi bi-list mobile-nav-toggle""></i>
    </nav>
    <!-- End Navbar -->
    <!-- Social Media -->
    ");
#nullable restore
#line 27 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\HomeList\Default.cshtml"
Write(await Component.InvokeAsync("SocialMediaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- End Social Media -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Home>> Html { get; private set; }
    }
}
#pragma warning restore 1591