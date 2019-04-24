<%@ Control Language="C#" EnableViewState="false" AutoEventWireup="true" CodeBehind="ToolTabs.ascx.cs" Inherits="RESXManager.Presentation.Controls.ToolTabs" %>
<div class="resxManager-tool-header">
    <ul class="resxManager-tool-tabs">
        <li id="cLabels" runat="server">
          <div class="resxManager-left resxManager-corner"><!-- --></div>  
          <asp:HyperLink ID="hlnkLabels" NavigateUrl="~/Pages/RESXManager/Editor.aspx" meta:resourcekey="hlnkLabels" runat="server" />
          <div class="resxManager-right resxManager-corner"><!-- --></div>  
        </li>
        <li id="cFileManagement" runat="server">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <asp:HyperLink ID="hlnkFileManagement" NavigateUrl="~/Pages/RESXManager/FileManagement.aspx" meta:resourcekey="hlnkFileManagement" runat="server" />
            <div class="resxManager-right resxManager-corner"><!-- --></div>
        </li>
        <li id="cRegionalSettings" runat="server">
            <div class="resxManager-left resxManager-corner"><!-- --></div>
            <asp:HyperLink ID="hlnkRegionalSettings" NavigateUrl="~/Pages/RESXManager/RegionalSettings.aspx" meta:resourcekey="hlnkRegionalSettings" runat="server" />
            <div class="resxManager-right resxManager-corner"><!-- --></div>
        </li>
    </ul>
</div>


<div class="resxManager-popup-overlay">
</div>
<div class="resxManager-popup-main resxManager-popup-block">
    <span class="resxManager-popup-left-shadow"></span><span class="resxManager-popup-bottom-shadow"></span>
    <span class="resxManager-popup-shadow-corner"></span>
    <div class="resxManager-popup-title">
        <h2> </h2>
        <span class="resxManager-popup-close"></span>
    </div>
    <div class="resxManager-popup-text">        
    </div>
</div>

<script type="text/javascript">
    //<![CDATA[

    $(document).ready(function () {
        bindMediumTrustPopup();
    });

    function bindMediumTrustPopup() {
        $('.resxManager-show-popup').click(function () {
            $('.resxManager-popup-block, .resxManager-popup-overlay').show();
        });
        $('.resxManager-popup-close, .resxManager-popup-overlay').click(function () {
            $('.resxManager-popup-block, .resxManager-popup-overlay').hide();
        });
    };

    function showPopup(title, text) {
        $('.resxManager-popup-block .resxManager-popup-title h2').html(title);
        $('.resxManager-popup-block .resxManager-popup-text').html(text);
        $('.resxManager-popup-block, .resxManager-popup-overlay').show();
    }

    //]]>
</script>