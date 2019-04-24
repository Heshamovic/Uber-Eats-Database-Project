<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchByUrl.ascx.cs" Inherits="RESXManager.Presentation.Controls.SearchByUrl" %>
<script type="text/javascript">
    function showUrlLoadingImage() {
        if (Page_ClientValidate("SearchByUrl")) {
            $('[id$="imgUrlLoading"]').css("visibility", "visible");
            
        }
        else {
            return false;    
        }
    }

    function hideUrlLoadingImage() {
        $('[id$="imgUrlLoading"]').css("visibility", "hidden");
    }

    var searchUrlOnEnter = function(event) {
        if (event.keyCode == 13) {
            $('.resxManager-btnUrlSearch').focus().click();
            return false;
        }
    };
 
</script>
<asp:Panel ID="pnlDescriptionBlock" runat="server">
    <h2><asp:Literal ID="ltrTitle" runat="server" meta:resourcekey="ltrTitle" /></h2>
    <div class="resxManager-visual"><span><img src="~/images/RESXManager/icon-edit.png" alt="edit" width="78" height="71" runat="server" /></span></div>
    <div class="resxManager-text resxManager-text-content"><asp:Literal ID="ltrEditByURLDesctiption" meta:resourcekey="ltrEditByURLDesctiption" runat="server" /></div>
</asp:Panel>
<asp:Panel ID="pnlFormBlock" runat="server">
    <div class="resxManager-box-gray resxManager-box-search">
        <div class="resxManager-top"><!-- --></div>
        <div class="resxManager-box-content"> 
            <div class="resxManager-inner-padding">           
                <span class="resxManager-txt">
                    <span>                
                    <asp:TextBox ID="txtUrl" CssClass="resxManager-txtSearch" onkeydown="return searchUrlOnEnter(event);" runat="server" meta:resourcekey="txtUrl" />
                    </span>                
                    <%--<asp:Image ID="imgUrlLoading" ImageUrl="~/images/RESXManager/loading.gif" CssClass="resxManager-img-loading" style="visibility:hidden;" runat="server"/>--%>
                </span>
            
                <asp:RequiredFieldValidator ID="rqvldUrl" ControlToValidate="txtUrl" ValidationGroup="SearchByUrl" Display="None" meta:resourcekey="rqvldUrl" runat="server"  />
                <asp:RegularExpressionValidator ID="regvldUrl" ControlToValidate="txtUrl" ValidationGroup="SearchByUrl" ValidationExpression="(http|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?" Display="None" meta:resourcekey="regvldUrl" runat="server" />
                <asp:ValidationSummary ID="vldsumSearchByUrl" ValidationGroup="SearchByUrl" ShowMessageBox="true" ShowSummary="false" runat="server" />
                <span class="resxManager-left resxManager-small-margin-right">
                    <asp:DropDownList ID="ddlUrlCulture" CssClass="resxManager-ddlist resxManager-size-middle" runat="server" meta:resourcekey="ddlUrlCulture" />            
                </span>                
                <span class="resxManager-btn">
                    <asp:Button ID="btnCheckUrl" OnClick="BtnCheckUrl_Click" OnClientClick="return showUrlLoadingImage();" ValidationGroup="SearchByUrl" CssClass="resxManager-btnUrlSearch" Style="font-size: 11px;" meta:resourcekey="btnCheckUrl" runat="server" />
                </span>
            </div>
        </div>        
        <div class="resxManager-bottom"><!-- --></div>
    </div>
</asp:Panel>