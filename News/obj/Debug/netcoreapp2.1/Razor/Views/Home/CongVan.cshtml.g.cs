#pragma checksum "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a9afb67df5e9f1ea37ebf150805fcee272dd6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CongVan), @"mvc.1.0.view", @"/Views/Home/CongVan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CongVan.cshtml", typeof(AspNetCore.Views_Home_CongVan))]
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
#line 1 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#line 2 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a9afb67df5e9f1ea37ebf150805fcee272dd6a", @"/Views/Home/CongVan.cshtml")]
    public class Views_Home_CongVan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingList<News_Online.Models.ListCongVan>>
    {
        private global::AspNetCore.Views_Home_CongVan.__Generated__PagerViewComponentTagHelper __PagerViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
  
    ViewData["Title"] = "Công văn";
    Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
            BeginContext(256, 257, true);
            WriteLiteral(@"<style>
    .hid {
        visibility: hidden;
        height:0;
        opacity: 0;
        transition: visibility 0s, opacity 2s linear;
        transition:height 2s;
    }
    .sho {
        visibility: visible;
        opacity: 1;
    }
    ");
            EndContext();
            BeginContext(514, 162, true);
            WriteLiteral("@media(max-width: 768px){\r\n        .noidung img {\r\n            width: 100%!important;\r\n            height: auto!important;\r\n        }\r\n    }   \r\n</style>\r\n<title>");
            EndContext();
            BeginContext(677, 17, false);
#line 28 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(694, 160, true);
            WriteLiteral("</title>\r\n<div class=\"card\" style=\"margin-top:10px;\">\r\n    <div class=\"row \">\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"x_panel\" id=\"CongVan\">\r\n");
            EndContext();
#line 33 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(919, 595, true);
            WriteLiteral(@"                    <div class=""x_content change_color"" style=""padding:0px;"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <div>
                                    <div class=""thumbnail"" style=""padding:0;float:left;width:82px;height:82px;margin:10px;max-height:100%;"">
                                        <div class=""image"" style=""width:82px;height:82px;"">
                                            <img style=""max-width:100%; margin-right:10px; display: block;border:0.6px solid;border-color:#dacfcf""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1514, "\"", 1531, 1);
#line 41 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
WriteAttributeValue("", 1520, item.image, 1520, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1532, 399, true);
            WriteLiteral(@" alt=""image"" />

                                        </div>
                                    </div>
                                </div>
                                <div style=""margin-left: 102px; margin-top: 10px; "">
                                    <div>
                                        <p style=""font-size: 12px; font-weight: 700; color: #000; margin-bottom: 5px;"">");
            EndContext();
            BeginContext(1932, 16, false);
#line 48 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
                                                                                                                  Write(item.description);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 177, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div>\r\n                                        <span style=\"display:block;font-size:12px;\">");
            EndContext();
            BeginContext(2126, 9, false);
#line 51 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
                                                                               Write(item.date);

#line default
#line hidden
            EndContext();
            BeginContext(2135, 138, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2273, "\"", 2294, 1);
#line 54 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
WriteAttributeValue("", 2278, item.subject_id, 2278, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2295, 253, true);
            WriteLiteral(" onclick=\"congvan(this.id)\" href=\"#\"><span style=\"margin-top:10px;display:block;font-size:12px;color:blue;\">xem chi tiết</span></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 58 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
                              
                                string ID_Detail = "ID" + item.subject_id;
                            

#line default
#line hidden
            BeginContext(2687, 86, true);
            WriteLiteral("                            <div class=\"col-sm-12 noidung hid\" style=\"margin: 0 30px;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2773, "\"", 2788, 1);
#line 61 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
WriteAttributeValue("", 2778, ID_Detail, 2778, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2789, 101, true);
            WriteLiteral(">\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 66 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
                }

#line default
#line hidden
            BeginContext(2909, 105, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div style=\"text-align:right;padding:10px\">\r\n        ");
            EndContext();
            BeginContext(3014, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8694beb5a90c444881b1cd981beb01ab", async() => {
            }
            );
            __PagerViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Home_CongVan.__Generated__PagerViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PagerViewComponentTagHelper);
#line 71 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Home\CongVan.cshtml"
__PagerViewComponentTagHelper.pagingList = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("paging-list", __PagerViewComponentTagHelper.pagingList, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3056, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(3080, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f181c48492344ab490032fedc5fd1d3d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3134, 1006, true);
            WriteLiteral(@"
<script>
    function congvan(clicked_id) {
        var IDCV = ""ID"" + clicked_id;
        $.ajax({
            type: ""POST"",
            url: ""/Home/DetailCongVan"",
            data: {
                ID: clicked_id
            },
            success: function (response) {
                document.getElementById(IDCV).innerHTML = response;
                const noidungs = document.querySelectorAll('.noidung');
                noidungs.forEach(box => {
                    box.classList.add(""hid"");
                    box.classList.remove(""sho"");
                });
                var element = document.getElementById(IDCV);
                element.classList.remove(""hid"");
                element.classList.add(""sho"");
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingList<News_Online.Models.ListCongVan>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pager")]
        public class __Generated__PagerViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PagerViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public ReflectionIT.Mvc.Paging.IPagingList pagingList { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Pager", new { pagingList });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
