#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c63691f479ee1c9d543ce47a00248e90ddd3c4e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DashboardUserMessageList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DashboardUserMessageList/Default.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
using Core5BlogApp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63691f479ee1c9d543ce47a00248e90ddd3c4e2", @"/Views/Shared/Components/DashboardUserMessageList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6aacfefcee79e604603c6f5a9c8f1b20d25e936", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DashboardUserMessageList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WriterMessageImageUrl>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("direct-chat-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card direct-chat direct-chat-primary"">
    <div class=""card-header"">
        <h3 class=""card-title"">
            <i class=""far fa-envelope mr-1""></i>
            Son Gelen Mesajlar
        </h3>

        <div class=""card-tools"">
            <span data-toggle=""tooltip"" title=""3 Yeni Mesaj"" class=""badge badge-dark"">3 Adet</span>
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Küçült"">
                <i class=""fas fa-minus""></i>
            </button>
            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" title=""Kapat"">
                <i class=""fas fa-times""></i>
            </button>
        </div>
    </div>
    <!-- /.card-header -->
    <div class=""card-body"">
        <!-- Conversations are loaded here -->
        <div class=""direct-chat-messages"" style=""height: auto !important;"">
");
#nullable restore
#line 24 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"direct-chat-msg\">\r\n                    <div class=\"direct-chat-infos clearfix\">\r\n                        <span class=\"direct-chat-name float-left\">");
#nullable restore
#line 29 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
                                                             Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        <span class=\"direct-chat-timestamp float-right\">");
#nullable restore
#line 30 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
                                                                    Write(((DateTime)item.Date).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c63691f479ee1c9d543ce47a00248e90ddd3c4e26173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1450, "~/userimage/", 1450, 12, true);
#nullable restore
#line 33 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
AddHtmlAttributeValue("", 1462, item.ImageUrl, 1462, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
AddHtmlAttributeValue("", 1483, item.SenderName, 1483, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    <div class=\"direct-chat-text\">\r\n");
#nullable restore
#line 36 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
                          string metin = System.Text.RegularExpressions.Regex.Replace(item.MessageContent, @"<(.|\n)*?>", string.Empty); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 37 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
                   Write(Html.Raw(metin.Substring(0, metin.Length > 30 ? 30 : metin.Length)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Views\Shared\Components\DashboardUserMessageList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <!--/.direct-chat-messages-->
    </div>
    <!-- /.card-body -->
    <div class=""card-footer text-center"">
        <a href=""/Admin/AdminMessage/ReceiverMessage/"">Tüm Mesajlar</a>
    </div>
    <!-- /.card-footer-->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WriterMessageImageUrl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
