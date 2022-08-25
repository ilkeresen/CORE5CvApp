#pragma checksum "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd4fe3f110db1e525df423d73885ea7e85d7e3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd4fe3f110db1e525df423d73885ea7e85d7e3b", @"/Areas/Admin/Views/Contact/Index.cshtml")]
    public class Areas_Admin_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main content -->
<section class=""content"">

    <!-- Default box -->
    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""card-title"">İletişim Listesi Tablosu</h3>

            <div class=""card-tools"">
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Küçült"">
                    <i class=""fas fa-minus""></i>
                </button>
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" data-toggle=""tooltip"" title=""Kapat"">
                    <i class=""fas fa-times""></i>
                </button>
            </div>
        </div>
        <div class=""card-body"">
            <table id=""dttable"" class=""table table-striped projects"">
                <thead>
                    <tr>
                        <th>
                            #
                        </th>
                        <th>
                            İletişim İkon
                    ");
            WriteLiteral(@"    </th>
                        <th>
                            İletişim Başlık
                        </th>
                        <th>
                            İletişim İçerik
                        </th>
                        <th class=""text-right"">
                            İletişim İşlemleri
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 47 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                       int i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                            Write(++i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"pl-5\">\r\n                                <button class=\"btn btn-dark\"><i");
            BeginWriteAttribute("class", " class=\"", 1968, "\"", 1993, 1);
#nullable restore
#line 55 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1976, item.ContactIcon, 1976, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></button>\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 58 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.ContactHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 61 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.ContactContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"project-actions text-right\">\r\n                                <button type=\"button\" class=\"btn btn-outline-info ContactUpdate\"");
            BeginWriteAttribute("id", " id=\"", 2455, "\"", 2475, 1);
#nullable restore
#line 64 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2460, item.ContactID, 2460, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 64 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                                                                                                                          Write(item.ContactID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""modal"" data-target=""#contact-update"">
                                    <i class=""fas fa-edit""></i>
                                    Güncelle
                                </button>
                                <button type=""button"" class=""btn btn-outline-danger ContactDelete""");
            BeginWriteAttribute("id", " id=\"", 2807, "\"", 2827, 1);
#nullable restore
#line 68 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2812, item.ContactID, 2812, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 68 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                                                                                                                            Write(item.ContactID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""modal"" data-target=""#contact-delete"">
                                    <i class=""fas fa-trash""></i>
                                    Sil
                                </button>
                            </td>
                        </tr>
");
#nullable restore
#line 74 "C:\Users\İlker ESEN\Source\Repos\Core5BlogApp\Core5BlogApp\Areas\Admin\Views\Contact\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <th>
                            #
                        </th>
                        <th>
                            İletişim İkon
                        </th>
                        <th>
                            İletişim Başlık
                        </th>
                        <th>
                            İletişim İçerik
                        </th>
                        <th class=""text-right"">
                            İletişim İşlemleri
                        </th>
                    </tr>
                </tfoot>
            </table>
            <button type=""button"" class=""btn btn-outline-dark"" data-toggle=""modal"" data-target=""#contact-add"">
                <i class=""fas fa-plus""></i>
                Yeni İletişim Ekle
            </button>
        </div>
        <!-- /.card-body -->
    </div>
    <!-- /.card -->

</section>
<!-- /.content -->
<!-- UP");
            WriteLiteral(@"DATE MODAL -->
<div class=""modal fade"" id=""contact-update"" style=""display: none;"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header bg-info"">
                <h4 class=""modal-title""><i class=""fas fa-edit""></i> İletişim Güncelle</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <form role=""form"" id=""ContactUpdateForm"">
                <div class=""modal-body"">
                    <input type=""hidden"" name=""ContactID"" id=""UpdateContactID"" />
                    <div class=""form-group"">
                        <label for=""ServiceIcon"">İletişim İkon</label>
                        <select class=""form-control selectlist"" name=""ContactIcon"" id=""UpdateContactIcon"">
                            <option value=""bx bi bi-book-fill""> &#xF192; KİTAP</option>
                    ");
            WriteLiteral(@"        <option value=""bx bi bi-github""> &#xF3ED; GİTHUB</option>
                            <option value=""bx bi bi-filetype-html""> &#xF749; HTML</option>
                            <option value=""bx bi bi-filetype-css""> &#xF742; CSS</option>
                            <option value=""bx bi bi-filetype-scss""> &#xF760; SCSS</option>
                            <option value=""bx bi bi-filetype-js""> &#xF74C; JS</option>
                            <option value=""bx bi bi-filetype-json""> &#xF791; JSON</option>
                            <option value=""bx bi bi-filetype-xml""> &#xF76B; XML</option>
                            <option value=""bx bi bi-archive-fill""> &#xF10C; ARŞİV</option>
                            <option value=""bx bi bi-award-fill""> &#xF153; ÖDÜL</option>
                            <option value=""bx bi bi-bag-check-fill""> &#xF170; ÇANTA ONAY</option>
                            <option value=""bx bi bi-bag-fill""> &#xF174; ÇANTA</option>
                            <option value=""bx");
            WriteLiteral(@" bi bi-bookmark-check-fill""> &#xF195; YER İMİ ONAY</option>
                            <option value=""bx bi bi-bookmark-fill""> &#xF199; YER İMİ</option>
                            <option value=""bx bi bi-bookmarks-fill""> &#xF1A3; YER İMLERİ</option>
                            <option value=""bx bi bi-display-fill""> &#xF301; MONİTÖR</option>
                            <option value=""bx bi bi-envelope-fill""> &#xF32C; MESAJ</option>
                            <option value=""bx bi bi-envelope-check-fill""> &#xF68B; MESAJ ONAY</option>
                            <option value=""bx bi bi-file-code-fill""> &#xF351; DOSYA KOD</option>
                            <option value=""bx bi bi-image-fill""> &#xF429; RESİM</option>
                            <option value=""bx bi bi-tablet-fill""> &#xF5AB; TABLET</option>
                            <option value=""bx bi bi-trash-fill""> &#xF5DD; ÇÖP KUTUSU</option>
                            <option value=""bx bi bi-calendar-fill""> &#xF1E9; TAKVİM</option>
         ");
            WriteLiteral(@"                   <option value=""bx bi bi-calendar2-check-fill""> &#xF1F7; TAKVİM ONAY</option>
                            <option value=""bx bi bi-chat-fill""> &#xF24B; MESAJ BALONU</option>
                            <option value=""bx bi bi-chat-text-fill""> &#xF266; MESAJ BALONU METİN</option>
                            <option value=""bx bi bi-cup-fill""> &#xF2DE; BARDAK KUPA</option>
                            <option value=""bx bi bi-code-slash""> &#xF2C6; KOD SLASH</option>
                            <option value=""bx bi bi-code""> &#xF2C8; KOD</option>
                            <option value=""bx bi bi-brush-fill""> &#xF1D7; FIRÇA</option>
                            <option value=""bx bi bi-music-player-fill""> &#xF4A1; MP3</option>
                            <option value=""bx bi bi-boombox-fill""> &#xF6DF; RADYO</option>
                            <option value=""bx bi bi-file-earmark-music-fill""> &#xF376; MÜZİK YER İMİ</option>
                            <option value=""bx bi bi-file-music-fil");
            WriteLiteral(@"l""> &#xF3A4; MÜZİK</option>
                            <option value=""bx bi bi-spotify""> &#xF666; SPOTİFY</option>
                            <option value=""bx bi bi-earbuds""> &#xF30E; KULAKLIK</option>
                            <option value=""bx bi bi-ticket-detailed-fill""> &#xF6C6; BİLET DETAY</option>
                            <option value=""bx bi bi-ticket-fill""> &#xF6C8; BİLET</option>
                            <option value=""bx bi bi-ticket-perforated-fill""> &#xF6C9; BİLET KESİK</option>
                            <option value=""bx bi bi-steam""> &#xF6C1; STEAM</option>
                            <option value=""bx bi bi-bicycle""> &#xF18D; BİSİKLET</option>
                            <option value=""bx bi bi-geo-alt-fill""> &#xF3E7; KONUM</option>
                            <option value=""bx bi bi-geo-fill""> &#xF3E9; YUVARLAK KONUM</option>
                            <option value=""bx bi bi-pin-map-fill""> &#xF64B; KARE KONUM</option>
                            <option value=""bx bi b");
            WriteLiteral(@"i-server""> &#xF52C; SUNUCU</option>
                            <option value=""bx bi bi-phone""> &#xF4E7; TELEFON</option>
                            <option value=""bx bi bi-phone-fill""> &#xF4E2; TELEFON DOLU</option>
                            <option value=""bx bi bi-laptop""> &#xF456; BİLGİSAYAR DİZÜSTÜ</option>
                            <option value=""bx bi bi-laptop-fill""> &#xF455; BİLGİSAYAR DİZÜSTÜ DOLU</option>
                            <option value=""bx bi bi-arrow-repeat""> &#xF130; TEKRAR</option>
                            <option value=""bx bi bi-eyedropper""> &#xF342; DAMLALIK</option>
                            <option value=""bx bi bi-shop""> &#xF543; MARKET</option>
                            <option value=""bx bi bi-shop-window""> &#xF542; MARKET VİTRİN</option>
                            <option value=""bx bi bi-wifi""> &#xF61C; İNTERNET WİFİ</option>
                            <option value=""bx bi bi-hdd-network-fill""> &#xF40C; İNTERNET DİSK</option>
                            <");
            WriteLiteral(@"option value=""bx bi bi-fonts""> &#xF3DA; METİN YAZI TİPİ</option>
                            <option value=""bx bi bi-paragraph""> &#xF4B4; METİN PARAGRAF</option>
                            <option value=""bx bi bi-textarea-t""> &#xF5CB; METİN METİN ALANI</option>
                            <option value=""bx bi bi-share""> &#xF52E; SOSYAL ADRES</option>
                            <option value=""bx bi bi-share-fill""> &#xF52D; SOSYAL ADRES DOLU</option>
                            <option value=""bx bi bi-telephone-outbound""> &#xF5BC; TELEFON ARAMA</option>
                            <option value=""bx bi bi-telephone-outbound-fill""> &#xF5BB; TELEFON ARAMA DOLU</option>
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""ContactHeader"">İletişim Başlık</label>
                        <input class=""form-control"" type=""text"" id=""UpdateContactHeader"" name=""ContactHeader"" />
                    </div>
               ");
            WriteLiteral(@"     <div class=""form-group"">
                        <label for=""ContactContent"">İletişim İçerik</label>
                        <input class=""form-control"" type=""text"" id=""UpdateContactContent"" name=""ContactContent"" />
                    </div>
                </div>
                <div class=""modal-footer justify-content-between"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Vazgeç</button>
                    <button type=""submit"" class=""btn btn-info"" id=""ContactUpdate"">İletişim Güncelle</button>
                </div>
            </form>
        </div>
    </div>
</div>

<!-- ADD MODAL -->
<div class=""modal fade"" id=""contact-add"" style=""display: none;"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header bg-dark"">
                <h4 class=""modal-title""><i class=""fas fa-pen-nib""></i> İletişim Ekle</h4>
                <button type=""button"" class=""close"" data-dismiss=""moda");
            WriteLiteral(@"l"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <form role=""form"" id=""ContactAddForm"">
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""ContactIcon"">İletişim İkon</label>
                        <select class=""form-control selectlist"" name=""ContactIcon"" id=""ContactIcon"">
                            <option value=""bx bi bi-book-fill""> &#xF192; KİTAP</option>
                            <option value=""bx bi bi-github""> &#xF3ED; GİTHUB</option>
                            <option value=""bx bi bi-filetype-html""> &#xF749; HTML</option>
                            <option value=""bx bi bi-filetype-css""> &#xF742; CSS</option>
                            <option value=""bx bi bi-filetype-scss""> &#xF760; SCSS</option>
                            <option value=""bx bi bi-filetype-js""> &#xF74C; JS</option>
                            <option value=""bx ");
            WriteLiteral(@"bi bi-filetype-json""> &#xF791; JSON</option>
                            <option value=""bx bi bi-filetype-xml""> &#xF76B; XML</option>
                            <option value=""bx bi bi-archive-fill""> &#xF10C; ARŞİV</option>
                            <option value=""bx bi bi-award-fill""> &#xF153; ÖDÜL</option>
                            <option value=""bx bi bi-bag-check-fill""> &#xF170; ÇANTA ONAY</option>
                            <option value=""bx bi bi-bag-fill""> &#xF174; ÇANTA</option>
                            <option value=""bx bi bi-bookmark-check-fill""> &#xF195; YER İMİ ONAY</option>
                            <option value=""bx bi bi-bookmark-fill""> &#xF199; YER İMİ</option>
                            <option value=""bx bi bi-bookmarks-fill""> &#xF1A3; YER İMLERİ</option>
                            <option value=""bx bi bi-display-fill""> &#xF301; MONİTÖR</option>
                            <option value=""bx bi bi-envelope-fill""> &#xF32C; MESAJ</option>
                            <opti");
            WriteLiteral(@"on value=""bx bi bi-envelope-check-fill""> &#xF68B; MESAJ ONAY</option>
                            <option value=""bx bi bi-file-code-fill""> &#xF351; DOSYA KOD</option>
                            <option value=""bx bi bi-image-fill""> &#xF429; RESİM</option>
                            <option value=""bx bi bi-tablet-fill""> &#xF5AB; TABLET</option>
                            <option value=""bx bi bi-trash-fill""> &#xF5DD; ÇÖP KUTUSU</option>
                            <option value=""bx bi bi-calendar-fill""> &#xF1E9; TAKVİM</option>
                            <option value=""bx bi bi-calendar2-check-fill""> &#xF1F7; TAKVİM ONAY</option>
                            <option value=""bx bi bi-chat-fill""> &#xF24B; MESAJ BALONU</option>
                            <option value=""bx bi bi-chat-text-fill""> &#xF266; MESAJ BALONU METİN</option>
                            <option value=""bx bi bi-cup-fill""> &#xF2DE; BARDAK KUPA</option>
                            <option value=""bx bi bi-code-slash""> &#xF2C6; KOD SLA");
            WriteLiteral(@"SH</option>
                            <option value=""bx bi bi-code""> &#xF2C8; KOD</option>
                            <option value=""bx bi bi-brush-fill""> &#xF1D7; FIRÇA</option>
                            <option value=""bx bi bi-music-player-fill""> &#xF4A1; MP3</option>
                            <option value=""bx bi bi-boombox-fill""> &#xF6DF; RADYO</option>
                            <option value=""bx bi bi-file-earmark-music-fill""> &#xF376; MÜZİK YER İMİ</option>
                            <option value=""bx bi bi-file-music-fill""> &#xF3A4; MÜZİK</option>
                            <option value=""bx bi bi-spotify""> &#xF666; SPOTİFY</option>
                            <option value=""bx bi bi-earbuds""> &#xF30E; KULAKLIK</option>
                            <option value=""bx bi bi-ticket-detailed-fill""> &#xF6C6; BİLET DETAY</option>
                            <option value=""bx bi bi-ticket-fill""> &#xF6C8; BİLET</option>
                            <option value=""bx bi bi-ticket-perforated-");
            WriteLiteral(@"fill""> &#xF6C9; BİLET KESİK</option>
                            <option value=""bx bi bi-steam""> &#xF6C1; STEAM</option>
                            <option value=""bx bi bi-bicycle""> &#xF18D; BİSİKLET</option>
                            <option value=""bx bi bi-geo-alt-fill""> &#xF3E7; KONUM</option>
                            <option value=""bx bi bi-geo-fill""> &#xF3E9; YUVARLAK KONUM</option>
                            <option value=""bx bi bi-pin-map-fill""> &#xF64B; KARE KONUM</option>
                            <option value=""bx bi bi-server""> &#xF52C; SUNUCU</option>
                            <option value=""bx bi bi-phone""> &#xF4E7; TELEFON</option>
                            <option value=""bx bi bi-phone-fill""> &#xF4E2; TELEFON DOLU</option>
                            <option value=""bx bi bi-laptop""> &#xF456; BİLGİSAYAR DİZÜSTÜ</option>
                            <option value=""bx bi bi-laptop-fill""> &#xF455; BİLGİSAYAR DİZÜSTÜ DOLU</option>
                            <option value=""bx ");
            WriteLiteral(@"bi bi-arrow-repeat""> &#xF130; TEKRAR</option>
                            <option value=""bx bi bi-eyedropper""> &#xF342; DAMLALIK</option>
                            <option value=""bx bi bi-shop""> &#xF543; MARKET</option>
                            <option value=""bx bi bi-shop-window""> &#xF542; MARKET VİTRİN</option>
                            <option value=""bx bi bi-wifi""> &#xF61C; İNTERNET WİFİ</option>
                            <option value=""bx bi bi-hdd-network-fill""> &#xF40C; İNTERNET DİSK</option>
                            <option value=""bx bi bi-fonts""> &#xF3DA; METİN YAZI TİPİ</option>
                            <option value=""bx bi bi-paragraph""> &#xF4B4; METİN PARAGRAF</option>
                            <option value=""bx bi bi-textarea-t""> &#xF5CB; METİN METİN ALANI</option>
                            <option value=""bx bi bi-share""> &#xF52E; SOSYAL ADRES</option>
                            <option value=""bx bi bi-share-fill""> &#xF52D; SOSYAL ADRES DOLU</option>
               ");
            WriteLiteral(@"             <option value=""bx bi bi-telephone-outbound""> &#xF5BC; TELEFON ARAMA</option>
                            <option value=""bx bi bi-telephone-outbound-fill""> &#xF5BB; TELEFON ARAMA DOLU</option>
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label for=""ContactHeader"">İletişim Başlık</label>
                        <input class=""form-control"" type=""text"" id=""ContactHeader"" name=""ContactHeader"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""ContactContent"">İletişim İçerik</label>
                        <input class=""form-control"" type=""text"" id=""ContactContent"" name=""ContactContent"" />
                    </div>
                </div>
                <div class=""modal-footer justify-content-between"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Vazgeç</button>
                    <button type=""submi");
            WriteLiteral(@"t"" class=""btn btn-dark"" id=""ContactAdd"">İletişim Ekle</button>
                </div>
            </form>
        </div>
    </div>
</div>

<!-- DELETE MODAL -->
<div class=""modal fade"" id=""contact-delete"" style=""display: none;"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header bg-danger"">
                <h4 class=""modal-title""><i class=""fas fa-trash""></i> Emin Misin?</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <strong>Seçtiğiniz İletişim Silinecektir.</strong>
                <input type=""hidden"" name=""ContactID"" id=""ContactID"" />
            </div>
            <div class=""modal-footer justify-content-between"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Vazgeç</button>
 ");
            WriteLiteral("               <input type=\"button\" id=\"ContactDelete\" class=\"btn btn-danger\" value=\"İletişim Sil\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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

            //Contact DELETE
            $(document).on(""click"", "".ContactDelete"", function () {
                var id = $(this).attr(""data-id"");
                $(""#ContactID"").val(id);
            });

            $(""#ContactDelete"").click(function () {
                var id = $(""#ContactID"").val();
                $.ajax({
                    type: ""POST"",
                    url: ""/Admin/Contact/ContactDelete/"",
                    data: { ""id"": id },
                    dataType: ""json"",
                    success: function () {
                        $('#contact-delete').modal('hide')
                        toastr.success('Silme İşlemi Başarılı.')
                        setInterval(function () {
                            location.reload();
");
                WriteLiteral(@"                        }, 1500);
                    }
                });
            });

            //Contact ADD
            $(""#ContactAdd"").click(function () {
                $.validator.setDefaults({
                    submitHandler: function () {
                        var adddata = $(""#ContactAddForm"").serialize();
                        $.ajax({
                            type: ""POST"",
                            url: ""/Admin/Contact/ContactAdd/"",
                            data: adddata,
                            dataType: ""json"",
                            success: function () {
                                $('#contact-add').modal('hide')
                                toastr.success('Ekleme İşlemi Başarılı.')
                                setInterval(function () {
                                    location.reload();
                                }, 1500);
                            }
                        });
                    }
                })");
                WriteLiteral(@";
                $('#ContactAddForm').validate({
                    rules: {
                        ContactHeader: {
                            required: true,
                            normalizer: function (value) {
                                return $.trim(value);
                            }
                        },
                        ContactContent: {
                            required: true,
                            normalizer: function (value) {
                                return $.trim(value);
                            }
                        },
                    },
                    messages: {
                        ContactHeader: {
                            required: ""Lütfen boş bırakmayınız.""
                        },
                        ContactContent: {
                            required: ""Lütfen boş bırakmayınız.""
                        },
                    },
                    errorElement: 'span',
                    er");
                WriteLiteral(@"rorPlacement: function (error, element) {
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

            //Contact UPDATE
            $(document).on(""click"", "".ContactUpdate"", function () {
                var id = $(this).attr(""data-id"");
                $.ajax({
                    type: ""POST"",
                    url: ""/Admin/Contact/ContactGetItem/"" + id,
                    dataType: ""json"",
                    success: function (contact) {
                        var obj = jQuery.parseJSON(contact);
                        $(""#Upd");
                WriteLiteral(@"ateContactID"").val(obj.ContactID);
                        $(""#UpdateContactIcon"").val(obj.ContactIcon);
                        $(""#UpdateContactHeader"").val(obj.ContactHeader);
                        $(""#UpdateContactContent"").val(obj.ContactContent);
                    }
                });
            });
            $(""#ContactUpdate"").click(function () {
                $.validator.setDefaults({
                    submitHandler: function () {
                        var updatedata = $(""#ContactUpdateForm"").serialize();
                        $.ajax({
                            type: ""POST"",
                            url: ""/Admin/Contact/ContactUpdate/"",
                            data: updatedata,
                            dataType: ""json"",
                            success: function () {
                                $('#contact-update').modal('hide')
                                toastr.success('Güncelleme İşlemi Başarılı.')
                                setInterva");
                WriteLiteral(@"l(function () {
                                    location.reload();
                                }, 1500);
                            }
                        });
                    }
                });
                $('#ContactUpdateForm').validate({
                    rules: {
                        ContactHeader: {
                            required: true,
                            normalizer: function (value) {
                                return $.trim(value);
                            }
                        },
                        ContactContent: {
                            required: true,
                            normalizer: function (value) {
                                return $.trim(value);
                            }
                        },
                    },
                    messages: {
                        ContactHeader: {
                            required: ""Lütfen boş bırakmayınız.""
                        },
      ");
                WriteLiteral(@"                  ContactContent: {
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

        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
