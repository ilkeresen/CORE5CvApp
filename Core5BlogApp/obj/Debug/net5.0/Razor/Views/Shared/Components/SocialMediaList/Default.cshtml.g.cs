#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\SocialMediaList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4aac123248211c8687e68b45ab68ab31fcd6a96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialMediaList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\SocialMediaList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4aac123248211c8687e68b45ab68ab31fcd6a96", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6aacfefcee79e604603c6f5a9c8f1b20d25e936", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SocialMediaList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"social-links\">\r\n");
#nullable restore
#line 6 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\SocialMediaList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 138, "\"", 165, 1);
#nullable restore
#line 8 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 145, item.SocialMediaUrl, 145, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"twitter\"><i");
            BeginWriteAttribute("class", " class=\"", 201, "\"", 230, 1);
#nullable restore
#line 8 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 209, item.SocialMediaIcon, 209, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 9 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\SocialMediaList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
