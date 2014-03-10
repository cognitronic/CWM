<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PollView.ascx.cs" Inherits="CWM.Website.Views.PollView" %>
<telerik:RadAjaxManagerProxy ID="rampCartActions" runat="server" >
    <AjaxSettings>
        <telerik:AjaxSetting AjaxControlID="lbSubmitAnswer">
            <UpdatedControls>
                <telerik:AjaxUpdatedControl ControlID="rb1" LoadingPanelID="RadAjaxLoadingPanel1" />
                <telerik:AjaxUpdatedControl ControlID="lblPollMessage" />
                <telerik:AjaxUpdatedControl ControlID="lbSubmitAnswer" />
            </UpdatedControls>
        </telerik:AjaxSetting>
    </AjaxSettings>
</telerik:RadAjaxManagerProxy>
<telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Windows7" />

<div id="blogLatest">
	<h3>Online Poll</h3>
        <idea:Label
        runat="server"
        ID="lblQuestion" />
    <br /><br />
	<p>
    <asp:RadioButtonList
    runat="server"
    ID="rb1">
    </asp:RadioButtonList>
    </p>
	<idea:LinkButton
    runat="server"
    CausesValidation="false"
    OnClick="SubmitAnswerClicked"
    ID="lbSubmitAnswer">
    <h2 style="margin-top: -10px;">Submit Answer</h2>
    </idea:LinkButton>
    <idea:Label
    runat="server"
    ID="lblPollMessage" />
</div>