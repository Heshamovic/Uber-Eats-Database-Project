<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FileManagement.ascx.cs" Inherits="RESXManager.Presentation.Controls.FileManagement" %>
 
<script type="text/javascript">
    function toggleLabelDisplayImage(e) {
        var img = $(e).children()[0];
        if (img.src.lastIndexOf("arrow-hor.gif") != -1) {
            img.src = img.src.replace("arrow-hor.gif", "arrow-vert.gif");
            $(e).parent().parent().parent().after('<tr class="resxManager-spin"><td class="resxManager-first resxManager-img-cell"></td><td class="resxManager-non-border" colspan="3"><img src="~/images/resxmanager/loading.gif" class="resxManager-padding-right-10" runat="server" /><%= GetLocalResourceObject("LoadingContentMessage") %></td></tr>');
        }
        else {
            img.src = img.src.replace("arrow-vert.gif", "arrow-hor.gif");
            $(e).parent().parent().parent().next().remove();            
        }
    }

    Sys.Application.add_load(appLoad);

    function appLoad() {
        var txtUploadPath = $('[id$="txtUploadPath"]').get(0);
        setUploadPathText(txtUploadPath);
        $("[id$='lbtnClosedArrow']").click(function(event) {
            event.stopPropagation();
        });
        $("[id$='lbtnOpenArrow']").click(function(event) {
            event.stopPropagation();
        });
    }

    function setCheckboxDisplayLabel(e) {
        var elem = $(e).siblings()[0];
        if (elem.innerHTML == '<%= GetLocalResourceObject("True") %>') {
            elem.innerHTML = '<%= GetLocalResourceObject("False") %>';
        }
        else {
            elem.innerHTML = '<%= GetLocalResourceObject("True") %>';
        }
    }

</script>

<div id="resxManager-wrapper">   
    <ul class="resxManager-file-management resxManager-tab-nav">
        <li><asp:HyperLink ID="hlnkUpload" class="resxManager-pointer" onclick="toggleBlocksFileManagement(0);" runat="server"><span><!----></span><asp:Literal runat="server" meta:resourcekey="hlnkUpload" /></asp:HyperLink></li>
        <li><asp:HyperLink ID="hlnkDownload" class="resxManager-pointer" onclick="toggleBlocksFileManagement(1);" runat="server"><span><!----></span><asp:Literal runat="server" meta:resourcekey="hlnkDownload" /></asp:HyperLink></li>
        <li><asp:HyperLink ID="hlnkLabelDisplay" class="resxManager-pointer" onclick="toggleBlocksFileManagement(2);" runat="server"><span><!----></span><asp:Literal runat="server" meta:resourcekey="hlnkLabelDisplay" /></asp:HyperLink></li>
    </ul>
    <div class="resxManager-main resxManager-main-colored">
        <div class="resxManager-rt">
            <div class="resxManager-rb">
                <div class="resxManager-lb">
                    <asp:Panel ID="Panel1" CssClass="resxManager-columns-row resxManager-upperFileManagementMenu" runat="server">
                        <div class="resxManager-column resxManager-column-height">
                            <h2><asp:Literal EnableViewState="false" meta:resourcekey="hlnkUpload" runat="server" /></h2>
                            <div id="resxManager-div2" class="resxManager-visual resxManager-pointer" onclick="toggleBlocksFileManagement(0);">
                                <span><img src="~/images/resxmanager/icon-upload.png" class="resxManager-upload-ico" alt="" runat="server" /></span>
                            </div>
                            <div class="resxManager-text"><asp:Literal EnableViewState="false" meta:resourcekey="ltrUploadText" runat="server"/></div>
                            <div class="resxManager-more">
                                <a href="#" onclick="toggleBlocksFileManagement(0);">
                                    <span>&raquo;</span><asp:Literal EnableViewState="false" meta:resourcekey="hlnkUpload" runat="server" />
                                </a>
                            </div>
                        </div>
                        <div class="resxManager-column resxManager-column-height">
                            <h2><asp:Literal EnableViewState="false" meta:resourcekey="hlnkDownload" runat="server" /></h2>
                            <div id="resxManager-div1" class="resxManager-visual resxManager-pointer" onclick="toggleBlocksFileManagement(1);">
                                <span><img src="~/images/resxmanager/icon-download.png" alt="" runat="server" /></span>
                            </div>
                            <div class="resxManager-text"><asp:Literal EnableViewState="false" meta:resourcekey="ltrDownloadText" runat="server"/></div>
                            <div class="resxManager-more">
                                <a href="#" onclick="toggleBlocksFileManagement(1);">
                                    <span>&raquo;</span><asp:Literal EnableViewState="false" meta:resourcekey="hlnkDownload" runat="server" />
                                </a>
                            </div>
                        </div>
                        <div class="resxManager-column resxManager-column-height">
                            <h2><asp:Literal meta:resourcekey="hlnkLabelDisplay" runat="server" /></h2>
                            <div class="resxManager-visual resxManager-pointer" onclick="toggleBlocksFileManagement(2);">
                                <span><img src="~/images/resxmanager/icon-label.png" alt="" runat="server" /></span>
                            </div>
                            <div class="resxManager-text">
                                <asp:Literal ID="ltrLabelDisplayText" meta:resourcekey="ltrLabelDisplayText" runat="server"/>
                            </div>
                            <div class="resxManager-more">
                                <a href="#" onclick="toggleBlocksFileManagement(2);">
                                    <span>&raquo;</span><asp:Literal meta:resourcekey="hlnkLabelDisplay" runat="server" />
                                </a>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="resxManager-columns-row resxManager-file-management">
                        <div class="resxManager-column resxManager-column-height" style="display:none;">
                            <h2><asp:Literal EnableViewState="false" meta:resourcekey="hlnkUpload" runat="server" /></h2>
                            <div class="resxManager-visual"><span><img src="~/images/resxmanager/icon-upload.png" alt="" runat="server" /></span></div>
                            <div class="resxManager-text">
                                <asp:Literal EnableViewState="false" meta:resourcekey="ltrUploadText" runat="server"/>
                            </div>
                        </div>
                        <div class="resxManager-column-right resxManager-column-height" style="display:none;">
                            <div class="resxManager-text">
                                <asp:ValidationSummary ShowMessageBox="true" ShowSummary="false" runat="server" ID="vsUpload"
                                    ValidationGroup="UploadResource" CssClass="resxManager-validation" DisplayMode="BulletList" meta:resourcekey="vsUpload" />
                                <asp:Literal EnableViewState="false" meta:resourcekey="ltrUploadTextOpen" runat="server"/>
                                <br /><br />
                                <asp:Literal EnableViewState="false" meta:resourcekey="ltrUploadPath" runat="server"/>
                                <br/><br/>
                                <i><asp:Label ID="lblUploadPath" CssClass="resxManager-upload-path" runat="server" /></i>
                                <br/><br/>
                            </div>
                            <div>
                                <h3>
                                    <b> 
                                        <asp:Image ID="imgAdvancedOptionsArrow" EnableViewState="false" runat="server" ImageUrl="~/images/resxmanager/arrow-hor-big.png" />                          
                                        <asp:Label EnableViewState="false" runat="server" CssClass="resxManager-pointer" meta:resourcekey="lblAdvancedOptions" onclick="toggleAdvancedOptions(this);"/>
                                    </b>
                                </h3>
                                <div id="pnlAdvancedOptions" class="resxManager-padding-left-20" style="display:none;">
                                    <br/>
                                    <span><b><asp:Literal EnableViewState="false" meta:resourcekey="ltrUploadOptions" runat="server"/></b></span>
                                    <br />
                                    <br />
                                    <table border="0">
                                    <tbody>
                                        <tr>
                                            <td valign="top">
                                                <asp:RadioButton ID="rbLeaveExisting" Checked="true" GroupName="ReplaceLabels" meta:resourcekey="rbLeaveExisting" runat="server"/>
                                            </td>
                                            <td>
                                                <div class="resxManager-upload-option">
                                                <asp:Literal ID="litLeaveExisting" meta:resourcekey="litLeaveExisting" runat="server" />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td valign="top">
                                                <asp:RadioButton ID="rbReplaceExisting" GroupName="ReplaceLabels" meta:resourcekey="rbReplaceExisting" runat="server"/>
                                            </td>
                                            <td>
                                                <div class="resxManager-upload-option">
                                                <asp:Literal ID="litReplaceExisting" meta:resourcekey="litReplaceExisting" runat="server" />
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <br />
                                                <br />
                                            </td>                                          
                                        </tr>
                                        <tr> 
                                            <td>                               
                                                <input type="checkbox" onclick="$('#pnlCustomPath').toggle();" />
                                                <span class="resxManager-small-padding-left">
                                                    <asp:Literal ID="ltrCustomPath" meta:resourcekey="ltrCustomPath" runat="server"/>
                                                </span> 
                                            </td>
                                            <td>
                                                <div class="resxManager-upload-option">
                                                <asp:Literal ID="ltrCustomPathDescription" meta:resourcekey="ltrCustomPathDescription" runat="server"/>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">                                                                   
                                                <div id="pnlCustomPath" class="resxManager-small-padding-top" style="display:none;">                               
                                                    <asp:TextBox ID="txtUploadPath" CssClass="resxManager-field" runat="server" Width="400" Height="25" onchange="setUploadPathText(this);" onkeyup="setUploadPathText(this);"/>
                                                    <asp:RequiredFieldValidator ID="rqvldRootPath" ControlToValidate="txtUploadPath" 
                                                        ValidationGroup="UploadResource" meta:resourcekey="rqvldRootPath" runat="server">*</asp:RequiredFieldValidator> 
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                    </table>
                                </div>
                            </div>
                            <br />
                                <div class="resxManager-left">
                                <asp:Literal ID="litUploadText" meta:resourcekey="litUploadText" runat="server" />
                                <asp:RequiredFieldValidator ID="rqvldUploadFile" ControlToValidate="fuUploadFile"
                                    ValidationGroup="UploadResource" Display="Dynamic" meta:resourcekey="rqvldUploadFile"
                                    runat="server">*</asp:RequiredFieldValidator>
                                <asp:CustomValidator ID="cvldUploadFile" ControlToValidate="fuUploadFile" ClientValidationFunction="validateExtension"
                                    OnServerValidate="CvldUploadFile_ServerValidate" ValidationGroup="UploadResource"
                                    Display="Dynamic" meta:resourcekey="cvldUploadFile" runat="server">*</asp:CustomValidator>
                                </div>
                                <br />
                                <asp:FileUpload ID="fuUploadFile" size="64" Height="25" runat="server" CssClass="resxManager-left" />
                            <br />        
                            <br />
                            <br />                            
                            <table border="0">
                            <tbody>
                            <tr>
                                <td>
                                <span class="resxManager-btn">
                                    <asp:Button ID="btnUpload" meta:resourcekey="btnUpload" OnClick="BtnUpload_Click" ValidationGroup="UploadResource" runat="server" />                            
                                </span>
                                </td>
                                <td>
                                    <div class="resxManager-upload-option">
                                    <asp:Literal ID="litUploadFileDescription" meta:resourcekey="litUploadFileDescription" runat="server" />
                                    </div>
                                </td>
                            </tr>
                            </tbody>
                            </table>
                            <br />
                            <br />
                            <asp:Panel ID="pnlMsgUpload" runat="server" EnableViewState="false" Visible="false" >
                                <asp:MultiView ID="MultiViewMsgUpload" runat="server">
                                    <asp:View ID="View1" runat="server">
                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/resxmanager/icone-tick.png" meta:resourcekey="imgResult" />
                                    </asp:View>
                                    <asp:View ID="View2" runat="server">
                                        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/resxmanager/exclamation.png"
                                            meta:resourcekey="imgExclamation" />
                                    </asp:View>
                                </asp:MultiView>
                                <asp:Label ID="lblMsgUpload" CssClass="resxManager-lblMsg" runat="server" />
                            </asp:Panel>
                        </div>
                        <div class="resxManager-column resxManager-column-height" style="display:none;">
                            <h2><asp:Literal EnableViewState="false" meta:resourcekey="hlnkDownload" runat="server" /></h2>
                            <div class="resxManager-visual"><span><img src="~/images/resxmanager/icon-download.png" alt="" runat="server" /></span></div>
                            <div class="resxManager-text"><asp:Literal EnableViewState="false" meta:resourcekey="ltrDownloadText" runat="server"/></div>
                        </div>
                        <div class="resxManager-column-right resxManager-column-height" style="display:none;">
                            <asp:Literal ID="ltrDownloadTextOpen" meta:resourcekey="ltrDownloadTextOpen" runat="server"/>
                            <br/><br/>
                            <span class="resxManager-btn">
                                <asp:Button ID="btnDownload" meta:resourcekey="btnDownload" OnClick="BtnDownload_Click" ValidationGroup="ResourceLoader" CausesValidation="false" runat="server" />
                            </span>                            
                        </div>
                        <div class="resxManager-column resxManager-column-height" style="display:none;">
                            <h2><asp:Literal EnableViewState="false" meta:resourcekey="hlnkLabelDisplay" runat="server" /></h2>
                            <div class="resxManager-visual">
                                <span><img src="~/images/resxmanager/icon-label.png" alt="" runat="server" /></span>
                            </div>
                            <div class="resxManager-text">
                                <asp:Literal EnableViewState="false" meta:resourcekey="ltrLabelDisplayTextOpen" runat="server" />
                                <br /><br />
                                <asp:Literal EnableViewState="false" meta:resourcekey="ltrLabelDisplayTextOpen2" runat="server"/>
                            </div>
                        </div>
                        <div class="resxManager-column-right resxManager-column-height" style="display:none;">
                            <asp:UpdatePanel UpdateMode="Conditional" runat="server">
                            <ContentTemplate>
                                <asp:ObjectDataSource ID="odsLabels" runat="server" TypeName="RESXManager.Core.ResXFactory" EnablePaging="false" SelectMethod="GetResXFilesInFolderWithDefaultCulture" OnSelecting="OdsLabels_Selecting">
                                    <SelectParameters>
                                        <asp:Parameter Name="folderPath" Type="String"/>
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                <asp:ListView runat="server" ID="lvLabels" DataKeyNames="FullPath" DataSourceID="odsLabels" ItemPlaceholderID="lvLabelsItemPlaceHolder" 
                                    OnItemDataBound="LvLabels_ItemDataBound" OnItemCommand="LvLabels_ItemCommand">                                                        
                                    <LayoutTemplate>                                                               
                                        <table cellpadding="0" cellspacing="0" width="100%" class="resxManager-table-common">
                                            <tbody>
                                            <tr>                           
                                                <th colspan="2" class="resxManager-first">
                                                    <div class="resxManager-top">
                                                        <asp:Literal ID="ltrFileAndLabel" meta:resourcekey="ltrFileAndLabel" runat="server"/>
                                                    </div>
                                                </th>
                                                <th style="display:none;">
                                                    <!---->
                                                </th>
                                                <th class="resxManager-last">
                                                    <div class="resxManager-top">
                                                        <asp:Literal ID="ltrDisplayForEditing" meta:resourcekey="ltrDisplayForEditing" runat="server"/>
                                                    </div>
                                                </th>
                                            </tr>                                        
                                            <asp:PlaceHolder id="lvLabelsItemPlaceHolder" runat="server"></asp:PlaceHolder>                                       
                                            </tbody>
                                        </table>
                                    </LayoutTemplate>
                                    <ItemTemplate>                                
                                        <tr class='<%# (Container.DataItemIndex % 2 != 0)?"resxManager-styled":"" %> resxManager-pointer' onclick="triggerUnderlyingLink(this);">
                                            <td class="resxManager-first resxManager-img-cell" runat="server" id="imgCell">
                                                <div class="resxManager-top">
                                                    <asp:LinkButton ID="lbtnClosedArrow" CommandName="ShowDetails" OnClientClick="toggleLabelDisplayImage(this);" runat="server">                                        
                                                        <asp:Image ID="imgClosedArrow" ImageUrl="~/images/resxmanager/arrow-hor.gif" runat="server" />                                        
                                                    </asp:LinkButton>
                                                    <asp:LinkButton ID="lbtnOpenArrow" CommandName="HideDetails" Visible="false" runat="server">                                                                               
                                                        <asp:Image ID="imgOpenArrow" ImageUrl="~/images/resxmanager/arrow-vert.gif" runat="server" />                                        
                                                    </asp:LinkButton>
                                                </div>
                                            </td>
                                            <td  class="resxManager-non-border">
                                                <asp:Image ID="imgFile" CssClass="resxManager-icon-file" ImageUrl="~/images/resxmanager/icon-file.gif" runat="server" />
                                                <asp:Label ID="lblName" runat="server" />
                                            </td>
                                            <td class="resxManager-col-100" style="display:none;">
                                                <asp:Literal ID="ltrUsed" runat="server" />
                                                <!---->
                                            </td>
                                            <td class="resxManager-last resxManager-col-130">
                                                <div class="resxManager-top">
                                                    <!---->
                                                </div>
                                            </td>
                                        </tr>
                                        <asp:ObjectDataSource ID="odsLabelsDetails" runat="server" TypeName="RESXManager.Core.ResXFactory"
                                            EnablePaging="false" SelectMethod="ReadResX">
                                            <SelectParameters>
                                                <asp:Parameter Name="filename" Type="String" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                        <asp:ListView ID="lvLabelsDetails" DataKeyNames="Name" runat="server" 
                                                  ItemPlaceholderID="lvLabelsDetailsItemPlaceHolder"  OnItemDataBound="LvLabelsDetails_ItemDataBound">
                                            <LayoutTemplate>                                    
                                                <asp:PlaceHolder id="lvLabelsDetailsItemPlaceHolder" runat="server"></asp:PlaceHolder>                                    
                                            </LayoutTemplate>
                                            <ItemTemplate>
                                                <tr id="Tr1" runat="server">
                                                    <td class="resxManager-first resxManager-img-cell"> 
                                                        <div class="resxManager-top"><!---->
                                                        </div>                                       
                                                    </td>
                                                    <td class="resxManager-non-border resxManager-level-2">
                                                        <asp:Image ID="imgResource" ImageUrl="~/images/resxmanager/icon-label-min.gif" CssClass="resxManager-icon-label-min" runat="server" />
                                                        <asp:Label ID="lblName" runat="server" />
                                                    </td>
                                                    <td class="resxManager-col-100" style="display:none;">
                                                        <asp:Literal ID="ltrUsed" runat="server" />
                                                        <!---->
                                                    </td>
                                                    <td class="resxManager-last resxManager-col-130">
                                                        <div class="resxManager-top resxManager-padding-left-10"><!---->
                                                            <asp:CheckBox ID="chbDisplayDetails" onclick="setCheckboxDisplayLabel(this);" runat="server" />
                                                            <asp:Label ID="lblDisplayDetails" runat="server" />
                                                        </div>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>  
                                    </ItemTemplate>                                
                                </asp:ListView>
                                <div class="resxManager-separator"><!-- --></div>
                                <div class="resxManager-saving-box">
                                    <span class="resxManager-btn">
                                        <asp:Button ID="btnSave" meta:resourcekey="btnSave" runat="server" OnClick="BtnSave_Click" OnClientClick="resetAlternativeRowStyle();" />                                
                                    </span>
                                </div>
                                <asp:Panel ID="pnlMsgLabelsDisplay" runat="server" EnableViewState="false" Visible="false" >
                                    <asp:MultiView ID="MultiViewMsgLabelsDisplay" runat="server">
                                        <asp:View ID="View3" runat="server">
                                            <asp:Image ID="imgResult" runat="server" ImageUrl="~/images/resxmanager/icone-tick.png" meta:resourcekey="imgResult" />
                                        </asp:View>
                                        <asp:View ID="View4" runat="server">
                                            <asp:Image ID="imgExclamation" runat="server" ImageUrl="~/images/resxmanager/exclamation.png"
                                                meta:resourcekey="imgExclamation" />
                                        </asp:View>
                                    </asp:MultiView>
                                    <asp:Label ID="lblMsgLabelsDisplay" CssClass="resxManager-lblMsg" runat="server" />
                                </asp:Panel>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>