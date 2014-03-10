<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Banners.aspx.cs" Inherits="CWMAdmin.Website.Banners" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
<telerik:RadAjaxManagerProxy ID="rampCartActions" runat="server" >
    <AjaxSettings>
        <telerik:AjaxSetting AjaxControlID="rgBanners">
            <UpdatedControls>
                <telerik:AjaxUpdatedControl ControlID="rgBanners" LoadingPanelID="RadAjaxLoadingPanel1" />
            </UpdatedControls>
        </telerik:AjaxSetting>
    </AjaxSettings>
</telerik:RadAjaxManagerProxy>
<telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Windows7" />
<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

    <script type="text/javascript">
        var uploadedFilesCount = 0;
        var isEditMode;
        function validateRadUpload(source, e)
        {
            // When the RadGrid is in Edit mode the user is not obliged to upload file.

            if (isEditMode == null || isEditMode == undefined)
            {
                e.IsValid = false;

                if (uploadedFilesCount > 0)
                {
                    e.IsValid = true;
                }
            }
            isEditMode = null;
        }

        function OnClientFileUploaded(sender, eventArgs)
        {
            uploadedFilesCount++;
        }
            
    </script>

</telerik:RadCodeBlock>

<div id="Div2" class="grid_16" style="border-bottom: 1px solid #CCC;">
    
        <p>
        <div style="font-size: 14px;"><strong>Banners:</strong></div>
            <telerik:RadGrid
            runat="server"
            ID="rgBanner"
            AllowPaging="True"
            AutoGenerateColumns="false"
            AllowSorting="True" 
            GridLines="None" 
            ShowStatusBar="true"
            OnNeedDataSource="NeedDataSource"
            OnItemCreated="ItemCreated" 
            OnItemCommand="ItemCommand"
            ShowFooter="true"
            Skin="Windows7">
                <ClientSettings EnableRowHoverStyle="true">
                </ClientSettings>
                <MasterTableView 
                DataKeyNames="ID"
                CommandItemDisplay="Top"
                CommandItemSettings-AddNewRecordText="Add New Page Link"
                ItemStyle-VerticalAlign="Top"
                AlternatingItemStyle-VerticalAlign="Top"
                EnableNoRecordsTemplate="true"
                NoMasterRecordsText="No Pages Found.">
                    <Columns>
                        <telerik:GridTemplateColumn 
                        DataField="Path" 
                        HeaderText="Image" 
                        UniqueName="Upload">
                            <ItemTemplate>
                                <telerik:RadBinaryImage 
                                runat="server" 
                                ID="RadBinaryImage1" 
                                ImageUrl='<%#Eval("Path") %>'
                                AutoAdjustImageControlSize="false" 
                                Height="80px" 
                                Width="80px" 
                                ToolTip='<%#Eval("Title", "Photo of {0}") %>'
                                AlternateText='<%#Eval("Title", "Photo of {0}") %>' />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <telerik:RadAsyncUpload 
                                runat="server" 
                                ID="AsyncUpload1" 
                                OnClientFileUploaded="OnClientFileUploaded"
                                AllowedFileExtensions="jpg,jpeg,png,gif"
                                MaxFileSize="1048576"
                                OverwriteExistingFiles="false" 
                                OnValidatingFile="RadAsyncUpload1_ValidatingFile">
                                </telerik:RadAsyncUpload>
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="Title" 
                        HeaderText="Title" 
                        SortExpression="Title"
                        UniqueName="Title">
                            <ItemTemplate>
                                <%# Eval("Title")%>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <idea:TextBox
                                runat="server"
                                Text='<%# Eval("Title") %>'
                                ID="tbTitle">
                                </idea:TextBox>
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="ToolTip" 
                        HeaderText="ToolTip" 
                        SortExpression="ToolTip"
                        UniqueName="ToolTip">
                            <ItemTemplate>
                                <%# Eval("ToolTip")%>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <idea:TextBox
                                runat="server"
                                Text='<%# Eval("ToolTip") %>'
                                ID="tbToolTip">
                                </idea:TextBox>
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="SubText" 
                        HeaderText="Sub Text" 
                        SortExpression="SubText"
                        UniqueName="SubText">
                            <ItemTemplate>
                                <%# Eval("SubText")%>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <idea:TextBox
                                runat="server"
                                Text='<%# Eval("SubText") %>'
                                TextMode="MultiLine"
                                Height="50px"
                                Width="350px"
                                ID="tbSubText">
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
        </p>
    </div>
</asp:Content>
