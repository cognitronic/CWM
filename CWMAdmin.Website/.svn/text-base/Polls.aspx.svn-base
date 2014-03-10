<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Polls.aspx.cs" Inherits="CWMAdmin.Website.Polls" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Charting" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <div id="Div2" class="grid_16" style="border-bottom: 1px solid #CCC;">
    
        <p>
        <div style="font-size: 14px;"><strong>Blog:</strong></div>
            <telerik:RadGrid
            runat="server"
            ID="rgPoll"
            AllowPaging="True"
            AutoGenerateColumns="false"
            AllowSorting="True" 
            GridLines="None" 
            ShowStatusBar="true"
            OnItemDataBound="ItemDataBound"
            OnNeedDataSource="NeedDataSource"
            OnItemCommand="ItemCommand"
            ShowFooter="true"
            Skin="Windows7">
                <ClientSettings EnableRowHoverStyle="true">
                </ClientSettings>
                <MasterTableView 
                DataKeyNames="ID"
                CommandItemDisplay="Top"
                CommandItemSettings-AddNewRecordText="Add New Poll"
                ItemStyle-VerticalAlign="Top"
                AlternatingItemStyle-VerticalAlign="Top"
                EnableNoRecordsTemplate="true"
                NoMasterRecordsText="No Polls Found.">
                    <Columns>
                        <telerik:GridTemplateColumn 
                        DataField="Question" 
                        HeaderText="Question" 
                        SortExpression="Question"
                        UniqueName="Question">
                            <ItemTemplate>
                                <%# Eval("Question")%>
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
                        DataField="ID" 
                        HeaderText="Results" 
                        SortExpression="ID"
                        UniqueName="ChartResults">
                            <ItemTemplate>
                                <telerik:RadChart 
                                ID="rcResults" 
                                runat="server" 
                                Width="350" 
                                OnItemDataBound="ChartItemDataBound"
                                Height="270" 
                                DefaultType="Pie"
                                Skin="Vista"
                                AutoLayout="true"
                                ChartTitle-Visible="false"
                                CreateImageMap="false">
                                <Series>
                                    <telerik:ChartSeries Name="Series 1" Type="Pie" DataYColumn="cnt" DataLabelsColumn="Name">
                                    <Appearance LegendDisplayMode="ItemLabels">
                                    </Appearance>
                </telerik:ChartSeries>
                                </Series>
                                <PlotArea Appearance-Dimensions-Width="100%">
                                    <Appearance></Appearance>
                                    <XAxis LayoutMode="Normal" AutoScale="true">
                                    </XAxis>
                                </PlotArea>
                        </telerik:RadChart>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn
                        UniqueName="EditColumn"
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
