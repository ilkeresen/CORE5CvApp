#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d49ddd963bb36f884afc99119cda545b2a5838f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_TopBar), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/TopBar.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d49ddd963bb36f884afc99119cda545b2a5838f", @"/Areas/Admin/Views/Admin/TopBar.cshtml")]
    public class Areas_Admin_Views_Admin_TopBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-image img-circle elevation-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle elevation-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
        </li>
    </ul>

    <!-- SEARCH FORM -->
    <form class=""form-inline ml-3"">
        <div class=""input-group input-group-sm"">
            <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Ara"" aria-label=""Search"">
            <div class=""input-group-append"">
                <button class=""btn btn-navbar"" type=""submit"">
                    <i class=""fas fa-search""></i>
                </button>
            </div>
        </div>
    </form>

    <!-- Right navbar links -->
    <ul class=""navbar-nav ml-auto"">
        <!-- DashboardNavbarMessageList row -->
        ");
#nullable restore
#line 25 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
   Write(await Component.InvokeAsync("DashboardNavbarMessageList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- /.DashboardNavbarMessageList row -->\r\n        <!-- AdminLayoutNotificationList row -->\r\n        ");
#nullable restore
#line 28 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
   Write(await Component.InvokeAsync("AdminLayoutNotificationList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- /.AdminLayoutNotificationList row -->\r\n        <!-- User Dropdown Menu -->\r\n        <li class=\"nav-item dropdown user-menu\">\r\n            <a href=\"#\" class=\"nav-link dropdown-toggle\" data-toggle=\"dropdown\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d49ddd963bb36f884afc99119cda545b2a5838f5444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1408, "~/userimage/", 1408, 12, true);
#nullable restore
#line 33 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
AddHtmlAttributeValue("", 1420, Context.Session.GetString("ImageUrl"), 1420, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
AddHtmlAttributeValue("", 1507, Context.Session.GetString("Name"), 1507, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
AddHtmlAttributeValue(" ", 1541, Context.Session.GetString("Surname"), 1542, 37, false);

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
            WriteLiteral("\r\n                <span class=\"d-none d-md-inline\">");
#nullable restore
#line 34 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
                                            Write(Context.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
                                                                               Write(Context.Session.GetString("Surname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </a>\r\n            <ul class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\">\r\n                <!-- User image -->\r\n                <li class=\"user-header bg-dark\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d49ddd963bb36f884afc99119cda545b2a5838f8728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1925, "~/userimage/", 1925, 12, true);
#nullable restore
#line 39 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
AddHtmlAttributeValue("", 1937, Context.Session.GetString("ImageUrl"), 1937, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
AddHtmlAttributeValue("", 2013, Context.Session.GetString("Name"), 2013, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
AddHtmlAttributeValue(" ", 2047, Context.Session.GetString("Surname"), 2048, 37, false);

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
            WriteLiteral("\r\n\r\n                    <p>\r\n                        ");
#nullable restore
#line 42 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
                   Write(Context.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
                                                      Write(Context.Session.GetString("Surname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <small>");
#nullable restore
#line 43 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Admin\TopBar.cshtml"
                          Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                    </p>
                </li>
                <!-- Menu Body -->
                <li class=""user-body"">
                    <div class=""row"">
                        <div class=""col-6 text-center"">
                            <a href=""/Admin/ContactMessage/Index/"">İletişim Mesajları</a>
                        </div>
                        <div class=""col-6 text-center"">
                            <a href=""/Admin/AdminMessage/ReceiverMessage/"">Yazar Mesajları</a>
                        </div>
                    </div>
                    <!-- /.row -->
                </li>
                <!-- Menu Footer-->
                <li class=""user-footer"">
                    <a href=""/Admin/Profile/Index/"" class=""btn btn-default btn-flat"">Profilim</a>
                    <a href=""/Writer/Login/LogOut/"" class=""btn btn-default btn-flat float-right"">Çıkış Yap</a>
                </li>
            </ul>
        </li>
    </ul>
</nav>");
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
