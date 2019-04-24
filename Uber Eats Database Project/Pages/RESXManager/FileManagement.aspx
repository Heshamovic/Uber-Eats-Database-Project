<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Templates/RESXManager/RESXManagerGlobalTemplate.Master" ValidateRequest="false" CodeBehind="FileManagement.aspx.cs" Inherits="RESXManager.Presentation.Pages.FileManagement" %>
<%@ Register Src="~/Controls/RESXManager/ToolTabs.ascx" TagName="ToolTabs" TagPrefix="resx" %>
<%@ Register Src="~/Controls/RESXManager/FileManagement.ascx" TagName="FileManagement" TagPrefix="resx" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="server">    
    <resx:ToolTabs SubPage="FileManagement" runat="server" />
    <div class="resxManager-pnl-wrapper">
        <div class="resxManager-pnl-header">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <div class="resxManager-right resxManager-corner"><!-- --></div>
            <div class="resxManager-content"><!-- --></div>
        </div>
        <div class="resxManager-right-border">
            <resx:FileManagement runat="server" />
        </div>
        <asp:Label ID="lblUnlicensedVersion" CssClass="resxManager-unlicensed" runat="server" />
        <div class="resxManager-pnl-footer">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <div class="resxManager-right resxManager-corner"><!-- --></div>
        </div>
    </div>
</asp:Content>