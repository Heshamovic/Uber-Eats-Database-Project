<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchByBrowsing.ascx.cs" Inherits="RESXManager.Presentation.Controls.SearchByBrowsing" %>

<asp:Panel ID="pnlDescriptionBlock" runat="server">
    <h2><asp:Literal EnableViewState="false" meta:resourcekey="ltrTitle" runat="server" /></h2>
    <div class="resxManager-visual"><span><img src="~/images/RESXManager/icon-browse.png" alt="browse" runat="server" /></span></div>
    <div class="resxManager-text resxManager-text-content"><asp:Literal EnableViewState="false" meta:resourcekey="ltrByBrowsingDesctiption" runat="server" /></div>
</asp:Panel>
<asp:Panel ID="pnlFormBlock" runat="server">
    <div class="resxManager-box-gray resxManager-box-search">
        
            <div class="resxManager-top"><!-- --></div>
            <div class="resxManager-box-content">
                <div class="resxManager-inner-padding">
                <div class="resxManager-left">                    
                    <span class="resxManager-left resxManager-small-margin-right">
                        <asp:DropDownList ID="ddlFolder" DataSourceID="oDSourceFolders" OnSelectedIndexChanged="DdlFolder_SelectedIndexChanged" 
                            DataTextField="DisplayName" DataValueField="FullPath" AutoPostBack="True" CssClass="resxManager-ddlFolderFile" 
                            meta:resourcekey="ddlFolder" runat="server" />
                        <asp:HiddenField ID="hfDdlFolder" runat="server" /> 
                    </span>                
                </div>
                <%--div class="resxManager-left">
                    <div class="resxManager-small-padding-bottom"><asp:Literal ID="Literal4" EnableViewState="false" meta:resourcekey="ltrFile" runat="server" /></div>
                    <span class="resxManager-left">
                        <asp:DropDownList ID="ddlFile"  DataSourceID="oDSourceFiles" style="width:140px;" OnSelectedIndexChanged="DdlFile_SelectedIndexChanged" 
                            DataTextField="DisplayName" DataValueField="FullPath" AutoPostBack="True" CssClass="resxManager-ddlFolderFile" meta:resourcekey="ddlFile" runat="server" />                     
                        <asp:HiddenField ID="hfDdlFile" runat="server" />
                    </span>                
                </div--%>
                <div class="resxManager-left">                    
                    <span class="resxManager-left">
                        <asp:DropDownList ID="ddlBrowseCulture" CssClass="resxManager-ddlist resxManager-size-middle" OnSelectedIndexChanged="ddlBrowseCulture_SelectedIndexChanged" AutoPostBack="true" meta:resourcekey="ddlBrowseCulture" runat="server" />
                        <asp:HiddenField ID="hfDdlBrowseCulture" runat="server" />
                    </span>
                </div>
            </div>
                </div>
            <div class="resxManager-bottom"><!-- --></div>
        
    </div>
</asp:Panel>
<asp:ObjectDataSource ID="oDSourceFolders" TypeName="ResxManager.Presentation.Controls.SearchByBrowsing" OnObjectCreating="AllObjectDataSource_ObjectCreating" 
    SelectMethod="GetFoldersList" runat="server" />
<%--asp:ObjectDataSource ID="oDSourceFiles" TypeName="ResxManager.Presentation.Controls.SearchByBrowsing" OnObjectCreating="AllObjectDataSource_ObjectCreating"
    SelectMethod="GetFilesList" runat="server">
    <SelectParameters>
        <asp:ControlParameter ControlID="ddlFolder" PropertyName="SelectedValue" Name="folder" Type="String" />
    </SelectParameters>    
</asp:ObjectDataSource--%>
