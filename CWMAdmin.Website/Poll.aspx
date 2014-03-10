<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Poll.aspx.cs" Inherits="CWMAdmin.Website.Poll" %>
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
            <div>Question:</div>
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbQuestion" />
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
    </div>
    <div id="div1" class="grid_16" style="border-bottom: 1px solid #CCC; ">
        <p style="margin-bottom: 0px !important;">
            <span>Poll Options:</span><br />
            <telerik:RadGrid
            runat="server"
            ID="rgOptions"
            AllowPaging="True"
            AutoGenerateColumns="false"
            AllowSorting="True" 
            GridLines="None" 
            ShowStatusBar="true"
            OnNeedDataSource="NeedDataSource"
            OnItemCommand="ItemCommand"
            ShowFooter="true"
            Skin="Windows7">
                <ClientSettings EnableRowHoverStyle="true">
                </ClientSettings>
                <MasterTableView 
                DataKeyNames="ID"
                CommandItemDisplay="Top"
                CommandItemSettings-AddNewRecordText="Add New Option"
                ItemStyle-VerticalAlign="Top"
                AlternatingItemStyle-VerticalAlign="Top"
                EnableNoRecordsTemplate="true"
                NoMasterRecordsText="No Options Found.">
                    <Columns>
                        <telerik:GridTemplateColumn 
                        DataField="Name" 
                        HeaderText="Option" 
                        SortExpression="Name"
                        UniqueName="Name">
                            <ItemTemplate>
                                <%# Eval("Name")%>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <idea:TextBox
                                runat="server"
                                Text='<%# Eval("Name") %>'
                                ID="tbName">
                                </idea:TextBox>
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn
                        HeaderStyle-Width="20px">
                            <ItemTemplate>
                                <idea:LinkButton
                                runat="server"
                                ID="lbEdit"
                                CommandName="Edit"
                                linkid='<%# Eval("ID").ToString() %>'>
                                    <asp:Image
                                    runat="server"
                                    ID="imgEdit"
                                    ToolTip="Edit Banner"
                                    ImageUrl="~/img/pencil.png"
                                    Style="border: none;" />
                                </idea:LinkButton>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn
                        HeaderStyle-Width="20px">
                            <ItemTemplate>
                                <idea:LinkButton
                                runat="server"
                                ID="lbDelete"
                                CommandName="Delete"
                                OnClientClick="return confirm('Are you sure you want to delete this link?')"
                                linkid='<%# Eval("ID").ToString() %>'>
                                    <asp:Image
                                    runat="server"
                                    ID="imgDelete"
                                    ToolTip="Delete Banner"
                                    ImageUrl="~/img/delete.png"
                                    Style="border: none;" />
                                </idea:LinkButton>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                    </Columns>
                    <PagerStyle Mode="NextPrevAndNumeric"  AlwaysVisible="false" Position="Bottom" />
                </MasterTableView>
            </telerik:RadGrid>
         </p><br /><br />
    </div>
</asp:Content>
