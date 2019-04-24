<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LabelsSearchResult.ascx.cs" Inherits="RESXManager.Presentation.Controls.LabelsSearchResult" %>
<%@ Register Src="~/Controls/RESXManager/Labels/LabelsSearchResultItem.ascx" TagName="LabelsSearchResultItem" TagPrefix="resx" %>
<br />
<div class="resxManager-content-blocks">  
    <div class="resxManager-select-row">
        <div class="resxManager-row-wrapper">
            <asp:DropDownList ID="ddlLanguages" CssClass="resxManager-ddlist resxManager-size-middle" OnSelectedIndexChanged="DdlLanguages_SelectedIndexChanged" AutoPostBack="true" runat="server" />
            <asp:HiddenField ID="hfDdlLanguages" runat="server"/>
        
            <span class="resxManager-btn resxManager-check-spelling" style="display: none;">            
                <asp:Button ID="btnCheckSpelling" runat="server" CssClass="resxManager-check-textarea" meta:resourcekey="btnCheckSpelling" />            
            </span>
            <span class="resxManager-btn resxManager-check-spelling" style="display: none;">            
                <asp:Button ID="btnUnCheckSpelling" runat="server" CssClass="resxManager-uncheck-textarea" meta:resourcekey="btnUnCheckSpelling" />            
            </span>
        </div>
    </div>
    <asp:ListView ID="lvSearchResult" OnItemDataBound="LvSearchResult_ItemDataBound" ItemPlaceholderID="lvSearchResultItemPlaceHolder" runat="server">
        <LayoutTemplate>
            <br />
            <table width="95%" cellpadding="0" cellspacing="0" border="0">
                <asp:PlaceHolder ID="lvSearchResultItemPlaceHolder" runat="server" />
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <resx:LabelsSearchResultItem ID="ucLabelsSearchResultItem" OnRevertFile="UcLabelsSearchResultItem_RevertFile" OnTranslateFile="UcLabelsSearchResultItem_TranslateFile" runat="server" />                                                         
                </td>
            </tr>
        </ItemTemplate>
        <EmptyDataTemplate>
            <asp:Label ID="lblSearchResult" meta:resourcekey="lblSearchResult" runat="server" />
        </EmptyDataTemplate>
    </asp:ListView>         
</div>