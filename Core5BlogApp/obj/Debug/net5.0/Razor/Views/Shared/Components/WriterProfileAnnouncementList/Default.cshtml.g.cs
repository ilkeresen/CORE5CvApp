#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb794a68f737e612ad564aa6ac832a08fa1df062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterProfileAnnouncementList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterProfileAnnouncementList/Default.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb794a68f737e612ad564aa6ac832a08fa1df062", @"/Views/Shared/Components/WriterProfileAnnouncementList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6aacfefcee79e604603c6f5a9c8f1b20d25e936", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterProfileAnnouncementList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"timeline timeline-inverse\">\r\n");
#nullable restore
#line 9 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- timeline time label -->\r\n        <div class=\"time-label\">\r\n            <span class=\"bg-dark\">\r\n                ");
#nullable restore
#line 14 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </span>
        </div>
        <!-- /.timeline-label -->
        <!-- timeline item -->
        <div>
            <i class=""fas fa-envelope bg-dark""></i>

            <div class=""timeline-item"">
                <span class=""time""><i class=""far fa-clock""></i> ");
#nullable restore
#line 23 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
                                                            Write(((DateTime)item.Date).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                <h3 class=\"timeline-header\"><b>");
#nullable restore
#line 25 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n\r\n                <div class=\"timeline-body\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- END timeline item -->\r\n");
#nullable restore
#line 33 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\WriterProfileAnnouncementList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
