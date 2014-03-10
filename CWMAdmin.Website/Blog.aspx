<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="CWMAdmin.Website.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
<div id="Div2" class="grid_16" style="border-bottom: 1px solid #CCC;">
    
        <p>
        <div style="font-size: 14px;"><strong>Blog:</strong></div>
            <telerik:RadGrid
            runat="server"
            ID="rgBlog"
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
                CommandItemSettings-AddNewRecordText="Add New Blog Post"
                ItemStyle-VerticalAlign="Top"
                AlternatingItemStyle-VerticalAlign="Top"
                EnableNoRecordsTemplate="true"
                NoMasterRecordsText="No Blog Found.">
                    <Columns>
                        <telerik:GridTemplateColumn 
                        DataField="Title" 
                        HeaderText="Title" 
                        SortExpression="Title"
                        UniqueName="Title">
                            <ItemTemplate>
                                <%# Eval("Title")%>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="PostType" 
                        HeaderText="Post Type" 
                        SortExpression="PostType"
                        UniqueName="PostType">
                            <ItemTemplate>
                                <%# Enum.GetName(typeof(CWM.Core.Domain.BlogPostType), Convert.ToInt16(Eval("PostType")))%>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="StartDate" 
                        HeaderText="Start Date" 
                        SortExpression="StartDate"
                        UniqueName="StartDate">
                            <ItemTemplate>
                                <%# DateTime.Parse(Eval("StartDate").ToString()).ToShortDateString()%>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="EndDate" 
                        HeaderText="End Date" 
                        SortExpression="EndDate"
                        UniqueName="EndDate">
                            <ItemTemplate>
                                <%# DateTime.Parse(Eval("EndDate").ToString()).ToShortDateString()%>
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
