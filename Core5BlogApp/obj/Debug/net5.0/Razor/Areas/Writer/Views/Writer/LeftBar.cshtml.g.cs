#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310debabe60cef434b8e74a79df9e7eebdac8cfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Writer_LeftBar), @"mvc.1.0.view", @"/Areas/Writer/Views/Writer/LeftBar.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310debabe60cef434b8e74a79df9e7eebdac8cfa", @"/Areas/Writer/Views/Writer/LeftBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Writer_LeftBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/android-chrome-192x192.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("AdminLTE Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("brand-image img-circle elevation-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("opacity: .8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle elevation-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<aside class=\"main-sidebar sidebar-dark-primary elevation-4\">\r\n    <!-- Brand Logo -->\r\n    <a href=\"/Writer/Dashboard/Index/\" class=\"brand-link\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "310debabe60cef434b8e74a79df9e7eebdac8cfa5020", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <span class=""brand-text font-weight-light""> .NET CORE 5</span>
    </a>

    <!-- Sidebar -->
    <div class=""sidebar"">
        <!-- Sidebar user panel (optional) -->
        <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
            <div class=""image"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "310debabe60cef434b8e74a79df9e7eebdac8cfa6593", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 638, "~/userimage/", 638, 12, true);
#nullable restore
#line 15 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
AddHtmlAttributeValue("", 650, Context.Session.GetString("ImageUrl"), 650, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
AddHtmlAttributeValue("", 726, Context.Session.GetString("Name"), 726, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
AddHtmlAttributeValue(" ", 760, Context.Session.GetString("Surname"), 761, 37, false);

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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"info\">\r\n                <a href=\"/Writer/Profile/Index/\" class=\"d-block\">");
#nullable restore
#line 18 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
                                                            Write(Context.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
                                                                                               Write(Context.Session.GetString("Surname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
            </div>
        </div>

        <!-- Sidebar Menu -->
        <nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                <!-- Add icons to the links using the .nav-icon class
                with font-awesome or any other icon font library -->
                <li class=""nav-item"">
                    <a href=""/Writer/Dashboard/Index/""");
            BeginWriteAttribute("class", " class=\"", 1450, "\"", 1495, 2);
            WriteAttributeValue("", 1458, "nav-link", 1458, 8, true);
#nullable restore
#line 28 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
WriteAttributeValue(" ", 1466, ViewData["DashboardActive"], 1467, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""nav-icon fas fa-home""></i>
                        <p>
                            Dashboard
                        </p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/Writer/Profile/Index/""");
            BeginWriteAttribute("class", " class=\"", 1799, "\"", 1842, 2);
            WriteAttributeValue("", 1807, "nav-link", 1807, 8, true);
#nullable restore
#line 36 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
WriteAttributeValue(" ", 1815, ViewData["ProfileActive"], 1816, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""nav-icon fas fa-user""></i>
                        <p>
                            Profilim
                        </p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/Writer/Message/ReceiverMessage/""");
            BeginWriteAttribute("class", " class=\"", 2155, "\"", 2198, 2);
            WriteAttributeValue("", 2163, "nav-link", 2163, 8, true);
#nullable restore
#line 44 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Writer\LeftBar.cshtml"
WriteAttributeValue(" ", 2171, ViewData["MessageActive"], 2172, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""nav-icon fas fa-envelope""></i>
                        <p>
                            Mesajlarım
                        </p>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a href=""/Writer/Login/LogOut/"" class=""nav-link"">
                        <i class=""nav-icon fas fa-sign-out-alt""></i>
                        <p>
                            Çıkış Yap
                        </p>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.sidebar-menu -->
    </div>
    <!-- /.sidebar -->
</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
