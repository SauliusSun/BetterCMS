﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\Partial\Region.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/Region.cshtml")]
    public partial class _Views_Shared_Partial_Region_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderPageViewModel>
    {
        public _Views_Shared_Partial_Region_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-region-overlay-template\"");

WriteLiteral(">\r\n    <div class=\"bcms-region-overlay bcms-layer\">\r\n");

            
            #line 5 "..\..\Views\Shared\Partial\Region.cshtml"
        
            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Shared\Partial\Region.cshtml"
         if (!Model.IsReadOnly && Model.HasEditRole)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-region-actions\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-region-button bcms-region-sortdone\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Shared\Partial\Region.cshtml"
                                                                                       Write(RootGlobalization.Button_Save);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-region-button bcms-region-contentstree\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Shared\Partial\Region.cshtml"
                                                                                           Write(RootGlobalization.Button_Manage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-region-button bcms-region-sortcancel\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\Shared\Partial\Region.cshtml"
                                                                                         Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-region-button bcms-region-addcontent\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-region-options-block\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-region-pick-editor bcms-region-addhtml\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\Partial\Region.cshtml"
                                                                            Write(RootGlobalization.Button_AddContent_Html);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-region-pick-editor bcms-region-addmarkdown\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\Partial\Region.cshtml"
                                                                                Write(RootGlobalization.Button_AddContent_Markdown);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-region-pick-editor bcms-region-addtext\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Shared\Partial\Region.cshtml"
                                                                            Write(RootGlobalization.Button_AddContent_PlainText);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-region-pick-editor bcms-region-insertwidget\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Shared\Partial\Region.cshtml"
                                                                                 Write(RootGlobalization.Button_AddContent_Widget);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-region-button bcms-region-sortcontent\"");

WriteLiteral("></div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-sort-block\"");

WriteLiteral("></div>\r\n");

            
            #line 24 "..\..\Views\Shared\Partial\Region.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</script>");

        }
    }
}
#pragma warning restore 1591