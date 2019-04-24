<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegionalSettings.ascx.cs" Inherits="RESXManager.Presentation.Controls.RegionalSettings" %>
<div id="resxManager-wrapper">
    <ul class="resxManager-tab-nav">
        <li>
            <a class="resxManager-active"><span><!----></span><asp:Literal ID="ltrLanguages" meta:resourcekey="ltrLanguages" runat="server"/></a>
        </li>
    </ul>
    <div class="resxManager-main resxManager-main-bordered">
        <div class="resxManager-rt">
            <div class="resxManager-rb">
                <div class="resxManager-lb">
                    <div class="resxManager-columns-row">
                        <asp:Panel ID="labelsLoading"  class="resxManager-loading" runat="server">
                                <asp:Image ID="Image1" ImageUrl="~/images/resxmanager/uploading_file.gif" Width="32"
                                    Height="32" runat="server" />
                                <%--<br />
                                <strong>
                                    <asp:Literal ID="ltrLoadingPanelText" meta:resourcekey="ltrLoadingPanelText" runat="server" />
                                </strong>--%>
                        </asp:Panel>
                        <div class="resxManager-column resxManager-column-height">
                            <h2><asp:Literal EnableViewState="false" meta:resourcekey="ltrLanguages" runat="server"/></h2>
                            <div class="resxManager-visual">
                                <span class="resxManager-big-ico"><img src="~/images/resxmanager/icon-map.png" alt="" width="150" height="73" runat="server" /></span>
                            </div>
                            <div class="resxManager-text">                                
                                <asp:Literal EnableViewState="false" meta:resourcekey="ltrLanguagesDescription" runat="server" />                                
                            </div>
                        </div>
                        <div class="resxManager-column-right resxManager-column-height">                    
                            <asp:Panel CssClass="resxManager-sub-tabs" ID="pnlGrayHeader" runat="server">
                                <div class="resxManager-top"><!-- --></div>
                                <div class="resxManager-layout1">
                                    <div class="resxManager-top"><!-- --></div>
                                    <div class="resxManager-layout2">
                                        <h3><asp:Literal ID="ltrGrayHeader" EnableViewState="false" meta:resourcekey="ltrGrayHeader" runat="server" /></h3>
                                    </div>
                                </div>
                            </asp:Panel>
                            <asp:Panel CssClass="resxManager-select-row resxManager-regional-setting-page" ID="pnlDefaultCultureSave" runat="server">
                                <asp:DropDownList ID="ddlCulture" CssClass="resxManager-ddlist resxManager-size-middle" runat="server" />                                
                                <span class="resxManager-btn resxManager-add-space-left">
                                    <asp:Button ID="btnSave" CssClass="resxManager-btnSave" OnClick="BtnSave_Click" meta:resourcekey="btnSave" runat="server" />
                                </span>                                
                            </asp:Panel>
                            <br />
                            <div class="resxManager-content-text">
                                <asp:Label CssClass="resxManager-description" EnableTheming="false" meta:resourcekey="lblCultureDescription" runat="server" />
                            </div>
                            <asp:GridView ID="gvLanguages" CssClass="resxManager-table-common" AutoGenerateColumns="false"  
                                OnRowDataBound="gvLanguages_RowDataBound" runat="server">
                                <Columns>
                                    <asp:TemplateField Visible="false">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hfKey" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Image ID="imgLanguage" CssClass="resxManager-icon-flag" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField meta:resourcekey="Language">
                                        <ItemTemplate>
                                            <asp:Label ID="lblLanguage" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField meta:resourcekey="Dictionary" Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDictionaryFileName" runat="server" Visible="false" />
                                            <asp:LinkButton ID="lbtnUploadDictionaryFileName" runat="server" meta:resourcekey="lbtnUploadDictionaryFileName" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField meta:resourcekey="DeleteLanguage">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="ibtnDelete" runat="server" CssClass="resxManager-delete-button" ImageUrl= "~/images/resxmanager/icon-delete.png"
                                                OnClientClick="javascript:return showConfirmMessage();" OnClick="IbtnDelete_Click" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                            <div class="resxManager-separator"><!-- --></div>
                            <div class="resxManager-saving-box">
                                <div class="resxManager-add-box" style="display:none;">
                                    <asp:DropDownList ID="ddlAddCulture" CssClass="resxManager-ddlist resxManager-size-middle" runat="server" />
                                    <br /><br />
                                    <table border="0">
                                        <tr>
                                            <td>
                                                <span class="resxManager-btn">
                                                    <asp:Button ID="btnAdd" meta:resourcekey="btnAdd" runat="server"
                                                        OnClientClick="showTextBoxPopup();return false;" />
                                                    <asp:HiddenField ID="hfAutoTranslate" runat="server" />
                                                </span>
                                            </td>
                                            <td valign="middle" class="resxManager-padding-left-20">
                                            <asp:LinkButton ID="lnkCancel" OnClientClick="$('.resxManager-add-box').slideToggle().next('.resxManager-btn').show(); return false;"
                                                meta:resourcekey="lnkCancel" runat="server" />
                                            </td>
                                        </tr>
                                    </table>
                                    <br />                            
                                </div>
                                <span class="resxManager-btn">
                                    <asp:Button ID="btnAddLanguage" meta:resourcekey="btnAddLanguage" OnClientClick="$('.resxManager-add-box').slideToggle().next('.resxManager-btn').hide(); return false;"
                                        runat="server" />
                                </span>                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class="resxManager-popup-main resxManager-popup-textbox">    
    <span class="resxManager-popup-left-shadow"></span><span class="resxManager-popup-bottom-shadow"></span>
    <span class="resxManager-popup-shadow-corner"></span>
    <div class="resxManager-popup-title">
        <h2><asp:Literal ID="litTitleMessage" meta:resourcekey="litTitleMessage" runat="server" /></h2>
        <span class="resxManager-popup-close"></span>
    </div>
    <div class="resxManager-popup-text"> 
        <asp:Literal ID="litTextMessage" meta:resourcekey="litTextMessage" runat="server" />
        <asp:DropDownList ID="ddlTranslateFromLanguages" CssClass="ddlist resxManager-size-middle" runat="server" />
        <br/>
        <span class="resxManager-btn">
            <asp:Button ID="btnAutoTranslate" OnClick="BtnAdd_Click" OnClientClick="setupHf('1');" meta:resourcekey="btnAutoTranslate" runat="server" />
        </span>        
        <span class="resxManager-btn">
            <asp:Button ID="btnOnlyAddFiles" OnClick="BtnAdd_Click" OnClientClick="setupHf('');" meta:resourcekey="btnOnlyAddFiles" runat="server" />
        </span>
        <br/>
        <div class="resxManager-clear resxManager-padding-top-10"><!----></div>
        <asp:Label ID="lblAddLanguageMessage" style="display:none;" ForeColor="Green" EnableViewState="false" runat="server" />
    </div>
</div>

<script type="text/javascript">
    //<![CDATA[
    function showConfirmMessage() {
        return confirm('<%= GetLocalResourceObject("ConfirmDeleteMessage").ToString() %>');
    }

    function checkAutoTranslationState(culture) {
        $.ajax({
            url: '<%= ResolveUrl("~/Handlers/RESXManager/AutoTranslation.ashx") %>'+'?'+'<%= RESXManager.Presentation.WebConstants.QueryString.Culture %>=' + culture
        }).done(function (data) {
            if (data == '<%= bool.TrueString %>') {
                setTimeout(function () { checkAutoTranslationState(culture); }, 5000);
                $(".resxManager-loading").show();
            }
            else {
                location.href = location.href;
                $(".resxManager-loading").hide();
            }
        });
    }

    function bindDropdownWithImages() {
        try {
            $("select").msDropDown();
        } catch (e) {
            alert(e.message);
        }
    }

    $(document).ready(function () {
        bindDropdownWithImages();
        bindTextBoxPopup();
    });

    function bindTextBoxPopup() {
        $('.resxManager-popup-close, .resxManager-popup-overlay').click(function () {
            hideTextBoxPopup();            
        });
    };

    function hideTextBoxPopup() {
        $('.resxManager-popup-textbox, .resxManager-popup-overlay').hide();
    }

    function showTextBoxPopup(title, text) {
        var ddlAddCultureValue = $('#<%= ddlAddCulture.ClientID %>').val();
        var isAvailableForTranslation = false;
        for (var i = 0; i < availableLanguages.length; i++) {
            if (ddlAddCultureValue.indexOf(availableLanguages[i]) == 0) {
                isAvailableForTranslation = true;
            }
        }
        var btnAutoTranslate = document.getElementById('<%= btnAutoTranslate.ClientID %>');
        if ('<%= IsAutoTranslationEnabled %>' == '<%= bool.TrueString %>' && isAvailableForTranslation) {            
            btnAutoTranslate.style.display = "block";
        }
        else {
            btnAutoTranslate.style.display = "none";
        }

        var lblAddLanguageMessage = document.getElementById('<%= lblAddLanguageMessage.ClientID %>');
        if (isAvailableForTranslation) {
            lblAddLanguageMessage.innerHTML = '';
            lblAddLanguageMessage.style.display = "none";
        }
        else {
            lblAddLanguageMessage.innerHTML = '<%= GetLocalResourceObject("NoAutoTranslation").ToString() %>'.replace("##AddCulture##", ddlAddCultureValue);
            lblAddLanguageMessage.style.display = "block";
        }

        $('.resxManager-popup-textbox, .resxManager-popup-overlay').show();
    }

    function setupHf(v) {
        var hfAutoTranslate = document.getElementById('<%= hfAutoTranslate.ClientID %>');
        hfAutoTranslate.value = v;
        hideTextBoxPopup();
        $(".resxManager-loading").show();
    }

    //]]>
</script>

