<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="CWMAdmin.Website.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <div id="Div2" class="grid_16" style="border-bottom: 1px solid #CCC;">
        <p>
        <div style="font-size: 14px;"><strong>Users:</strong></div>
            <telerik:RadGrid
            runat="server"
            ID="rgUser"
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
                CommandItemSettings-AddNewRecordText="Add New User"
                ItemStyle-VerticalAlign="Top"
                AlternatingItemStyle-VerticalAlign="Top"
                EnableNoRecordsTemplate="true"
                NoMasterRecordsText="No Users Found.">
                    <Columns>
                        <telerik:GridTemplateColumn 
                        DataField="LastName" 
                        HeaderText="Name" 
                        SortExpression="LastName"
                        UniqueName="LastName">
                            <ItemTemplate>
                                <%# Eval("FirstName").ToString() + " " + Eval("LastName").ToString()%>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="Email" 
                        HeaderText="Email" 
                        SortExpression="Email"
                        UniqueName="Email">
                            <ItemTemplate>
                                <%# Eval("Email")%>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="AccessLevel" 
                        HeaderText="Role" 
                        SortExpression="AccessLevel"
                        UniqueName="AccessLevel">
                            <ItemTemplate>
                                <%# Enum.GetName(typeof(CWM.Core.Domain.AccessLevel), Convert.ToInt16(Eval("AccessLevel")))%>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn
                        HeaderStyle-Width="20px">
                            <ItemTemplate>
                                <idea:LinkButton
                                runat="server"
                                ID="lbEdit"
                                CommandName="Edit"
                                blogid='<%# Eval("ID").ToString() %>'>
                                    <asp:Image
                                    runat="server"
                                    ID="imgEdit"
                                    ToolTip="Edit Blog"
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
                                OnClientClick="return confirm('Are you sure you want to delete this record?')"
                                linkid='<%# Eval("ID").ToString() %>'>
                                    <asp:Image
                                    runat="server"
                                    ID="imgDelete"
                                    ToolTip="Delete Blog"
                                    ImageUrl="~/img/delete.png"
                                    Style="border: none;" />
                                </idea:LinkButton>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                    </Columns>
                    <PagerStyle Mode="NextPrevAndNumeric"  AlwaysVisible="false" Position="Bottom" />
                </MasterTableView>
            </telerik:RadGrid>
        </p>
    </div>

</asp:Content>
