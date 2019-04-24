<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Labels.ascx.cs" Inherits="RESXManager.Presentation.Controls.Labels" %>
<%@ Register Src="~/Controls/RESXManager/Labels/LabelsSearchResultList.ascx" TagName="LabelsSearchResultList" TagPrefix="resx" %>
<%@ Register Src="~/Controls/RESXManager/FilterControls/SearchByUrl.ascx" TagName="SearchByUrl" TagPrefix="resx" %>
<%@ Register Src="~/Controls/RESXManager/FilterControls/SearchByBrowsing.ascx" TagName="SearchByBrowsing" TagPrefix="resx" %>
<%@ Register Src="~/Controls/RESXManager/FilterControls/SearchByText.ascx" TagName="SearchByText" TagPrefix="resx" %>

<script type="text/javascript">   
   //<![CDATA[

    Sys.Application.add_load(function () { 
        $('textarea.resxManager-expand').each(function () {
            $(this).TextAreaExpander(20, 1000);            
        });

        $(".<%= AccordionHeader %>").click(function () { eval($(this).find("a").attr("href")); });
        $(".<%= AccordionHeaderSelected %>").click(function () { eval($(this).find("a").attr("href")); });

        addTooltip();
        resetWatermarks('<%= GetLocalResourceObject("LabelValueWatermark").ToString() %>', '<%= GetLocalResourceObject("LabelCommentsWatermark").ToString() %>');
        bindPopups();
        bindEnterToTextboxes();
        bindSpellChecker();
        bindDropdownWithImages();
    });

    Sys.WebForms.PageRequestManager.getInstance().add_initializeRequest(initializeRequest);
    Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(beginRequest);
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(afterRequest);

    var scrollXOffset;
    var isClicked = true;
    var elemPath;

    function initializeRequest(sender, args) {
     
        //if (typeof (confirmClose) == "function") {
        //    var res = confirmClose();                       
        //    var elemId = args.get_postBackElement().id;
        //    if (typeof (res) == "string" && isClicked) {
        //        $("#<%= hlnkSaveAndExit.ClientID %>, #<%= hlnkDontSaveAndExit.ClientID %>").unbind("click");
                
        //        $('.resxManager-popup-alert,.resxManager-popup-overlay').show();
                    
                    
        //            args.set_cancel(true);
                    
        //            $("#<%= hlnkSaveAndExit.ClientID %>").click(function () {
        //                isClicked = false;
        //                $('.resxManager-hidden-save-message').val("Changed");
        //                $('.resxManager-popup-alert,.resxManager-popup-overlay').hide();
        //                elemPath = elemId.replace(/_/g, "$");
        //                __doPostBack(elemPath, '');
        //            });

        //            $("#<%= hlnkDontSaveAndExit.ClientID %>").click(function () {
        //                isClicked = false;
        //                $('.resxManager-popup-alert,.resxManager-popup-overlay').hide();
        //                __doPostBack(elemId.replace(/_/g, "$"), '');
        //            });

        //            $("#<%= hlnkCancel.ClientID %>").click(function () {
        //                isClicked = true;
        //                $('.resxManager-popup-alert,.resxManager-popup-overlay').hide();
        //                if (elemId.indexOf('ddlLanguages') != -1) {
        //                    document.getElementById(elemId).selectedIndex = document.getElementById(elemId.replace('ddlLanguages', 'hfDdlLanguages')).value;
        //                    $('#' + elemId).msDropDown().data("dd").selectedIndex(document.getElementById(elemId.replace('ddlLanguages', 'hfDdlLanguages')).value);
        //                }
        //                if (elemId.indexOf('ddlFolder') != -1) {
        //                    document.getElementById(elemId).selectedIndex = document.getElementById(elemId.replace('ddlFolder', 'hfDdlFolder')).value;
        //                    $('#' + elemId).msDropDown().data("dd").selectedIndex(document.getElementById(elemId.replace('ddlFolder', 'hfDdlFolder')).value);
        //                }
        //                if (elemId.indexOf('ddlBrowseCulture') != -1) {
        //                    document.getElementById(elemId).selectedIndex = document.getElementById(elemId.replace('ddlBrowseCulture', 'hfDdlBrowseCulture')).value;
        //                    $('#' + elemId).msDropDown().data("dd").selectedIndex(document.getElementById(elemId.replace('ddlBrowseCulture', 'hfDdlBrowseCulture')).value);
        //                }
        //            });                
        //    }
    //}
        
    }

    function beginRequest(sender, args) {
        showLoadingPanel();
        scrollXOffset = $('#ctl00_body_tabControl_tab01layer_contentlayer').scrollTop();   
    }

    function afterRequest(sender, args) {
        hideLoadingPanel();
        if (args.get_error() != undefined) {
            var msg = args.get_error().message.replace("Sys.WebForms.PageRequestManager", "").replace("Exception","");
            alert(msg);
        }
        $('#ctl00_body_tabControl_tab01layer_contentlayer').scrollTop(scrollXOffset);
        isClicked = true;        
    }

    function DownloadFile(element) {
        var baseName = element.id.substr(0, element.id.lastIndexOf("_") + 1);
        var file = $("#" + baseName + "ddlVersions").val();

        var iframe = document.getElementById("iframeDownloadFile");        
        // Point the IFRAME to GenerateFile, with the
        //   desired filename as a querystring argument.
        iframe.src = '<%= ResolveUrl("~/Handlers/RESXManager/DownloadFile.ashx") %>' + '?file=' + file;
    }

    function showRevertConfirmMessage() {
        return confirm('<%= GetLocalResourceObject("ConfirmRevertMessage").ToString() %>');
    }

    function bindSpellChecker() {
        // check the spelling on a textarea
        $(".resxManager-check-textarea").click(function (e) {
            e.preventDefault();
            triggerSpellCheck(this,false);
        });

        // uncheck the spelling on a textarea
        $(".resxManager-uncheck-textarea").click(function (e) {
            e.preventDefault();
            /* search for common parent up from Spell uncheck button */
            var container = $(this).parents(".resxManager-content-blocks");
            /* call spellchecker uncheck for each textarea in container */
            container.find("textarea").each(function () {
                $(this).spellchecker("remove");
            });
        });

        // spell check after each postback if checked
        if ($("#<%= chkbxTextSpellCheck.ClientID %>").attr("checked")) {
            var textContainer = $("#<%= accordionTextResult.ClientID %>");
            textContainer.find(".resxManager-check-textarea").click();
            textContainer.find("textarea").bind("blur.spellchecker",function (e) { triggerSpellCheck(this,true); });
        }

        if ($("#<%= chkbxUrlSpellCheck.ClientID %>").attr("checked")) {
            var urlContainer = $("#<%= accordionUrlResult.ClientID %>");
            urlContainer.find(".resxManager-check-textarea").click();
            urlContainer.find("textarea").bind("blur.resxManager-spellchecker", function (e) { triggerSpellCheck(this, true); });
        }

        if ($("#<%= chkbxBrowseSpellCheck.ClientID %>").attr("checked")) {
            var browseContainer = $("#<%= accordionBrowseResult.ClientID %>");
            browseContainer.find(".resxManager-check-textarea").click();
            browseContainer.find("textarea").bind("blur.resxManager-spellchecker", function (e) { triggerSpellCheck(this, true); });
        }        

    }

    function spellCheckboxClick(elem) {
        var container = $(elem).parents("[id$='Result']");
        if ($(elem).attr("checked")) {            
            container.find(".resxManager-check-textarea").click();
            container.find("textarea").bind("blur.resxManager-spellchecker", function (e) { triggerSpellCheck(this, true); });
            container.find("[id$='SpellCheckSwitch']").html('<%= GetLocalResourceObject("SpellCheckOn").ToString() %>');
            container.find("[id$='SpellCheckSwitch']").css("color","green");            
        }
        else {            
            container.find("textarea").unbind("blur.resxManager-spellchecker");
            /* set timeout because blur on textarea trigger spell check(if it in focus before turn off spellchecker) */
            setTimeout(function () { container.find(".resxManager-uncheck-textarea").click(); }, 3000);
            container.find("[id$='SpellCheckSwitch']").html('<%= GetLocalResourceObject("SpellCheckOff").ToString() %>');
            container.find("[id$='SpellCheckSwitch']").css("color", "red");
        }
    }

    function triggerSpellCheck(elem,isForThisOnly) {
        showLoadingPanel();
        /* search for common parent up from Spell check button */
        var container = $(elem).parents(".resxManager-content-blocks");
        /* parse language name from resx file name*/
        var expr = new RegExp('\\.([\\w]{2,3}(-[\\w]{2,4})?(-[\\w]{2,})?)(?=\\.resx$)', 'i');
        var match = expr.exec(container.find("[id$='lblFileName']").text());
        var language = "<%= RESXManager.Core.Configuration.RESXSettings.InvariantCulture %>";
        if (match != null && match[1] != null && match[1] != '') {
            language = match[1];
        }

        if (language.indexOf("-") != -1) {
            language = language.substring(0, language.indexOf("-"));
        }
        /* switch selector to all textarea or one textarea */
        var selector;
        if (isForThisOnly) {
            selector = "#"+elem.id;
        }
        else {
            selector = "textarea";
        }
        /* call spellchecker for each textarea in container or only one */
        container.find(selector).each(function () {
            $(this).spellchecker({
                url: '<%= ResolveUrl("~/Handlers/RESXManager/JQuerySpellCheckerHandler.ashx") %>',    // only value different from original demo code using PHP
                lang: language,
                engine: "google",
                suggestBoxPosition: "above",
                innerDocument: false
            })
			    .spellchecker("check", function (result) {
			        // spell checker has finished checking words
			        hideLoadingPanel();

			        // if result is true then there are no badly spelt words
			        //if (result) {
			        //    alert('There are no incorrectly spelt words.');
			        //}
			    })
        });
    }
   
   // ]]>
</script>

<div class="resxManager-popup-main resxManager-popup-alert">    
    <span class="resxManager-popup-left-shadow"></span><span class="resxManager-popup-bottom-shadow"></span>
    <span class="resxManager-popup-shadow-corner"></span>
    <div class="resxManager-popup-title">
        <h2><asp:Literal ID="litAlertMessage" meta:resourcekey="litAlertMessage" runat="server" /></h2>
        <span class="resxManager-popup-close"></span>
    </div>
    <div class="resxManager-popup-text"> 
        <asp:HyperLink ID="hlnkSaveAndExit" Text="Yes, save changes" runat="server" />       
        <asp:HyperLink ID="hlnkDontSaveAndExit" Text="No, dont save changes" runat="server" />       
        <asp:HyperLink ID="hlnkCancel" Text="Cancel" runat="server" />       
    </div>
</div>

<div id="resxManager-wrapper">
    <ul class="resxManager-labels resxManager-tab-nav">
        <li><asp:HyperLink ID="hlnkTabSearch" class="resxManager-pointer" onclick="toggleBlocksLabels(0);" runat="server"><span><!----></span><asp:Literal runat="server" meta:resourcekey="hlnkTabSearch" /></asp:HyperLink></li>
        <li><asp:HyperLink ID="hlnkTabURL" class="resxManager-pointer" onclick="toggleBlocksLabels(1);" runat="server"><span><!----></span><asp:Literal runat="server" meta:resourcekey="hlnkTabURL" /></asp:HyperLink></li>
        <li><asp:HyperLink ID="hlnkTabBrowse" class="resxManager-pointer" onclick="toggleBlocksLabels(2);" runat="server"><span><!----></span><asp:Literal runat="server" meta:resourcekey="hlnkTabBrowse" /></asp:HyperLink></li>
    </ul>
    <div class="resxManager-clear"><!----></div>
    <div class="resxManager-main resxManager-main-colored">
        <div class="resxManager-rt">
            <div class="resxManager-rb">
                <div class="resxManager-lb">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Panel ID="Panel1" CssClass="resxManager-columns-row resxManager-upperLabelsMenu" runat="server">
                            <div class="resxManager-column resxManager-column-height">
                                <h2><asp:Literal ID="ltrBySearch" meta:resourcekey="ltrBySearch" runat="server"/></h2>
                                <div class="resxManager-visual resxManager-pointer" onclick="toggleBlocksLabels(0);">
                                    <span><img src="~/images/RESXManager/icon-search.png" alt="search" width="75" height="77" runat="server" /></span>
                                </div>
                                <div class="resxManager-text">
                                    <asp:Literal ID="ltrBySearchText" meta:resourcekey="ltrBySearchText" runat="server"/>
                                    <br /><br />
                                    <asp:Literal ID="ltrBySearchText2" meta:resourcekey="ltrBySearchText2" runat="server"/>
                                </div>
                                <div class="resxManager-more">
                                    <a href="#" onclick="toggleBlocksLabels(0);">
                                    <span>&raquo;</span> <asp:Literal ID="ltrBySearchMore" meta:resourcekey="ltrBySearchMore" runat="server"/>
                                    </a>
                                </div>
                            </div>
                            <div class="resxManager-column resxManager-column-height">
                                <h2>
                                    <asp:Literal ID="ltrByUrl" meta:resourcekey="ltrByUrl" runat="server"/>
                                </h2>
                                <div class="resxManager-visual resxManager-pointer" onclick="toggleBlocksLabels(1);">
                                    <span>
                                        <img src="~/images/RESXManager/icon-edit.png" alt="edit" width="78" height="71" runat="server" />
                                    </span>
                                </div>
                                <div class="resxManager-text">
                                    <asp:Literal ID="ltrByUrlText" meta:resourcekey="ltrByUrlText" runat="server"/>
                                    <br /><br />
                                    <asp:Literal ID="ltrByUrlText2" meta:resourcekey="ltrByUrlText2" runat="server"/>                                
                                </div>
                                <div class="resxManager-more">
                                    <a href="#" onclick="toggleBlocksLabels(1);">
                                    <span>&raquo;</span><asp:Literal ID="ltrByUrlMore" meta:resourcekey="ltrByUrlMore" runat="server"/>
                                    </a>
                                </div>
                            </div>
                            <div class="resxManager-column resxManager-column-height">
                                <h2>
                                    <asp:Literal ID="ltrByBrowsing" meta:resourcekey="ltrByBrowsing" runat="server"/>
                                </h2>
                                <div class="resxManager-visual resxManager-pointer" onclick="toggleBlocksLabels(2);">
                                    <span>
                                        <img src="~/images/RESXManager/icon-browse.png" alt="browse" runat="server" />
                                    </span>
                                </div>
                                <div class="resxManager-text">
                                    <asp:Literal ID="ltrByBrowsingText" meta:resourcekey="ltrByBrowsingText" runat="server"/>
                                    <br /><br />
                                    <asp:Literal ID="ltrByBrowsingText2" meta:resourcekey="ltrByBrowsingText2" runat="server"/>                                
                                </div>
                                <div class="resxManager-more">
                                    <a href="#" onclick="toggleBlocksLabels(2);">
                                    <span>&raquo;</span><asp:Literal ID="ltrByBrowsingMore" meta:resourcekey="ltrByBrowsingMore" runat="server"/>
                                    </a>
                                </div>
                            </div>
                        </asp:Panel>                    
                        <div class="resxManager-columns-row resxManager-labels">
                            <resx:SearchByText ID="searchByText" OnTextSearch="SearchByText_TextSearch" DescriptionBlockCssClass="resxManager-column resxManager-column-height" FormBlockCssClass="resxManager-column-right resxManager-column-height" runat="server" />
                            <resx:SearchByUrl ID="searchByUrl" OnUrlSearch="SearchByUrl_UrlSearch" DescriptionBlockCssClass="resxManager-column resxManager-column-height" FormBlockCssClass="resxManager-column-right resxManager-column-height" runat="server" />
                            <resx:SearchByBrowsing ID="searchByBrowsing" OnBrowsePathChanged="SearchByBrowsing_BrowsePathChanged" DescriptionBlockCssClass="resxManager-column resxManager-column-height" FormBlockCssClass="resxManager-column-right resxManager-column-height" runat="server" />
                        </div>                                          

                        <div id="resxManager-labelsPane" class="resxManager-labelsPane">
                            <asp:Panel ID="labelsLoading" class="resxManager-loading" runat="server">
                                <asp:Image ID="Image1" ImageUrl="~/images/resxmanager/uploading_file.gif" AlternateText="uploading" Width="32"
                                    Height="32" runat="server" />
                                <%--<br />
                                <strong>
                                    <asp:Literal ID="ltrLoadingPanelText" meta:resourcekey="ltrLoadingPanelText" runat="server" />
                                </strong>--%>
                            </asp:Panel>
                            <asp:Panel ID="accordionTextResult" runat="server" style="display: none;">
                                <asp:Panel ID="pnlTextResultHeader"  CssClass="resxManager-accordionMainHeader" Visible="false" runat="server">
                                    <asp:Literal runat="server" meta:resourcekey="ltrHeaderResultList"></asp:Literal>
                                    <asp:Panel ID="pnlTextSpellCheck" class="resxManager-right" runat="server">
                                        <asp:Label ID="lblTextSpellCheckHeader" meta:resourcekey="lblSpellCheckHeader" runat="server" />
                                        <asp:Label ID="lblTextSpellCheckSwitch" runat="server" />
                                        <input type="checkbox" class="resxManager-spellcheck-input" id="chkbxTextSpellCheck" checked="checked" onclick="spellCheckboxClick(this);" runat="server" />
                                    </asp:Panel>
                                </asp:Panel>                                
                                
                                <div class="resxManager-accordion" id="resxManager-accordionTextResultList">
                                     <asp:Repeater ID="rptTextResultList" runat="server" OnItemDataBound="RptTextResultList_ItemDataBound">
                                         <ItemTemplate>
                                            <asp:Panel ID="pnlTextSearchResult" CssClass="resxManager-accordionHeader" runat="server">                                            
                                                 <asp:LinkButton ID="lbtnTextSearchResult" CssClass="resxManager-black-link" OnClientClick="return false;" OnCommand="LbtnTextSearchResult_Command" runat="server" />                                            
                                            <div class="resxManager-img">                                
                                            </div>
                                         </asp:Panel> 
                                         <div class="resxManager-accordionContent">
                                             <resx:LabelsSearchResultList ID="ucTextResultList" PanelCssClass="resxManager-text-search" runat="server" />
                                         </div>
                                         </ItemTemplate>
                                     </asp:Repeater>
                                </div>
                                <asp:Panel ID="pnlTextResultListEmpty" class="resxManager-result-empty" Visible="false" runat="server">
                                    <asp:Label ID="lblTextResultListEmpty" meta:resourcekey="lblResultListEmpty" runat="server" />  
                                </asp:Panel>                               
                            </asp:Panel>
                            
                            <asp:Panel ID="accordionUrlResult" runat="server" style="display:none;">
                                <asp:Panel ID="pnlUrlResultHeader"  CssClass="resxManager-accordionMainHeader" Visible="false" runat="server">
                                    <asp:Literal runat="server" meta:resourcekey="ltrHeaderResultList"></asp:Literal>
                                    <asp:Panel ID="pnlUrlSpellCheck" class="resxManager-right" runat="server">
                                        <asp:Label ID="lblUrlSpellCheckHeader" meta:resourcekey="lblSpellCheckHeader" runat="server" />
                                        <asp:Label ID="lblUrlSpellCheckSwitch" runat="server" />
                                        <input type="checkbox" class="resxManager-spellcheck-input" id="chkbxUrlSpellCheck" checked="checked" onclick="spellCheckboxClick(this);" runat="server" />
                                    </asp:Panel>
                                </asp:Panel>                               

                                <div class="resxManager-accordion" id="resxManager-accordionUrlResultList">
                                    <asp:Repeater ID="rptUrlResultList" runat="server" OnItemDataBound="RptUrlResultList_ItemDataBound">
                                        <ItemTemplate>
                                            <asp:Panel ID="pnlUrlSearchResult" CssClass="resxManager-accordionHeader" runat="server">                                                
                                                    <asp:LinkButton ID="lbtnUrlSearchResult" CssClass="resxManager-black-link" OnClientClick="return false;" OnCommand="LbtnUrlSearchResult_Command" runat="server" />                                                
                                                <div class="resxManager-img">                                
                                                </div>
                                            </asp:Panel>  
                                            <div class="resxManager-accordionContent">
                                                <resx:LabelsSearchResultList ID="ucUrlResultList" PanelCssClass="resxManager-url-search" runat="server" />
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                                <asp:Panel ID="pnlUrlResultListEmpty" class="resxManager-result-empty" Visible="false" runat="server">
                                    <asp:Label ID="lblUrlResultListEmpty" meta:resourcekey="lblResultListEmpty" runat="server" />
                                </asp:Panel>
                            </asp:Panel>
                            
                            <asp:Panel ID="accordionBrowseResult" runat="server" style="display:none;">
                                <asp:Panel ID="pnlBrowseResultHeader"  CssClass="resxManager-accordionMainHeader" Visible="false" runat="server">
                                    <asp:Literal runat="server" meta:resourcekey="ltrHeaderResultList"></asp:Literal>
                                    <asp:Panel ID="pnlBrowseSpellCheck" class="resxManager-right" runat="server">
                                        <asp:Label ID="lblBrowseSpellCheckHeader" meta:resourcekey="lblSpellCheckHeader" runat="server" />
                                        <asp:Label ID="lblBrowseSpellCheckSwitch" runat="server" />
                                        <input type="checkbox" class="resxManager-spellcheck-input" id="chkbxBrowseSpellCheck" checked="checked" onclick="spellCheckboxClick(this);" runat="server" />
                                    </asp:Panel>
                                </asp:Panel>

                                <div class="resxManager-accordion" id="accordionBrowseResultList">
                                    <asp:Repeater ID="rptBrowseResultList" runat="server" OnItemDataBound="RptBrowseResultList_ItemDataBound">
                                        <ItemTemplate>                                            
                                            <asp:Panel ID="pnlBrowseSearchResult" CssClass="resxManager-accordionHeader" runat="server">                                                
                                                <asp:LinkButton ID="lbtnBrowseSearchResult" CssClass="resxManager-black-link" OnClientClick="return false;" OnCommand="LbtnBrowseSearchResult_Command"
                                                    runat="server" />                                                
                                                <div class="resxManager-img">
                                                </div>
                                            </asp:Panel>                                            
                                            <div class="resxManager-accordionContent">
                                                <resx:labelssearchresultlist id="ucBrowseResultList" panelcssclass="resxManager-browse-search"
                                                    runat="server" />
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                                <asp:Panel ID="pnlBrowseResultListEmpty" class="resxManager-result-empty" Visible="false" runat="server">
                                    <asp:Label ID="lblBrowseResultListEmpty" meta:resourcekey="lblResultListEmpty" runat="server" />
                                </asp:Panel>
                            </asp:Panel>
                           <%--resx:LabelsSearchResultList ID="ucBrowseResultList" PanelCssClass="resxManager-browse-search" runat="server" /--%>
                        </div>
                        <%--asp:HiddenField ID="hfAccordionTextResultList" runat="server" /> 
                        <asp:HiddenField ID="hfAccordionUrlResultList" runat="server" /> 
                        <asp:HiddenField ID="hfAccordionBrowseResultList" runat="server" /--%>                         
                        <asp:HiddenField ID="hfCurrentLabelsSearchTab" runat="server" />
                    </ContentTemplate>
                    </asp:UpdatePanel>                   
                </div>
            </div>
        </div>
    </div>
</div>
