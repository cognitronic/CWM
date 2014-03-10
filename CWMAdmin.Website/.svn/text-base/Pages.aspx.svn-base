<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Pages.aspx.cs" Inherits="CWMAdmin.Website.Pages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
<div>
    <telerik:RadGrid
    runat="server"
    ID="rgPages"
    AllowPaging="True"
    AutoGenerateColumns="false"
    AllowSorting="True" 
    GridLines="None" 
    ShowStatusBar="true"
    OnNeedDataSource="NeedDataSource"
    ShowFooter="true"
    Skin="Windows7">
        <ClientSettings EnableRowHoverStyle="true">
        </ClientSettings>
        <MasterTableView 
        DataKeyNames="ID"
        CommandItemDisplay="None"
        EnableNoRecordsTemplate="true"
        NoMasterRecordsText="No Pages Found.">
            <Columns>
                <telerik:GridTemplateColumn 
                DataField="Name" 
                HeaderText="Name" 
                SortExpression="Name"
                UniqueName="Name">
                    <ItemTemplate>
                        <%# Eval("Name")%>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn
                HeaderStyle-Width="20px">
                    <ItemTemplate>
                        <idea:LinkButton
                        runat="server"
                        ID="lbEdit"
                        OnClick="EditPageClicked"
                        pageid='<%# Eval("ID").ToString() %>'>
                            <asp:Image
                            runat="server"
                            ID="imgEdit"
                            ToolTip="View Account"
                            ImageUrl="~/img/pencil.png"
                            Style="border: none;" />
                        </idea:LinkButton>
                    </ItemTemplate>
                </telerik:GridTemplateColumn>
            </Columns>
            <PagerStyle Mode="NextPrevAndNumeric"  AlwaysVisible="false" Position="Bottom" />
        </MasterTableView>
    </telerik:RadGrid>
</div>
</asp:Content>
