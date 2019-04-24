<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchByText.ascx.cs" Inherits="RESXManager.Presentation.Controls.SearchByText" %>
<script type="text/javascript">

    function showTextLoadingImage() {
        if (Page_ClientValidate("SearchByText")) {
            $('[id$="imgTextLoading"]').css("visibility", "visible");
            
        }
        else {
            return false;
        }
    }

    function hideTextLoadingImage() {
        $('[id$="imgTextLoading"]').css("visibility", "hidden");
    }

    var searchTextOnEnter = function(event) {
        if (event.keyCode == 13) {
            $('.resxManager-btnTextSearch').focus().click();
            return false;
        }
    };

    function toggleAdvancedSearch(e) {
        $('[id$="pnlAdvancedSearch"]').toggle();
        $('[id$="hfAdvancedSearch"]').val($('[id$="pnlAdvancedSearch"]').css("display"));
        var parent = $(e).parent();
        var img = parent.find('[id$="imgAdvancedSearchArrow"]').get(0);        
        if (e.firstChild.data.lastIndexOf('<%= GetLocalResourceObject("lblAdvancedSearch.Text").ToString() %>') != -1) {
            e.firstChild.data = e.firstChild.data.replace('<%= GetLocalResourceObject("lblAdvancedSearch.Text").ToString() %>', '<%= GetLocalResourceObject("lblAdvancedSearch.CloseText").ToString() %>');
            img.src = img.src.replace("arrow-up.png", "arrow-down.png");
        }
        else {
            e.firstChild.data = e.firstChild.data.replace('<%= GetLocalResourceObject("lblAdvancedSearch.CloseText").ToString() %>', '<%= GetLocalResourceObject("lblAdvancedSearch.Text").ToString() %>');
            img.src = img.src.replace("arrow-down.png", "arrow-up.png");
        }
    }

    function toggleReplaceWithEnabled(element) {
        var baseName = element.id.substr(0, element.id.lastIndexOf("_") + 1);        
        var txtReplaceWith = $("#" + baseName + "txtReplaceWith");
        if (element.checked) {
            txtReplaceWith.removeAttr('disabled');
            txtReplaceWith.css("background-color", "");
        }
        else {
            txtReplaceWith.attr('disabled', 'disabled');
            txtReplaceWith.css("background-color", "#EDEDED");
        }
    }

    function proceedReplacePrompt(count) {
        if (confirm('<%= GetLocalResourceObject("ConfirmReplacementMessage").ToString() %>'.replace('##count##', count))) {
            $('[id$="hfFlagProceedReplace"]').val("proceed");
            $('[id$="btnSearch"]').click();
        }
        else {            
            setTimeout(function () { hideLoadingPanel(); }, 1000);
        }
    }

 
</script>
<asp:Panel ID="pnlDescriptionBlock" runat="server">
    <h2><asp:Literal ID="Literal1" EnableViewState="false" meta:resourcekey="ltrTitle" runat="server" /></h2>
    <div class="resxManager-visual"><span><img src="~/images/RESXManager/icon-search.png" alt="search" width="75" height="77" runat="server" /></span></div>
    <div class="resxManager-text resxManager-text-content"><asp:Literal ID="Literal2" EnableViewState="false" meta:resourcekey="ltrByTextDescription" runat="server" /></div>
</asp:Panel>
<asp:Panel ID="pnlFormBlock" runat="server">
    <div class="resxManager-box-gray resxManager-box-search">
        <div class="resxManager-top"><!-- --></div>
        <div class="resxManager-box-content">  
            <div class="resxManager-inner-padding">          
                <span class="resxManager-txt"> 
                    <span>
                        <asp:TextBox ID="txtSearch" CssClass="resxManager-txtSearch" onkeydown="return searchTextOnEnter(event);" runat="server" meta:resourcekey="txtSearch" />                
                    </span>
                </span>            
                <asp:RequiredFieldValidator ID="rqvldText" ControlToValidate="txtSearch" ValidationGroup="SearchByText" Display="None" meta:resourcekey="rqvldText" runat="server"  />
                <asp:ValidationSummary ID="vldsumSearchByText" ValidationGroup="SearchByText" ShowMessageBox="true" ShowSummary="false" runat="server" />
                <span class="resxManager-btn">
                    <asp:Button ID="btnSearch" CssClass="resxManager-btnTextSearch resxManager-font11" meta:resourcekey="btnSearch" ValidationGroup="SearchByText" 
                        OnClientClick="return showTextLoadingImage();" OnClick="BtnSearch_Click" runat="server" />
                </span>
                <br />
                <br />
                <div>
                    <asp:Image ID="imgAdvancedSearchArrow" ImageUrl="~/images/RESXManager/arrow-up.png" AlternateText="arrow-up" runat="server" />
                    <asp:HyperLink ID="hlAdvancedSearch" Font-Bold="true" EnableViewState="false" CssClass="resxManager-pointer" runat="server" onclick="toggleAdvancedSearch(this);"/>                              
                    <asp:Panel ID="pnlAdvancedSearch" runat="server">
                    <asp:HiddenField ID="hfAdvancedSearch" runat="server" />
                        <table border="0" class="resxManager-advanced-search">
                            <tbody>
                                <tr>
                                    <td valign="top">
                                        <span class="resxManager-small-padding-right">
                                            <asp:CheckBox ID="chkbxMatchCase" runat="server" />
                                        </span>
                                        <asp:Label ID="lblMatchCase" AssociatedControlID="chkbxMatchCase"  meta:resourcekey="lblMatchCase" runat="server" />
                                    </td>
                                </tr>                            
                                <tr>
                                    <td valign="top" class="resxManager-small-padding-top">
                                        <span class="resxManager-small-padding-top resxManager-small-padding-right">
                                            <input type="checkbox" id="chkbxReplaceWith" runat="server" onclick="toggleReplaceWithEnabled(this);" />
                                        </span>
                                        <asp:Label ID="lblReplaceWith" AssociatedControlID="txtReplaceWith" class="resxManager-small-padding-top resxManager-small-padding-right" meta:resourcekey="lblReplaceWith" runat="server" />
                                        <span class="resxManager-txt"> 
                                            <span>
                                                <asp:TextBox ID="txtReplaceWith" CssClass="resxManager-txtSearch" runat="server" />
                                            </span>
                                        </span>
                                        <asp:HiddenField ID="hfFlagProceedReplace" runat="server" />
                                    </td>
                                </tr>
                                <asp:PlaceHolder ID="phTextCulture" runat="server">
                                    <tr>
                                        <td valign="top" class="resxManager-small-padding-top">
                                            <asp:Label ID="lblTextCulture" meta:resourcekey="lblTextCulture" runat="server" />
                                            <asp:DropDownList ID="ddlTextCulture" CssClass="resxManager-ddlist resxManager-size-middle" runat="server" meta:resourcekey="ddlTextCulture" />  
                                        </td>
                                    </tr>
                                </asp:PlaceHolder>
                                <tr>
                                    <td valign="top" class="resxManager-small-padding-top">
                                        <asp:Label ID="lblControlType" meta:resourcekey="lblControlType" runat="server"/>
                                        <asp:DropDownList ID="ddlControlType" CssClass="resxManager-ddlist resxManager-size-middle" runat="server" meta:resourcekey="ddlControlType" /> 
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </asp:Panel>
                </div>
            </div>
        </div>
        <div class="resxManager-bottom"><!-- --></div>
    </div>
</asp:Panel>
