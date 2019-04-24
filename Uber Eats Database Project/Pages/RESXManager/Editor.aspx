<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Templates/RESXManager/RESXManagerGlobalTemplate.Master" ValidateRequest="false" CodeBehind="Editor.aspx.cs" Inherits="RESXManager.Presentation.Pages.Editor" %>
<%@ Register Src="~/Controls/RESXManager/ToolTabs.ascx" TagName="ToolTabs" TagPrefix="resx" %>
<%@ Register Src="~/Controls/RESXManager/Labels.ascx" TagName="Labels" TagPrefix="resx" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="server">    
    <resx:ToolTabs SubPage="Labels" runat="server" />
    <div class="resxManager-pnl-wrapper">
        <div class="resxManager-pnl-header">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <div class="resxManager-right resxManager-corner"><!-- --></div>
            <div class="resxManager-content"><!-- --></div>
        </div>
        <div class="resxManager-right-border">
            <resx:Labels runat="server" />
        </div>
        <asp:Label ID="lblUnlicensedVersion" CssClass="resxManager-unlicensed" runat="server" />
        <div class="resxManager-pnl-footer">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <div class="resxManager-right resxManager-corner"><!-- --></div>
        </div>
    </div>
</asp:Content>