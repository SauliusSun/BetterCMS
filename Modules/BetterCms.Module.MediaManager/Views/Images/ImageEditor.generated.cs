﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.MediaManager.Views.Images
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
    
    #line 6 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Content.Resources;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Controllers;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.Models;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.MediaManager.ViewModels.Images;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Images\ImageEditor.cshtml"
    using BetterCms.Module.Root.ViewModels.Tags;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Images\ImageEditor.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Images/ImageEditor.cshtml")]
    public partial class ImageEditor : System.Web.Mvc.WebViewPage<ImageViewModel>
    {
        public ImageEditor()
        {
        }
        public override void Execute()
        {








WriteLiteral("\r\n");



            
            #line 11 "..\..\Views\Images\ImageEditor.cshtml"
  
    var tagsTemplateViewModel = new TagsTemplateViewModel
    {
        TooltipDescription = MediaGlobalization.FileEditor_Dialog_AddTags_Tooltip_Description
    };


            
            #line default
            #line hidden
WriteLiteral("<div class=\"bcms-scroll-window\">\r\n    ");


            
            #line 18 "..\..\Views\Images\ImageEditor.cshtml"
Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div class=\"bcms-file-manager-inner bcms-clearfix\">\r\n");


            
            #line 20 "..\..\Views\Images\ImageEditor.cshtml"
         using (Html.BeginForm<ImagesController>(f => f.ImageEditor((ImageViewModel)null), FormMethod.Post, new { @class = "bcms-ajax-form", @enctype = "multipart/form-data" }))
        {
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Images\ImageEditor.cshtml"
                                              
            
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenFor(model => model.Version, new { @id = "image-version-field" }));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                        
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenFor(model => model.CropCoordX1, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordX1())" }));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                     
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenFor(model => model.CropCoordX2, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordX2())" }));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                     
            
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenFor(model => model.CropCoordY1, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordY1())" }));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                     
            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenFor(model => model.CropCoordY2, new { @data_bind = "value: Math.floor(imageEditorViewModel.cropCoordY2())" }));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                     


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"bcms-input-list-holder\">\r\n                ");


            
            #line 30 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_CropImage_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div class=\"bcms-content-titles\">\r\n                    ");


            
            #line 32 "..\..\Views\Images\ImageEditor.cshtml"
               Write(MediaGlobalization.ImageEditor_Dialog_CropImage_Title);

            
            #line default
            #line hidden
WriteLiteral(@"

                    <a class=""bcms-icn-delete-link"" data-bind=""visible: imageEditorViewModel.hasCrop(), click: imageEditorViewModel.removeCrop"">Remove crop</a>
                    <div class=""bcms-crop-checkbox"">
                        <input type=""checkbox"" data-bind=""checked: imageEditorViewModel.fit"" />
                        <div class=""bcms-edit-label"" data-bind=""click: imageEditorViewModel.changeFit"">");


            
            #line 37 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                  Write(MediaGlobalization.ImageEditor_Dialog_FitImage_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");


            
            #line 41 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"bcms-croped-block\">\r\n                <img src=\"\" data-bin" +
"d=\"style: { width: imageEditorViewModel.calculatedWidth() + \'px\', height: imageE" +
"ditorViewModel.calculatedHeight() + \'px\' }\" />\r\n            </div>\r\n");


            
            #line 45 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"bcms-edit-file-info\">\r\n\r\n                <div class=\"bcms" +
"-file-info-text\">\r\n                    <div class=\"bcms-content-titles\">");


            
            #line 49 "..\..\Views\Images\ImageEditor.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_PublicUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div class=\"bcms-edit-file-info\">\r\n                  " +
"      <input class=\"bcms-editor-field-box bcms-editor-selectable-field-box\" type" +
"=\"text\" value=\"");


            
            #line 51 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                            Write(Model.Url);

            
            #line default
            #line hidden
WriteLiteral("\" readonly=\"readonly\" />\r\n                    </div>\r\n                </div>\r\n\r\n " +
"               <div class=\"bcms-input-list-holder\">\r\n                    ");


            
            #line 56 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Caption_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"bcms-content-titles\">");


            
            #line 57 "..\..\Views\Images\ImageEditor.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_Caption);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div class=\"bcms-input-box\">\r\n                       " +
" ");


            
            #line 59 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.TextBoxFor(f => f.Caption, new { @class = "bcms-editor-field-box", @id = "Caption", data_bind = "event: {change: onValueChange}" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        ");


            
            #line 60 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.BcmsValidationMessageFor(f => f.Caption));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div clas" +
"s=\"bcms-file-info-text\" data-bind=\"with: titleEditorViewModel\" id=\"bcms-image-ti" +
"tle-editor-box\">\r\n                    <b>");


            
            #line 65 "..\..\Views\Images\ImageEditor.cshtml"
                  Write(MediaGlobalization.ImageEditor_Dialog_ImageName_Title);

            
            #line default
            #line hidden
WriteLiteral(":</b><div class=\"bcms-editing-text\" data-bind=\"text: oldTitle()\"></div>\r\n        " +
"            <a class=\"bcms-file-link\" data-bind=\"click: open, visible: !isOpened" +
"()\">");


            
            #line 66 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                       Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    <div class=\"bcms-file-edit\" data-bind=\"style: { \'displa" +
"y\': isOpened() ? \'block\' : \'none\' }\" style=\"display: none;\">\r\n                  " +
"      <div class=\"bcms-content-titles\">");


            
            #line 68 "..\..\Views\Images\ImageEditor.cshtml"
                                                    Write(MediaGlobalization.ImageEditor_Dialog_ImageTitle_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div class=\"bcms-custom-input-box\" style=\"width: " +
"255px;\">\r\n                            ");


            
            #line 70 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.TextBoxFor(f => f.Title, new
                       {
                           @class = "bcms-editor-field-box",
                           @id = "bcms-image-title-editor",
                           @data_bind = "value: title, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: {change: $parent.onValueChange}"
                       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            ");


            
            #line 76 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div class=\"bcms-btn-sm" +
"all\" data-bind=\"click: save\">");


            
            #line 78 "..\..\Views\Images\ImageEditor.cshtml"
                                                                       Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div class=\"bcms-btn-links-small\" data-bind=\"clic" +
"k: close\">");


            
            #line 79 "..\..\Views\Images\ImageEditor.cshtml"
                                                                              Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n\r\n                <di" +
"v class=\"bcms-file-info-text\">\r\n                    <b>");


            
            #line 84 "..\..\Views\Images\ImageEditor.cshtml"
                  Write(MediaGlobalization.ImageEditor_Dialog_FileSize);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n                    <div class=\"bcms-editing-text\" id=\"image-file-size\">");


            
            #line 85 "..\..\Views\Images\ImageEditor.cshtml"
                                                                   Write(Model.FileSize);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n\r\n                <div class=\"bcms-file-info-text" +
"\">\r\n                    <b>");


            
            #line 89 "..\..\Views\Images\ImageEditor.cshtml"
                  Write(MediaGlobalization.ImageEditor_Dialog_CroppedDimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n                    <div class=\"bcms-editing-text\" id=\"image-file-size\" da" +
"ta-bind=\"text: imageEditorViewModel.croppedWidthAndHeight()\">");


            
            #line 90 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                  Write(Model.CroppedWidth);

            
            #line default
            #line hidden
WriteLiteral(" x ");


            
            #line 90 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                                                                        Write(Model.CroppedHeight);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n\r\n                <div class=\"bcms-file-info-text" +
"\" data-bind=\"with: imageEditorViewModel\" id=\"bcms-image-dimensions-editor-box\">\r" +
"\n                    <b>");


            
            #line 94 "..\..\Views\Images\ImageEditor.cshtml"
                  Write(MediaGlobalization.ImageEditor_Dialog_Dimensions);

            
            #line default
            #line hidden
WriteLiteral(":</b>\r\n                    <div class=\"bcms-editing-text\" data-bind=\"text: widthA" +
"ndHeight()\">");


            
            #line 95 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                 Write(Model.ImageWidth);

            
            #line default
            #line hidden
WriteLiteral(" x ");


            
            #line 95 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                     Write(Model.ImageHeight);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <a class=\"bcms-file-link\" data-bind=\"click: open, vis" +
"ible: !isOpened()\">");


            
            #line 96 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                       Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    <div class=\"bcms-file-edit\" data-bind=\"style: { \'displa" +
"y\': isOpened() ? \'block\' : \'none\' }\">\r\n                        <div class=\"bcms-" +
"content-titles\">\r\n                            ");


            
            #line 99 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <span>");


            
            #line 101 "..\..\Views\Images\ImageEditor.cshtml"
                         Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Width);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n                        <div class=\"bcms-custom-input-box\" style=\"width" +
": 75px;\">\r\n                            ");


            
            #line 103 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.TextBoxFor(f => f.ImageWidth, new
                       {
                           @class = "bcms-editor-field-box",
                           @id = "image-width",
                           @data_bind = "value: width, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: { change: changeHeight }"
                       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            ");


            
            #line 109 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.ImageWidth));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <span>");


            
            #line 111 "..\..\Views\Images\ImageEditor.cshtml"
                         Write(MediaGlobalization.ImageEditor_Dialog_ChangeSize_Height);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n                        <div class=\"bcms-custom-input-box\" style=\"width" +
": 75px;\">\r\n                            ");


            
            #line 113 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.TextBoxFor(f => f.ImageHeight, new
                       {
                           @class = "bcms-editor-field-box",
                           @id = "image-height",
                           @data_bind = "value: height, valueUpdate: 'afterkeydown', enterPress: save, escPress: close, event: { change: changeWidth }"
                       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            ");


            
            #line 119 "..\..\Views\Images\ImageEditor.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.ImageHeight));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div class=\"bcms-btn-sm" +
"all\" data-bind=\"click: save\">");


            
            #line 121 "..\..\Views\Images\ImageEditor.cshtml"
                                                                       Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div class=\"bcms-btn-links-small\" data-bind=\"clic" +
"k: close\">");


            
            #line 122 "..\..\Views\Images\ImageEditor.cshtml"
                                                                              Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                        <a data-bind=\"click: restoreOriginalSize\">");


            
            #line 124 "..\..\Views\Images\ImageEditor.cshtml"
                                                             Write(MediaGlobalization.ImageEditor_Dialog_RestoreOriginalSize_Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");


            
            #line 128 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"bcms-file-alignment\">\r\n                <div class=\"bcms-c" +
"ontent-titles\">");


            
            #line 130 "..\..\Views\Images\ImageEditor.cshtml"
                                            Write(MediaGlobalization.ImageEditor_Dialog_AligmentTitle);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div class=\"bcms-alignment-controls\">\r\n                  " +
"  <div class=\"bcms-align-center");


            
            #line 132 "..\..\Views\Images\ImageEditor.cshtml"
                                             Write(Model.ImageAlign == MediaImageAlign.Center ? "-active" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <input type=\"radio\" name=\"ImageAlign\" value=\"");


            
            #line 133 "..\..\Views\Images\ImageEditor.cshtml"
                                                                 Write((int)MediaImageAlign.Center);

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 133 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                 Write(Model.ImageAlign == MediaImageAlign.Center ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\r\n                    </div>\r\n                " +
"    <div class=\"bcms-align-left");


            
            #line 135 "..\..\Views\Images\ImageEditor.cshtml"
                                           Write(Model.ImageAlign == MediaImageAlign.Left ? "-active" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <input type=\"radio\" name=\"ImageAlign\" value=\"");


            
            #line 136 "..\..\Views\Images\ImageEditor.cshtml"
                                                                 Write((int)MediaImageAlign.Left);

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 136 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                               Write(Model.ImageAlign == MediaImageAlign.Left ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\r\n                    </div>\r\n                " +
"    <div class=\"bcms-align-right");


            
            #line 138 "..\..\Views\Images\ImageEditor.cshtml"
                                            Write(Model.ImageAlign == MediaImageAlign.Right ? "-active" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <input type=\"radio\" name=\"ImageAlign\" value=\"");


            
            #line 139 "..\..\Views\Images\ImageEditor.cshtml"
                                                                 Write((int)MediaImageAlign.Right);

            
            #line default
            #line hidden
WriteLiteral("\" ");


            
            #line 139 "..\..\Views\Images\ImageEditor.cshtml"
                                                                                                Write(Model.ImageAlign == MediaImageAlign.Right ? "checked" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(" data-bind=\"checked: imageAlign\" />\r\n                    </div>\r\n                " +
"</div>\r\n\r\n                <div class=\"bcms-input-list-holder\">\r\n                " +
"    ");


            
            #line 144 "..\..\Views\Images\ImageEditor.cshtml"
               Write(Html.Tooltip(MediaGlobalization.ImageEditor_Dialog_Description_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div class=\"bcms-content-titles\">");


            
            #line 145 "..\..\Views\Images\ImageEditor.cshtml"
                                                Write(MediaGlobalization.ImageEditor_Dialog_Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div class=\"bcms-textarea-box\">\r\n                    " +
"    ");


            
            #line 147 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.TextAreaFor(f => f.Description, new { @class = "bcms-editor-field-area", @id = "Description", @style = "width: 380px;", data_bind = "event: {change: onValueChange}" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        ");


            
            #line 148 "..\..\Views\Images\ImageEditor.cshtml"
                   Write(Html.BcmsValidationMessageFor(f => f.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");


            
            #line 153 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"bcms-media-tags-box-holder bcms-clearfix\" data-bind=\"with" +
": tags\">\r\n                ");


            
            #line 155 "..\..\Views\Images\ImageEditor.cshtml"
           Write(Html.Partial("~/Areas/bcms-root/Views/Tags/TagsTemplate.cshtml", tagsTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 157 "..\..\Views\Images\ImageEditor.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"bcms-media-reupload\" data-bind=\"click: reupload\">");


            
            #line 158 "..\..\Views\Images\ImageEditor.cshtml"
                                                                    Write(MediaGlobalization.ImageEditor_Dialog_Reupload_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");


            
            #line 159 "..\..\Views\Images\ImageEditor.cshtml"

            
            
            #line default
            #line hidden
            
            #line 160 "..\..\Views\Images\ImageEditor.cshtml"
       Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
            
            #line 160 "..\..\Views\Images\ImageEditor.cshtml"
                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
