<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="BlogPost.aspx.cs" Inherits="CWMAdmin.Website.BlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <div style="float: right; border-bottom: 1px solid #CCC; width: 100%;">
        <span style="margin-right: 20px;">
            <idea:LinkButton
            runat="server"
            ID="lbSavePage"
            OnClick="SavePageClicked">
                <asp:Image
                runat="server"
                ID="imgSave"
                ImageUrl="~/img/disk.png" /> Save Page
            </idea:LinkButton>
        </span>
        <span>
            <idea:LinkButton
            runat="server"
            ID="lbCancel"
            OnClick="CancelClicked">
                <asp:Image
                runat="server"
                ID="imgCancel"
                ImageUrl="~/img/cancel.png" />Cancel Changes
            </idea:LinkButton>
        </span>
    </div>   
    <div id="mainContent" class="grid_16" style="border-bottom: 1px solid #CCC; margin-top: 5px;">
            <div runat="server" id="divPostType">
                <div>Post Type:</div>
                <idea:DropDownList
                runat="server"
                ID="ddlPostType">
                    <Items>
                        <telerik:RadComboBoxItem
                        runat="server"
                        Text="Arts"
                        Value="1" />
                        <telerik:RadComboBoxItem
                        runat="server"
                        Text="Business"
                        Value="2" />
                        <telerik:RadComboBoxItem
                        runat="server"
                        Text="City"
                        Value="3" />
                    </Items>
                </idea:DropDownList>
            </div>
            <div>
                <div>Title:</div>
                <idea:TextBox
                runat="server"
                Width="450px"
                ID="tbTitle" />
            </div>
            <div>
                <div>Start Date:</div>
                <telerik:RadDatePicker 
                ID="tbStartDate"
                Skin="Windows7"
                AutoPostBack="true"
                MinDate="1/1/2006"
                runat="server">
                    <DateInput ID="diStartDate" runat="server"
                        DateFormat="MM/dd/yyyy"></DateInput>
                </telerik:RadDatePicker>
            </div>
            <div>
                <div>SEO Keywords:</div>
                <idea:TextBox
                runat="server"
                TextMode="MultiLine"
                Height="150px"
                Width="450px"
                ID="tbSeoKeywords" />
            </div>
            <div>
                <div>End Date:</div>
                <telerik:RadDatePicker 
                ID="tbEndDate"
                Skin="Windows7"
                AutoPostBack="true"
                MinDate="1/1/2006"
                runat="server">
                    <DateInput ID="diEndDate" runat="server"
                        DateFormat="MM/dd/yyyy"></DateInput>
                </telerik:RadDatePicker>
            </div>
            <div>
                <div>SEO Description:</div>
                <idea:TextBox
                runat="server"
                TextMode="MultiLine"
                Height="195px"
                Width="450px"
                ID="tbSeoDescription" />
            </div><br /><br />
    </div>

    <div id="div1" class="grid_16" style="border-bottom: 1px solid #CCC; ">
        <p style="margin-bottom: 0px !important;">
            <span>Page Content: - <b>To start a new paragraph type &lt;br /&gt;&lt;br /&gt;</b></span><br />
            <asp:TextBox
            runat="server"
            Width="100%"
            ID="tbPageContent"
            Height="450px"
            TextMode="MultiLine" />
         </p><br /><br />
    </div>
</asp:Content>
