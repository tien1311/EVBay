#pragma checksum "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7235b6f9e121f72da0e768551785e4a707372832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideMenu), @"mvc.1.0.view", @"/Views/Shared/_SideMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SideMenu.cshtml", typeof(AspNetCore.Views_Shared__SideMenu))]
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
#line 1 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
using News_Online.Models;

#line default
#line hidden
#line 2 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
using News_Online.Models.Repository;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7235b6f9e121f72da0e768551785e4a707372832", @"/Views/Shared/_SideMenu.cshtml")]
    public class Views_Shared__SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
  
    SideMenuRepository SideMenu_Rep = new SideMenuRepository();
    SideMenuModel sideMenu = SideMenu_Rep.SideMenu();

#line default
#line hidden
            BeginContext(194, 229, true);
            WriteLiteral("<style>\r\n    a.nav-link {\r\n        padding: 5px!important;\r\n    }\r\n</style>\r\n\r\n<aside class=\"main-sidebar sidebar-dark-primary elevation-4\">\r\n    <!-- Brand Logo -->\r\n    <div>\r\n        <a href=\"/Home/Index\" class=\"brand-link\">\r\n");
            EndContext();
            BeginContext(636, 352, true);
            WriteLiteral(@"            <img class=""brand-image"" src=""https://manager.airline24h.com/Upload/news.png"" />
        </a>
    </div>

    <!-- Sidebar -->
    <div class=""sidebar"">
        <!-- Sidebar Menu -->
        <nav class=""mt-2"">
            <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
");
            EndContext();
            BeginContext(1290, 335, true);
            WriteLiteral(@"                <li class=""nav-item has-treeview"">
                    <a href=""/Home/Index"" class=""nav-link"">
                        <i class=""nav-icon fa fa-angle-double-right""></i>
                        <p>
                            Trang chủ
                        </p>
                    </a>
                </li>
");
            EndContext();
            BeginContext(2311, 340, true);
            WriteLiteral(@"                <li class=""nav-item has-treeview"">
                    <a href=""/VeDoan/ListVeDoan"" class=""nav-link"">
                        <i class=""nav-icon fa fa-angle-double-right""></i>
                        <p>
                            Vé đoàn
                        </p>
                    </a>
                </li>
");
            EndContext();
#line 68 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
                 foreach (var itemParent in sideMenu.ListSideMenu_Parent)
                {

#line default
#line hidden
            BeginContext(2745, 265, true);
            WriteLiteral(@"                    <li class=""nav-item has-treeview menu-open"">
                        <a href=""#"" class=""nav-link"">
                            <i class=""nav-icon fa fa-angle-double-right""></i>
                            <p>
                                ");
            EndContext();
            BeginContext(3011, 15, false);
#line 74 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
                           Write(itemParent.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3026, 193, true);
            WriteLiteral("\r\n                                <i class=\"right fa fa-angle-left\"></i>\r\n                            </p>\r\n                        </a>\r\n                        <ul class=\"nav nav-treeview\">\r\n");
            EndContext();
#line 79 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
                             foreach (var itemChild in sideMenu.ListSideMenu_Child)
                            {
                                if (itemParent.ID == itemChild.IDParent)
                                {

#line default
#line hidden
            BeginContext(3444, 101, true);
            WriteLiteral("                                    <li class=\"nav-item\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3545, "\"", 3592, 2);
            WriteAttributeValue("", 3552, "/Home/BaiViet?&IDMenuChild=", 3552, 27, true);
#line 84 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
WriteAttributeValue("", 3579, itemChild.ID, 3579, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3593, 75, true);
            WriteLiteral(" style=\"padding-left: 35px;\">\r\n                                            ");
            EndContext();
            BeginContext(3669, 14, false);
#line 85 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
                                       Write(itemChild.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3683, 91, true);
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n");
            EndContext();
#line 88 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(3840, 60, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </li>\r\n");
            EndContext();
#line 93 "D:\EnViet\SourceAzure\news.onlineairticket.vn\News\Views\Shared\_SideMenu.cshtml"
                }

#line default
#line hidden
            BeginContext(3919, 116, true);
            WriteLiteral("\r\n            </ul>\r\n        </nav>\r\n        <!-- /.sidebar-menu -->\r\n    </div>\r\n    <!-- /.sidebar -->\r\n</aside>\r\n");
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
