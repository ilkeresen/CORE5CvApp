#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79487a360bdceea8ad3febe703ef0255dc08e5e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79487a360bdceea8ad3febe703ef0255dc08e5e6", @"/Areas/Writer/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    public class Areas_Writer_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle elevation-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Writer/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-info"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 16 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.MessageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup style=""font-size: 20px""> Adet</sup></h3>

                        <p>Gelen Mesaj Sayısı</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-envelope""></i>
                    </div>
                    <a href=""/Writer/Message/ReceiverMessage/"" class=""small-box-footer"">Daha Fazla Bilgi <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-success"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 31 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.AnnouncementCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup style=""font-size: 20px""> Adet</sup></h3>

                        <p>Toplam Duyuru Sayısı</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-list""></i>
                    </div>
                    <a href=""/Writer/Profile/Index/"" class=""small-box-footer"">Daha Fazla Bilgi <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-indigo"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 46 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup style=""font-size: 20px""> Adet</sup></h3>

                        <p>Toplam Kullanıcı Sayısı</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-person-add""></i>
                    </div>
                    <a href=""/Writer/Profile/Index/"" class=""small-box-footer"">Daha Fazla Bilgi <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-danger"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 61 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.SkillCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup style=""font-size: 20px""> Adet</sup></h3>

                        <p>Gönderilen Mesaj Sayısı</p>
                    </div>
                    <div class=""icon"">
                        <i class=""fas fa-envelope-open""></i>
                    </div>
                    <a href=""/Writer/Message/SenderMessage/"" class=""small-box-footer"">Daha Fazla Bilgi <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
            <section class=""col-lg-4 connectedSortable"">
                <!-- Widget: user widget style 2 -->
                <div class=""card card-widget widget-user-2"">
                    <!-- Add the bg color to the header using any of the bg-* classes -->
                    <div class=""widget-user-header bg-warning"">
                        <div class=""widget-user-image"">
                           ");
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79487a360bdceea8ad3febe703ef0255dc08e5e68264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3654, "~/userimage/", 3654, 12, true);
#nullable restore
#line 83 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
AddHtmlAttributeValue("", 3666, Context.Session.GetString("ImageUrl"), 3666, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 83 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
AddHtmlAttributeValue("", 3711, Context.Session.GetString("Name"), 3711, 34, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
AddHtmlAttributeValue(" ", 3745, Context.Session.GetString("Surname"), 3746, 37, false);

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
            WriteLiteral("\r\n                        </div>\r\n                        <!-- /.widget-user-image -->\r\n                        <h3 class=\"widget-user-username\">Hoş Geldin</h3>\r\n                        <h5 class=\"widget-user-desc\">");
#nullable restore
#line 87 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                Write(Context.Session.GetString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 87 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                                                   Write(Context.Session.GetString("Surname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    </div>
                    <div class=""card-footer p-0"">
                        <ul class=""nav flex-column"">
                            <li class=""nav-item"">
                                <a href=""/Writer/Message/SenderMessage/"" class=""nav-link"">
                                    Gelen Mesaj Sayısı <span class=""float-right badge bg-info"">");
#nullable restore
#line 93 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                                                          Write(ViewBag.MessageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""/Writer/Profile/Index/"" class=""nav-link"">
                                    Toplam Duyuru Sayısı <span class=""float-right badge bg-success"">");
#nullable restore
#line 98 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                                                               Write(ViewBag.AnnouncementCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""/Writer/Profile/Index/"" class=""nav-link"">
                                    Toplam Kullanıcı Sayısı <span class=""float-right badge bg-indigo"">");
#nullable restore
#line 103 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                                                                 Write(ViewBag.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""/Writer/Message/SenderMessage/"" class=""nav-link"">
                                    Gönderilen Mesaj Sayısı <span class=""float-right badge bg-danger"">");
#nullable restore
#line 108 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                                                                 Write(ViewBag.SkillCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <!-- /.widget-user -->
                <!-- TAKVİM -->
                <div class=""card bg-gradient-dark"">
                    <div class=""card-header border-0"">

                        <h3 class=""card-title"">
                            <i class=""far fa-calendar-alt mr-1""></i>
                            Takvim
                            <div hidden id=""sparkline-1""></div>
                            <div hidden id=""sparkline-2""></div>
                            <div hidden id=""sparkline-3""></div>
                        </h3>
                        <!-- tools card -->
                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-dark btn-sm"" data-card-widget=""collapse"" title=""Küçült"">
                                <i class=""fas fa-minus""></i>
              ");
            WriteLiteral(@"              </button>
                            <button type=""button"" class=""btn btn-dark btn-sm"" data-card-widget=""remove"" title=""Kapat"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                        <!-- /. tools -->
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body pt-0"">
                        <!--The calendar -->
                        <div id=""calendar"" style=""width: 100%""></div>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.TAKVİM -->
            </section>
            <!-- /.Left col -->
            <!-- right col -->
            <section class=""col-lg-8 connectedSortable"">
                <!-- AdminDashboardToDoList row -->
                ");
#nullable restore
#line 150 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Writer\Views\Dashboard\Index.cshtml"
           Write(await Component.InvokeAsync("AdminDashboardToDoList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!-- /.AdminDashboardToDoList row -->\r\n            </section>\r\n            <!-- right col -->\r\n        </div>\r\n        <!-- /.row (main row) -->\r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n<!-- /.content -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $(function () {
            const Toast = Swal.mixin({
                toast: true,
                position: 'top-end',
                showConfirmButton: false,
                timer: 3000
            });
            Inputmask().mask(""UpdateDate"");
            Inputmask().mask(""Date"");
            //todo DELETE
            $(document).on(""click"", "".ToDoDelete"", function () {
                var id = $(this).attr(""data-id"");
                $(""#Id"").val(id);
            });

            $(""#ToDoDelete"").click(function () {
                var id = $(""#Id"").val();
                console.log(id);
                debugger
                $.ajax({
                    type: ""POST"",
                    url: ""/Admin/ToDo/ToDoDelete/"",
                    data: { ""id"": id },
                    dataType: ""json"",
                    success: function () {
                        $('#todo-delete').modal('hide')
                        toastr.success('Silme İşlemi Ba");
                WriteLiteral(@"şarılı.')
                        setInterval(function () {
                            location.reload();
                        }, 1500);
                    }
                });
            });

            //todo UpdateT
            $("".ToDoUpdateT"").click(function () {
                var id = $(this).attr(""id"");
                $.ajax({
                    type: ""POST"",
                    url: ""/Admin/ToDo/ToDoUpdateT/"",
                    data: { ""id"": id },
                    dataType: ""json"",
                    success: function () {
                        toastr.success('Güncelleme İşlemi Başarılı.')
                        setInterval(function () {
                            location.reload();
                        }, 1000);
                    }
                });
            });

            //todo UpdateF
            $("".ToDoUpdateF"").click(function () {
                var id = $(this).attr(""id"");
                $.ajax({
                    type: ""POST"",");
                WriteLiteral(@"
                    url: ""/Admin/ToDo/ToDoUpdateF/"",
                    data: { ""id"": id },
                    dataType: ""json"",
                    success: function () {
                        toastr.success('Güncelleme İşlemi Başarılı.')
                        setInterval(function () {
                            location.reload();
                        }, 1000);
                    }
                });
            });

            //todo ADD
            $(""#ToDoAdd"").click(function () {
                $.validator.setDefaults({
                    submitHandler: function () {
                        var adddata = $(""#ToDoAddForm"").serialize();
                        $.ajax({
                            type: ""POST"",
                            url: ""/Admin/ToDo/ToDoAdd/"",
                            data: adddata,
                            dataType: ""json"",
                            success: function () {
                                $('#todo-add').modal('hide')
  ");
                WriteLiteral(@"                              toastr.success('Ekleme İşlemi Başarılı.')
                                setInterval(function () {
                                    location.reload();
                                }, 1500);
                            }
                        });
                    }
                });
                $('#ToDoAddForm').validate({
                    rules: {
                        Date: {
                            required: true,
                            normalizer: function (value) {
                                return $.trim(value);
                            }
                        },
                        TodoContent: {
                            required: true,
                            normalizer: function (value) {
                                return $.trim(value);
                            }
                        },
                    },
                    messages: {
                        Date: {
            ");
                WriteLiteral(@"                required: ""Lütfen boş bırakmayınız.""
                        },
                        TodoContent: {
                            required: ""Lütfen boş bırakmayınız.""
                        },
                    },
                    errorElement: 'span',
                    errorPlacement: function (error, element) {
                        error.addClass('invalid-feedback');
                        element.closest('.form-group').append(error);
                    },
                    highlight: function (element, errorClass, validClass) {
                        $(element).addClass('is-invalid');
                    },
                    unhighlight: function (element, errorClass, validClass) {
                        $(element).removeClass('is-invalid');
                    }
                });
            });

            //todo DETAİL
            $(document).on(""click"", "".ToDoDetail"", function () {
                var id = $(this).attr(""data-id"");
          ");
                WriteLiteral(@"      $.ajax({
                    type: ""POST"",
                    url: ""/Admin/ToDo/ToDoGetItem/"" + id,
                    dataType: ""json"",
                    success: function (toDo) {
                        var obj = jQuery.parseJSON(toDo);
                        console.log(obj);
                        var date = new Date(obj.Date);
                        var dateN = date.getDate() + ""."" + (date.getMonth() + 1) + ""."" + date.getFullYear()
                        $(""#DetailMail"").empty();
                        $(""#DetailContent"").empty();
                        $(""#DetailDate"").empty();
                        $(""#DetailMail"").append(obj.Mail);
                        $(""#DetailContent"").append(obj.TodoContent);
                        $(""#DetailDate"").append(dateN);
                    }
                });
            });

            //todo UPDATE
            $(document).on(""click"", "".ToDoUpdate"", function () {
                var id = $(this).attr(""data-id"");
          ");
                WriteLiteral(@"      $.ajax({
                    type: ""POST"",
                    url: ""/Admin/ToDo/ToDoGetItem/"" + id,
                    dataType: ""json"",
                    success: function (toDo) {
                        var obj = jQuery.parseJSON(toDo);
                        var date = new Date(obj.Date);
                        var dateN = date.getDate() + ""."" + (date.getMonth() + 1) + ""."" + date.getFullYear()
                        $(""#UpdateId"").val(obj.Id);
                        $(""#UpdateDate"").val(dateN);
                        $(""#UpdateTodoContent"").val(obj.TodoContent);
                    }
                });
            });
            $(""#ToDoUpdate"").click(function () {
                $.validator.setDefaults({
                    submitHandler: function () {
                        var updatedata = $(""#ToDoUpdateForm"").serialize();
                        $.ajax({
                            type: ""POST"",
                            url: ""/Admin/ToDo/ToDoUpdate/"",
       ");
                WriteLiteral(@"                     data: updatedata,
                            dataType: ""json"",
                            success: function () {
                                $('#todo-update').modal('hide')
                                toastr.success('Güncelleme İşlemi Başarılı.')
                                setInterval(function () {
                                    location.reload();
                                }, 1500);
                            }
                        });
                    }
                });
                $('#ToDoUpdateForm').validate({
                    rules: {
                        Date: {
                            required: true,
                            normalizer: function (value) {
                                return $.trim(value);
                            }
                        },
                        TodoContent: {
                            required: true,
                            normalizer: function (value) {
   ");
                WriteLiteral(@"                             return $.trim(value);
                            }
                        },
                    },
                    messages: {
                        Date: {
                            required: ""Lütfen boş bırakmayınız.""
                        },
                        TodoContent: {
                            required: ""Lütfen boş bırakmayınız.""
                        },
                    },
                    errorElement: 'span',
                    errorPlacement: function (error, element) {
                        error.addClass('invalid-feedback');
                        element.closest('.form-group').append(error);
                    },
                    highlight: function (element, errorClass, validClass) {
                        $(element).addClass('is-invalid');
                    },
                    unhighlight: function (element, errorClass, validClass) {
                        $(element).removeClass('is-invalid');
    ");
                WriteLiteral("                }\r\n                });\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
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
