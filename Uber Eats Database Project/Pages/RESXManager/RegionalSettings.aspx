<%@ Page Language="C#" MasterPageFile="~/Templates/RESXManager/RESXManagerGlobalTemplate.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="RegionalSettings.aspx.cs" Inherits="RESXManager.Presentation.Pages.RegionalSettings" %>
<%@ Register Src="~/Controls/RESXManager/ToolTabs.ascx" TagName="ToolTabs" TagPrefix="resx" %>
<%@ Register Src="~/Controls/RESXManager/RegionalSettings.ascx" TagName="RegionalSettings" TagPrefix="resx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" runat="server">    
    <resx:ToolTabs SubPage="RegionSettings" runat="server" />
    <div class="resxManager-pnl-wrapper">
        <div class="resxManager-pnl-header">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <div class="resxManager-right resxManager-corner"><!-- --></div>
            <div class="resxManager-content"><!-- --></div>
        </div>
        <div class="resxManager-right-border">    
            <resx:RegionalSettings runat="server" />
        </div>
        <asp:Label ID="lblUnlicensedVersion" CssClass="resxManager-unlicensed" runat="server" />
        <div class="resxManager-pnl-footer">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <div class="resxManager-right resxManager-corner"><!-- --></div>
        </div>
    </div>
</asp:Content>