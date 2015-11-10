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
    
    #line 1 "..\..\Views\Security\AccessControlTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Security\AccessControlTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Security\AccessControlTemplate.cshtml"
    using BetterCms.Module.Root.ViewModels.Security;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Security/AccessControlTemplate.cshtml")]
    public partial class _Views_Security_AccessControlTemplate_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Security_AccessControlTemplate_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Security\AccessControlTemplate.cshtml"
  
    UserAccessTemplateViewModel viewModel = (Model is UserAccessTemplateViewModel)
        ? (UserAccessTemplateViewModel)Model
        : new UserAccessTemplateViewModel();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(" id=\"bcms-accesscontrol-context\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-user-access\"");

WriteLiteral(" data-bind=\"with: accessControl\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Security\AccessControlTemplate.cshtml"
   Write(Html.Tooltip(@viewModel.Tooltip));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\Security\AccessControlTemplate.cshtml"
                                    Write(viewModel.Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-access-table\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-access-title bcms-clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-access-title-text\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Security\AccessControlTemplate.cshtml"
                                               Write(RootGlobalization.AccessControl_UserAccess_User);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-access-title-text\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Security\AccessControlTemplate.cshtml"
                                               Write(RootGlobalization.AccessControl_UserAccess_ReadAndEdit);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-access-title-text\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Security\AccessControlTemplate.cshtml"
                                               Write(RootGlobalization.AccessControl_UserAccess_Read);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"bcms-access-title-text\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Security\AccessControlTemplate.cshtml"
                                               Write(RootGlobalization.AccessControl_UserAccess_NoAccess);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n            <div");

WriteLiteral(" data-bind=\"foreach: UserAccessList\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-access-line bcms-clearfix\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-access-value\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"btn-acces-minus\"");

WriteLiteral(" data-bind=\"click: $parent.removeUser\"");

WriteLiteral(">&nbsp;</div>\r\n                        <span");

WriteLiteral(" data-bind=\"visible: IsForRole()\"");

WriteLiteral(">Role:</span><span");

WriteLiteral(" data-bind=\"visible: !IsForRole()\"");

WriteLiteral(">User:</span>&nbsp;<span");

WriteLiteral(" data-bind=\"text: Identity\"");

WriteLiteral("></span>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"bcms-access-value\"");

WriteLiteral("><input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"3\"");

WriteLiteral(" data-bind=\"checked: AccessLevel, attr: { name: $parent.getPropertyIndexer($index" +
"(), \'AccessLevel\') }\"");

WriteLiteral(" /></div>\r\n                    <div");

WriteLiteral(" class=\"bcms-access-value\"");

WriteLiteral("><input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"2\"");

WriteLiteral(" data-bind=\"checked: AccessLevel, attr: { name: $parent.getPropertyIndexer($index" +
"(), \'AccessLevel\') }\"");

WriteLiteral(" /></div>\r\n                    <div");

WriteLiteral(" class=\"bcms-access-value\"");

WriteLiteral("><input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" data-bind=\"checked: AccessLevel, attr: { name: $parent.getPropertyIndexer($index" +
"(), \'AccessLevel\') }\"");

WriteLiteral(" /></div>\r\n                </div>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: $parent.getPropertyIndexer($index(), \'Identity\') }, val" +
"ue: Identity\"");

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: $parent.getPropertyIndexer($index(), \'IsForRole\') }, va" +
"lueBinder: IsForRole\"");

WriteLiteral(" />\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"bcms-access-line bcms-clearfix\"");

WriteLiteral(" data-bind=\"with: userAccessControl\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-access-value-add\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"btn-acces-plus\"");

WriteLiteral(" data-bind=\"click: clickPlus\"");

WriteLiteral(">&nbsp;</div>\r\n                    <span");

WriteLiteral(" data-bind=\"visible: isInAddMode() !== \'user\', click: clickPlus\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Security\AccessControlTemplate.cshtml"
                                                                                     Write(RootGlobalization.AccessControl_UserAccess_AddNewUser);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-add-tags-field\"");

WriteLiteral(@" data-bind=""
                                visible: isInAddMode() === 'user',
                                css: { 'bcms-tag-validation-error': newItem.hasError() },
                                hasfocus: isInAddMode() === 'user' && isExpanded(),
                                value: newItem,
                                valueUpdate: 'afterkeydown',
                                enterPress: clickPlus,
                                autocompleteList: '',
                                escPress: clearItem""");

WriteLiteral(" />\r\n                        <!-- ko if: newItem.hasError() -->\r\n                " +
"        <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                        </span>\r\n                        <!-- /ko -->\r\n" +
"                    </div>\r\n                </div>\r\n            </div>\r\n        " +
"    <div");

WriteLiteral(" class=\"bcms-access-line bcms-clearfix\"");

WriteLiteral(" data-bind=\"with: roleAccessControl\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-access-value-add\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"btn-acces-plus\"");

WriteLiteral(" data-bind=\"click: clickPlus\"");

WriteLiteral(">&nbsp;</div>\r\n                    <span");

WriteLiteral(" data-bind=\"visible: isInAddMode() !== \'role\', click: clickPlus\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\Security\AccessControlTemplate.cshtml"
                                                                                     Write(RootGlobalization.AccessControl_UserAccess_AddNewRole);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-add-tags-field\"");

WriteLiteral(@" data-bind=""
                                visible: isInAddMode() === 'role',
                                css: { 'bcms-tag-validation-error': newItem.hasError() },
                                hasfocus: isInAddMode() === 'role' && isExpanded(),
                                value: newItem,
                                valueUpdate: 'afterkeydown',
                                enterPress: clickPlus,
                                autocompleteList: '',
                                escPress: clearItem""");

WriteLiteral(" />\r\n                        <!-- ko if: newItem.hasError() -->\r\n                " +
"        <span");

WriteLiteral(" class=\"bcms-tag-field-validation-error\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n                        </span>\r\n                        <!-- /ko -->\r\n" +
"                    </div>\r\n                </div>\r\n            </div>\r\n        " +
"</div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
