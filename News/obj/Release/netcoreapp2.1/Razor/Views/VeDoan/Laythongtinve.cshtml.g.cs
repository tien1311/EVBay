#pragma checksum "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "750032d8ae353b50e3caebc756a08bab83cfdca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VeDoan_Laythongtinve), @"mvc.1.0.view", @"/Views/VeDoan/Laythongtinve.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VeDoan/Laythongtinve.cshtml", typeof(AspNetCore.Views_VeDoan_Laythongtinve))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"750032d8ae353b50e3caebc756a08bab83cfdca0", @"/Views/VeDoan/Laythongtinve.cshtml")]
    public class Views_VeDoan_Laythongtinve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News.Models.VeDoanModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
  

    Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(100, 83, true);
            WriteLiteral("<html>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n\r\n\r\n");
            EndContext();
            BeginContext(183, 8298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f365d83a19c04ebbb9473ac08fc3c255", async() => {
                BeginContext(189, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(247, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(269, 111, true);
                WriteLiteral("    <!-- BreadCrumb Ends -->\r\n\r\n    <section class=\"\">\r\n        <div class=\"\">\r\n            <div class=\"row\">\r\n");
                EndContext();
#line 19 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                 using (Html.BeginForm("Thongtinve", "Vedoan", FormMethod.Post))
                {



#line default
#line hidden
                BeginContext(485, 392, true);
                WriteLiteral(@"                    <section class=""breadcrumb-outer text-center"">
                        <div class=""container"">
                            <div class=""breadcrumb-content"">
                                <h2>Đặt chỗ</h2>

                            </div>
                        </div>
                        <div class=""section-overlay""></div>
                    </section>
");
                EndContext();
                BeginContext(879, 3272, true);
                WriteLiteral(@"                    <div id=""content"" class=""col-md-8"">
                        <div class=""detail-content content-wrapper"">

                            <div id=""div-profile"" class="""">
                                <!-- Profile information -->
                                <div class=""description detail-box flight-book"">
                                    <div class=""detail-title"">
                                        <h3>THÔNG TIN LIÊN HỆ</h3>
                                    </div>

                                    <div class=""description-content"">
                                        <div class=""row"">
                                            <div class=""form-group col-xs-8"">
                                                <label class=""required"" for=""name"">Tên tổ chức/Cá nhân:</label>
                                                <input class=""form-control"" placeholder=""Tên tổ chức/Cá nhân"" maxlength=""255"" required autocomplete="""" name=""name"" type=""text"" value="""">
    ");
                WriteLiteral(@"                                        </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""form-group col-xs-5"">
                                                <label for=""tax_code"">Mã số thuế (Nếu có):</label>
                                                <input class=""form-control"" placeholder=""Mã số thuế"" maxlength=""20"" autocomplete=""off"" name=""mast"" type=""text"">
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""form-group col-xs-6"">
                                                <label class=""required"" for=""email"">Email:</label>
                                                <input class=""form-control"" placeholder=""name@company.com"" maxlength=""255"" required autocomplete=""off"" name=""email"" type=""email"" value="""">
   ");
                WriteLiteral(@"                                         </div>
                                            <div class=""form-group col-xs-6 col-left-padding"">
                                                <label class=""required"" for=""phone"">Số điện thoại:</label>
                                                <input class=""form-control"" placeholder=""Số điện thoại"" maxlength=""50"" required autocomplete=""off"" name=""sdt"" type=""text"" value="""">
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""form-group textarea col-xs-12"">
                                                <label for=""description"">Ghi chú:</label>
                                                <textarea class=""form-control"" placeholder=""Ghi chú"" rows=""2"" maxlength=""500"" name=""ghichu"" cols=""50""></textarea>
                                            </div>
                                    ");
                WriteLiteral("    </div>\r\n\r\n\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
                BeginContext(4153, 650, true);
                WriteLiteral(@"                    <div id=""sidebar"" class=""col-md-4"">
                        <aside class=""detail-sidebar sidebar-wrapper"">
                            <div class=""sidebar-item"">
                                <div class=""detail-title"">
                                    <h3>THÔNG TIN HÀNH TRÌNH</h3>
                                </div>

                                <div class=""sidebar-content"">
                                    <div class=""sidebar-package"">
                                        <div class=""prod-info"">
                                            <h3>
                                                <a>");
                EndContext();
                BeginContext(4804, 28, false);
#line 93 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                              Write(Html.Raw(Model[0].HanhTrinh));

#line default
#line hidden
                EndContext();
                BeginContext(4832, 111, true);
                WriteLiteral("</a>\r\n\r\n                                            </h3>\r\n                                            <br />\r\n");
                EndContext();
#line 97 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                              
                                                var count = 0;
                                            

#line default
#line hidden
                BeginContext(5102, 44, true);
                WriteLiteral("                                            ");
                EndContext();
#line 100 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                             foreach (var result in Model[0].ListVeDoan)
                                            {

#line default
#line hidden
                BeginContext(5239, 126, true);
                WriteLiteral("                                                <tr>\r\n                                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 5365, "\"", 5384, 2);
                WriteAttributeValue("", 5370, "hangbay-", 5370, 8, true);
#line 103 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue("", 5378, count, 5378, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5385, "\"", 5406, 1);
#line 103 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue(" ", 5393, result.MaCB, 5394, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5407, 77, true);
                WriteLiteral(" />\r\n                                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 5484, "\"", 5503, 2);
                WriteAttributeValue("", 5489, "ngaybay-", 5489, 8, true);
#line 104 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue("", 5497, count, 5497, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5504, "\"", 5528, 1);
#line 104 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue(" ", 5512, result.NgayBay, 5513, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5529, 77, true);
                WriteLiteral(" />\r\n                                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 5606, "\"", 5624, 2);
                WriteAttributeValue("", 5611, "giobay-", 5611, 7, true);
#line 105 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue("", 5618, count, 5618, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5625, "\"", 5648, 1);
#line 105 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue(" ", 5633, result.GioBay, 5634, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5649, 61, true);
                WriteLiteral(" />\r\n                                                    <td>");
                EndContext();
                BeginContext(5711, 11, false);
#line 106 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                                   Write(result.MaCB);

#line default
#line hidden
                EndContext();
                BeginContext(5722, 65, true);
                WriteLiteral("</td> -\r\n                                                    <td>");
                EndContext();
                BeginContext(5788, 14, false);
#line 107 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                                   Write(result.NgayBay);

#line default
#line hidden
                EndContext();
                BeginContext(5802, 65, true);
                WriteLiteral("</td> -\r\n                                                    <td>");
                EndContext();
                BeginContext(5868, 13, false);
#line 108 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                                   Write(result.GioBay);

#line default
#line hidden
                EndContext();
                BeginContext(5881, 122, true);
                WriteLiteral("</td>\r\n                                                    <br />\r\n                                                </tr>\r\n");
                EndContext();
#line 111 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"

                                                count++;

                                            }

#line default
#line hidden
                BeginContext(6112, 173, true);
                WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"flight-info\">\r\n                                            <a>Giá Vé : ");
                EndContext();
                BeginContext(6286, 56, false);
#line 118 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                                   Write(string.Format("{0:0,0}", Model[0].Gia).Replace(".", ","));

#line default
#line hidden
                EndContext();
                BeginContext(6342, 182, true);
                WriteLiteral(" VNĐ</a>\r\n                                        </div>\r\n                                        <div class=\"flight-info\">\r\n                                            <a>Số Lương: ");
                EndContext();
                BeginContext(6525, 31, false);
#line 121 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                                    Write(Html.Raw(Model[0].SoLuongKhach));

#line default
#line hidden
                EndContext();
                BeginContext(6556, 181, true);
                WriteLiteral(" </a>\r\n                                        </div>\r\n                                        <div class=\"flight-info\">\r\n                                            <a>Tổng tiền:  ");
                EndContext();
                BeginContext(6738, 61, false);
#line 124 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
                                                      Write(string.Format("{0:0,0}", Model[0].Tongtien).Replace(".", ","));

#line default
#line hidden
                EndContext();
                BeginContext(6799, 152, true);
                WriteLiteral(" VNĐ</a>\r\n                                        </div>\r\n\r\n                                        <input type=\"hidden\" id=\"hanhtrinh\" name=\"hanhtrinh\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6951, "\"", 6979, 1);
#line 127 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue(" ", 6959, Model[0].HanhTrinh, 6960, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6980, 85, true);
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" id=\"gia\" name=\"gia\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7065, "\"", 7087, 1);
#line 128 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue(" ", 7073, Model[0].Gia, 7074, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7088, 93, true);
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" id=\"soluong\" name=\"soluong\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7181, "\"", 7212, 1);
#line 129 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue(" ", 7189, Model[0].SoLuongKhach, 7190, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7213, 95, true);
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" id=\"tongtien\" name=\"tongtien\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7308, "\"", 7335, 1);
#line 130 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue(" ", 7316, Model[0].Tongtien, 7317, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7336, 600, true);
                WriteLiteral(@" />
                                        <input hidden id=""thongtinbay"" name=""thongtinbay"" />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                        <div class=""row"">
                                            <div class=""col-xs-10"" style=""text-align:right; color:#00FFFF;"">
                                                <button type=""submit"" style=""color:#00FFFF;""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 7936, "\"", 7960, 3);
                WriteAttributeValue("", 7946, "vebay(", 7946, 6, true);
#line 139 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"
WriteAttributeValue("", 7952, count, 7952, 6, false);

#line default
#line hidden
                WriteAttributeValue("", 7958, ");", 7958, 2, true);
                EndWriteAttribute();
                BeginContext(7961, 369, true);
                WriteLiteral(@" class=""btn btn-primary"" name=""saveBtn"" value=""saveBtn"">Đặt vé</button>
                                            </div>
                                        </div>
                                    </div>



                                </div>
                            </div>


                        </aside>


                    </div>
");
                EndContext();
#line 154 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\VeDoan\Laythongtinve.cshtml"

                   
                }

#line default
#line hidden
                BeginContext(8372, 102, true);
                WriteLiteral("\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </section>\r\n    <div id=\"dropDownSelect1\"></div>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8481, 2531, true);
            WriteLiteral(@"

</html>



<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    function vebay(count) {


        var thongtin = """";
        // const tieude_i = document.getElementsByClassName(""tieude"");

        for (var i = 0; i < count; i++) {


            var hangbay_i = document.getElementById(""hangbay-"" + i).value;
            var ngaybay_i = document.getElementById(""ngaybay-"" + i).value;
            var giobay_i = document.getElementById(""giobay-"" + i).value;

            thongtin = thongtin + hangbay_i + ""-"" + ngaybay_i + ""-"" + giobay_i +"".""+""\n\n"";





        }


        document.getElementById(""thongtinbay"").value = thongtin;
    }
</script>
<style>
    .breadcrumb-outer h2 {
        color: #ff1a1a;
        margin: 0;
        font-size: 36px;
        padding: 10px 0 35px;
    }

    table.content {
        margin-left: 80px;
    }

    .detail-title h3, .detail-title h4 {
        display: inline-block;
        margi");
            WriteLiteral(@"n: 0;
        border: 1px solid #39A1C9;
        padding: 8px 16px;
        background: #39A1C9;
        color: #ffffff;
    }

    .comment-box h3, form h3 {
        display: inline-block;
        padding-bottom: 18px;
        position: relative;
    }

    h3 {
        font-size: 21px;
    }

    h1, h2, h3, h4, h5, h6 {
        font-weight: 600;
        margin-bottom: 15px;
        color: #444444;
        margin-top: 0;
        line-height: 1.5;
        font-family: 'Josefin Sans', sans-serif;
    }

    .h3, h3 {
        font-size: 24px;
    }

    .h1, .h2, .h3, h1, h2, h3 {
        margin-top: 20px;
        margin-bottom: 10px;
    }

    .h1, .h2, .h3, .h4, .h5, .h6, h1, h2, h3, h4, h5, h6 {
        font-family: inherit;
        font-weight: 500;
        line-height: 1.1;
        color: inherit;
    }

    * {
        margin: 0;
        padding: 0;
    }

    * {
        margin: 0;
        padding: 0;
        border: 0;
        outline: 0;
        fon");
            WriteLiteral(@"t-size: 100%;
        background: transparent;
        box-sizing: border-box;
    }

    * {
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;
    }


    h3 {
        display: block;
        font-size: 1.17em;
        margin-block-start: 1em;
        margin-block-end: 1em;
        margin-inline-start: 0px;
        margin-inline-end: 0px;
        font-weight: bold;
    }
</style>









");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News.Models.VeDoanModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
