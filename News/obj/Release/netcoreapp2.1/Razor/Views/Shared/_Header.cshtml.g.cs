#pragma checksum "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1fd37d34002b27812f4a78559c7797a41f011a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Header.cshtml", typeof(AspNetCore.Views_Shared__Header))]
namespace AspNetCore
{
    #line hidden
#line 3 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using System;

#line default
#line hidden
#line 4 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 6 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using System.Linq;

#line default
#line hidden
#line 8 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using EV.Common.Models;

#line default
#line hidden
#line 2 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#line 5 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using System.Data;

#line default
#line hidden
#line 7 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using System.Net.Mail;

#line default
#line hidden
#line 9 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_Header.cshtml"
using TangDuLieu;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1fd37d34002b27812f4a78559c7797a41f011a", @"/Views/Shared/_Header.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(241, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(359, 139, true);
            WriteLiteral("<style>\r\n    .fixed {\r\n        position: fixed !important;\r\n        width: 100%;\r\n    }\r\n    .navbar-nav {\r\n        margin: 0;\r\n    }\r\n    ");
            EndContext();
            BeginContext(499, 738, true);
            WriteLiteral(@"@media (min-width: 768px){
        .navbar-nav > li > a {
            padding-top: 10px;
            padding-bottom: 10px;
        }
    }
    a.linkweb:hover{
        text-decoration:none;
    }
</style>
<nav id=""menu"" class=""main-header navbar navbar-expand bg-white navbar-light border-bottom"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-bar"" data-widget=""pushmenu"" href=""#""><i class=""fa fa-bars""></i></a>
        </li>
        <li class="""">
            <a href=""https://onlineairticket.vn/"" class=""linkweb"" target=""_blank"" style=""line-height: 39px; font-size: 20px; font-weight: bold; font-style: italic;"">onlineairticket.vn</a>
        </li>
");
            EndContext();
            BeginContext(1501, 101, true);
            WriteLiteral("    </ul>\r\n    <!-- Right navbar links -->\r\n</nav>\r\n<!--<ul class=\"navbar-nav ml-auto\">\r\n\r\n</ul>-->\r\n");
            EndContext();
            BeginContext(1602, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2cf7e538614ae39c9b51b95344775f", async() => {
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
            BeginContext(1656, 543, true);
            WriteLiteral(@"
<script>
    function logOut(obj) {
        $.ajax({ url: '/Login/Logout', method: 'POST' })
            .done(function () {
            window.location.replace(""/Login/Index"");
        })
    }
</script>

<script>
    jQuery(""document"").ready(function ($) {
        var nav = $('#menu');
        $(window).scroll(function () {
            if ($(this).scrollTop() > 50) {
                nav.addClass(""fixed"");
            } else {
                nav.removeClass(""fixed"");
            }
        });

    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
