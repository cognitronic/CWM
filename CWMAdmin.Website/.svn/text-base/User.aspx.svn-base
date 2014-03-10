<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="CWMAdmin.Website.User" %>
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
        <div>
            <div>Is Active:</div>
            <idea:CheckBox
            runat="server"
            ID="cbIsActive" />
        </div>
        <div>
            <div>First Name:</div>
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbFirstName" />
        </div>
        <div>
            <div>Last Name:</div>
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbLastName" />
        </div>
        <div>
            <div>Email:</div>
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbEmail" />
        </div>
        <div>
            <div>Password:</div>
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbPassword" />
        </div>
        <div>
            <div>Role:</div>
            <idea:DropDownList
            runat="server"
            ID="ddlRole" >
                <Items>
                    <telerik:RadComboBoxItem
                    runat="server"
                    Text="-- Select --"
                    Value="" />
                    <telerik:RadComboBoxItem
                    runat="server"
                    Text="Admin"
                    Value="60" />
                    <telerik:RadComboBoxItem
                    runat="server"
                    Text="Arts Blogger"
                    Value="50" />
                    <telerik:RadComboBoxItem
                    runat="server"
                    Text="Business Blogger"
                    Value="40" />
                    <telerik:RadComboBoxItem
                    runat="server"
                    Text="City Blogger"
                    Value="30" />
                </Items>
            </idea:DropDownList>
        </div>
    </div>
</asp:Content>
