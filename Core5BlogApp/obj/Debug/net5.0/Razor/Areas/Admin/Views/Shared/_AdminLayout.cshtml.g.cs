#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d73a11284da6984e0c6742974cd78c69ce58a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d73a11284da6984e0c6742974cd78c69ce58a1", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
    public class Areas_Admin_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n<!-- Head -->\r\n\r\n");
#nullable restore
#line 11 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Admin/Views/Admin/HtmlHeadTag.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- /.Head -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d73a11284da6984e0c6742974cd78c69ce58a13655", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n\r\n        <!-- Navbar -->\r\n\r\n        ");
#nullable restore
#line 20 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Areas/Admin/Views/Admin/TopBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- /.navbar -->\r\n        <!-- Main Sidebar Container -->\r\n\r\n        ");
#nullable restore
#line 25 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Areas/Admin/Views/Admin/LeftBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Content Wrapper. Contains page content -->\r\n        <div class=\"content-wrapper\">\r\n\r\n            ");
#nullable restore
#line 30 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("/Areas/Admin/Views/Admin/PageTopNavigation.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 32 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <!-- /.content-wrapper -->\r\n        <!-- Footer & Control Sidebar -->\r\n\r\n        ");
#nullable restore
#line 37 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Areas/Admin/Views/Admin/Footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- /.Footer & Control Sidebar -->\r\n    </div>\r\n    <!-- ./wrapper -->\r\n\r\n    <!-- Scripts -->\r\n\r\n    ");
#nullable restore
#line 45 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Admin/Views/Admin/HtmlScriptTag.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 46 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(await RenderSectionAsync("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n    <!-- /.Scripts -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
