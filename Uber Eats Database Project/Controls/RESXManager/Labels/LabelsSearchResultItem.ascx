<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LabelsSearchResultItem.ascx.cs" Inherits="RESXManager.Presentation.Controls.LabelsSearchResultItem" %>
<asp:ListView runat="server" ID="lvResourceItems" DataKeyNames="Name" OnItemDataBound="LvResourceItems_ItemDataBound" ItemPlaceholderID="lvResourceItemsItemPlaceHolder" 
    OnLayoutCreated="LvResourceItems_LayoutCreated">
    <LayoutTemplate>
        <table cellpadding="0" cellspacing="0" class="resxManager-table-common">
            <tbody>
                <tr>
                    <th colspan="2" class="resxManager-first">
                        <div class="resxManager-top">
                            <asp:Label ID="lblFileName" runat="server"><!----></asp:Label>
                            <asp:HiddenField ID="hfFullFileName" runat="server" />
                            <!---->
                        </div>
                    </th>
                    <th class="resxManager-last resxManager-empty">
                        <div class="resxManager-top"><!----></div>
                    </th>
                </tr>
                <asp:PlaceHolder id="lvResourceItemsItemPlaceHolder" runat="server"></asp:PlaceHolder>
            </tbody>
        </table>
    </LayoutTemplate>
    <ItemTemplate>
        <tr class='<%# (Container.DataItemIndex % 2 != 0)?"resxManager-styled":"" %>'>
            <td class="resxManager-first resxManager-img-cell">
                <div class="resxManager-top">
                    <asp:Image ID="imgIcon" ImageUrl="~/images/RESXManager/icone-undefined.png" runat="server" />
                    <!---->
                </div>                
            </td>
            <td>
                <asp:TextBox ID="txtValue" CssClass="resxManager-txtValue resxManager-expand" TextMode="MultiLine" runat="server"/>
                <%--<div class="resxManager-spellcheck-div" style="display: none;">
                    <asp:Literal ID="litSpellcheck" runat="server" /><!---->
                </div>--%>               
            </td>
            <td class="resxManager-last resxManager-img-cell">
                <div class="resxManager-top">
                    <div class="resxManager-bubbleInfo">
                        <div class="resxManager-trigger">
                            <asp:Image ID="imgComments" ImageUrl="~/images/RESXManager/comments-grey.png" runat="server"/>
                            <!---->
                        </div>
                        <table style="display: none;" class="resxManager-popup">
                            <tbody>
                                <tr>
                                    <td id="resxManager-topleft" class="resxManager-corner"><!-- --></td>
                                    <td class="resxManager-toppopup"><!-- --></td>
                                    <td id="resxManager-topright" class="resxManager-corner"><!-- --></td>
                                </tr>
                                <tr class="resxManager-bg-popup">
                                    <td class="resxManager-left"><!-- --></td>
                                    <td>
                                        <table class="resxManager-popup-contents">
                                            <tbody>
                                                <tr>
                                                    <td>                                                   
                                                        <asp:TextBox ID="txtComments" TextMode="MultiLine" CssClass="resxManager-txtComments" runat="server"/>
                                                        <%--<div class="resxManager-spellcheck-div" style="display: none;">
                                                            <asp:Literal ID="litCommentSpellCheck" runat="server" /><!---->
                                                        </div>--%>                                                            
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </td>
                                    <td class="resxManager-right"><!-- --></td>
                                </tr>
                                <tr>
                                    <td class="resxManager-corner" id="resxManager-bottomleft"><!-- --></td>
                                    <td><!-- --></td>
                                    <td id="resxManager-bottomright" class="resxManager-corner"><!-- --></td>
                                </tr>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <td class="resxManager-bottom" colspan="3">
                                        <img alt="popup tail" src="~/images/RESXManager/tooltip-arrow.gif" height="10" width="20" runat="server" />
                                        <!---->
                                    </td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <asp:Image ID="imgLastSaved" ImageUrl="~/images/RESXManager/snowflake.gif" Visible="false" runat="server"/>
                    <!---->
                </div>
            </td>
        </tr>
    </ItemTemplate>    
</asp:ListView>
<div>
    <asp:Image ID="imgSavedVersionsArrow" ImageUrl="~/images/RESXManager/arrow-up.png" AlternateText="arrow-up" runat="server" />
    <asp:Label ID="lblSavedVersions" runat="server" CssClass="resxManager-bottom-item-label" Font-Bold="true" meta:resourcekey="lblSavedVersions"
        onclick="toggleSavedVersions(this);" />
    <div id="pnlSavedVersions" class="resxManager-bottom-item-panel" style="display: none;">
        <br />
        <asp:DropDownList ID="ddlVersions" onchange="javascript:setRevertButtonsEnabled(this);" CssClass="resxManager-bottom-item-dropdown" DataTextField="DisplayName" DataValueField="FullPath" runat="server" />
        <br/><br/>
        <span class="resxManager-btn resxManager-margin-right-10">
            <asp:Button ID="btnRevert" OnClick="BtnRevert_Click" OnClientClick="javascript:return showRevertConfirmMessage();" meta:resourcekey="btnRevert" runat="server"/>    
        </span>
        <span class="resxManager-btn resxManager-margin-right-10">
            <input type="button" id="btnCancel" meta:resourcekey="btnCancel" onclick="toggleSavedVersions(this.parentNode.parentNode);" runat="server" />
        </span>
        <span class="resxManager-btn resxManager-margin-right-10">
            <asp:Button ID="btnDownload"  OnClientClick="DownloadFile(this); return false;" meta:resourcekey="btnDownload" ValidationGroup="Labels" CausesValidation="false" runat="server"/>
        </span>
    </div>
</div>
<asp:Panel ID="pnlAutoTranslate" CssClass="resxManager-pnl-auto-translate" runat="server">
    <asp:Image ID="imgAutoTranslateArrow" runat="server" ImageUrl="~/images/RESXManager/arrow-up.png" AlternateText="arrow-up" />
    <asp:Label ID="lblAutoTranslate" runat="server" CssClass="resxManager-bottom-item-label" Font-Bold="true" meta:resourcekey="lblAutoTranslate"
        onclick="toggleAutoTranslate(this);" />
    <div id="pnlAutoTranslateInner" class="resxManager-bottom-item-panel" style="display: none;">
        <br />
        <h3 class="resxManager-inner-title"><asp:Literal ID="litAutoTranslateText" meta:resourcekey="litAutoTranslateText" runat="server" /></h3>
        <asp:DropDownList ID="ddlTranslateLanguages" CssClass="resxManager-bottom-item-dropdown" runat="server" />
        <br/><br/>
        <span class="resxManager-btn resxManager-margin-right-10">
            <asp:Button ID="btnTranslate" OnClick="BtnTranslate_Click" UseSubmitBehavior="false" meta:resourcekey="btnTranslate" runat="server"/>    
        </span>
        <span class="resxManager-btn resxManager-margin-right-10">
            <input type="button" id="btnCancelTranslate" meta:resourcekey="btnCancelTranslate" onclick="toggleAutoTranslate(this.parentNode.parentNode);" runat="server" />
        </span>
    </div>
</asp:Panel>