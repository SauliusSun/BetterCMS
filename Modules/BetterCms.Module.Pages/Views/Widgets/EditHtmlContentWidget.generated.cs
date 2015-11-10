﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    
    #line 1 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
    using BetterCms.Module.Pages;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
    using BetterCms.Module.Pages.ViewModels.Widgets;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
    using BetterCms.Module.Root.ViewModels.Category;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/EditHtmlContentWidget.cshtml")]
    public partial class _Views_Widgets_EditHtmlContentWidget_cshtml : System.Web.Mvc.WebViewPage<EditHtmlContentWidgetViewModel>
    {
        public _Views_Widgets_EditHtmlContentWidget_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
 if (Model == null)
{
    return;
}

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
  
    var categoriesTemplateViewModel = new CategoryTemplateViewModel
    {
        TooltipDescription = PagesGlobalization.EditPageProperties_BasicPropertiesTab_Category_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-tab-header bcms-js-tab-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                            Write(PagesGlobalization.EditWidget_BasicPropertiesTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                Write(PagesGlobalization.EditWidget_OptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <a");

WriteLiteral(" class=\"bcms-tab-ui bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-3\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                Write(PagesGlobalization.EditWidget_AdvancedOptionsTab_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-window-tabbed-options\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 31 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
   Write(Html.MessagesBox("bcms-edit-widget-messages"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 32 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
   Write(Html.Partial("Partial/WarnMessageAboutDraft", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 33 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
        
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
         using (Html.BeginForm<WidgetsController>(c => c.EditHtmlContentWidget((string)null), FormMethod.Post, new { @id = "bcms-advanced-content-form", @class = "bcms-ajax-form" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 37 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
               Write(Html.Tooltip(PagesGlobalization.HtmlContentWidget_ContentName_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                Write(PagesGlobalization.HtmlContentWidget_ContentName_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 40 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                   Write(Html.TextBoxFor(model => model.Name, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 41 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                   Write(Html.BcmsValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                Write(PagesGlobalization.HtmlContentWidget_CustomHTML_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-poptext-editor-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 48 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                   Write(Html.TextAreaFor(model => model.PageContent, new { @class = "bcms-advanced-contenthtml", @id = Guid.NewGuid() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 54 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                   Write(Html.CheckBoxFor(model => model.EnableCustomHtml, new { @id = "bcms-enable-custom-html" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                Write(Html.Raw(PagesGlobalization.HtmlContentWidget_RenderCustomHTML_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n\r\n                <di" +
"v");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" data-bind=\"with: categories\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 60 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
               Write(Html.Partial("~/Areas/bcms-root/Views/Category/CategoriesTemplate.cshtml", categoriesTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 63 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 65 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
           Write(Html.Partial(PagesConstants.OptionsGridTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 67 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-3\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 70 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                Write(PagesGlobalization.HtmlContentWidget_CustomCSS_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 71 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
               Write(Html.TextAreaFor(model => model.CustomCSS, new { @class = "bcms-field-textarea bcms-code-field bcms-code-field-css", @id = Guid.NewGuid() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                   Write(Html.CheckBoxFor(model => model.EnableCustomCSS, new { @id = "bcms-enable-custom-css" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 76 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                Write(Html.Raw(PagesGlobalization.HtmlContentWidget_RenderCustomCSS_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                Write(PagesGlobalization.HtmlContentWidget_CustomJS_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
               Write(Html.TextAreaFor(model => model.CustomJS, new { @class = "bcms-field-textarea bcms-code-field bcms-code-field-javascript", id = Guid.NewGuid() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 85 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                   Write(Html.CheckBoxFor(model => model.EnableCustomJS, new { @id = "bcms-enable-custom-js" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                Write(Html.Raw(PagesGlobalization.HtmlContentWidget_RenderCustomJS_Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 90 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"

            
            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
       Write(Html.HiddenFor(model => model.Id, new { @id = "bcmsContentId" }));

            
            #line default
            #line hidden
            
            #line 91 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                             
            
            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
       Write(Html.HiddenFor(model => model.Version, new { @id = "bcmsContentVersion" }));

            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                                       
            
            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
       Write(Html.HiddenFor(modal => modal.DesirableStatus, new { @class = "bcms-content-desirable-status" }));

            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                                                             
            
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
       Write(Html.HiddenFor(modal => modal.PreviewOnPageContentId, new { @class = "bcms-preview-page-content-id" }));

            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                                                                   
            
            
            #line default
            #line hidden
            
            #line 95 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
       Write(Html.HiddenFor(model => model.EditInSourceMode, new { @id = "bcms-edit-in-source-mode" }));

            
            #line default
            #line hidden
            
            #line 95 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                                                      
            
            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
       Write(Html.HiddenFor(modal => modal.IsUserConfirmed, new { @id = "bcms-user-confirmed-region-deletion" }));

            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                                                                                                
            
            
            #line default
            #line hidden
            
            #line 97 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
       Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 97 "..\..\Views\Widgets\EditHtmlContentWidget.cshtml"
                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
