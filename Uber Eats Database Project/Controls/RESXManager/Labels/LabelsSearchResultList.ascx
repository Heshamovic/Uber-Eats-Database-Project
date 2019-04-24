<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LabelsSearchResultList.ascx.cs" Inherits="RESXManager.Presentation.Controls.LabelsSearchResultList" %>
<%@ Register Src="~/controls/RESXManager/Labels/LabelsSearchResult.ascx" TagName="LabelsSearchResult" TagPrefix="resx" %>

<asp:Panel ID="pnlLabelsResult" runat="server" Style="display: none;">    
    <asp:Panel ID="pnlLabelsListContent" runat="server">
    <div class="resxManager-sub-tabs" id="divSubTabs" runat="server">
        <div class="resxManager-layout1">
            <div class="resxManager-top">
            </div>
            <div class="resxManager-layout2">
                <h3>
                    <asp:Literal ID="ltrLabelsTitle" meta:resourcekey="ltrLabelsTitle" runat="server"/>
                </h3>
                <ul>
                    <li>                        
                        <asp:LinkButton ID="lbtnSingleView" CssClass="resxManager-active" OnClick="LbtnSingleView_Click" meta:resourcekey="lbtnSingleView"
                            runat="server" />
                    </li>
                    <li>
                        <asp:LinkButton ID="lbtnMultiLanguageView" OnClick="LbtnMultiLanguageView_Click" meta:resourcekey="lbtnMultiLanguageView"
                            runat="server" />
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <asp:ListView ID="lvSearchResultList" OnItemDataBound="LvSearchResultList_ItemDataBound"
          GroupPlaceholderID="lvSearchResultListGroupPlaceHolder" ItemPlaceholderID="lvSearchResultListItemPlaceHolder" GroupItemCount="2" runat="server">
        <LayoutTemplate>
            <table width="100%" cellpadding="0" cellspacing="0" border="0">
                <asp:PlaceHolder ID="lvSearchResultListGroupPlaceHolder" runat="server" />
            </table>
        </LayoutTemplate>
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder ID="lvSearchResultListItemPlaceHolder" runat="server" />
            </tr>
        </GroupTemplate>
        <ItemTemplate>
            <td class="resxManager-labels-search-result">
                <resx:LabelsSearchResult ID="ucLabelsSearchResult" OnSelectedCultureChanged="UcLabelsSearchResult_SelectedCultureChanged"
                                 OnRevertFile="UcLabelsSearchResult_RevertFile" runat="server"></resx:LabelsSearchResult>                               
            </td>            
        </ItemTemplate>
        <EmptyDataTemplate>
            <asp:Label ID="lblSearchResultListEmpty" meta:resourcekey="lblSearchResultListEmpty" runat="server" />
        </EmptyDataTemplate>
    </asp:ListView>          
    <div class="resxManager-separator">
    </div>
    <div class="resxManager-saving-box">
        <span class="resxManager-btn">
            <asp:Button ID="btnSave" meta:resourcekey="btnSave" UseSubmitBehavior="false" runat="server" OnClick="BtnSave_Click" />
        </span>
    </div>
    <asp:TextBox ID="txtHiddenMessage" style="display: none;" AutoPostBack="false" CssClass="resxManager-hidden-save-message" OnTextChanged="txtHiddenMessage_TextChanged" TextMode="SingleLine" runat="server" />
    <div class="resxManager-clear"><!----></div>
    <asp:Panel ID="pnlMsgLabelsSave" runat="server" EnableViewState="false" Visible="false"
        meta:resourcekey="pnlMsgLabelsSave">
        <asp:MultiView ID="MultiViewMsgLabelsSave" runat="server">
            <asp:View ID="View1Labels" runat="server">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/RESXManager/icone-tick.png" meta:resourcekey="imgResult" />
            </asp:View>
            <asp:View ID="View2Labels" runat="server">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/RESXManager/exclamation.png" meta:resourcekey="imgExclamation" />
            </asp:View>
        </asp:MultiView>
        <asp:Label ID="lblMsgLabelsSave" CssClass="resxManager-lblMsg" meta:resourcekey="lblMsgLabelsSave"
            runat="server" />
    </asp:Panel>
    </asp:Panel>   
        
</asp:Panel>                     
