<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="CWMAdmin.Website.Page" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
<telerik:RadAjaxManagerProxy ID="rampCartActions" runat="server" >
    <AjaxSettings>
        <telerik:AjaxSetting AjaxControlID="rgPageLinks">
            <UpdatedControls>
                <telerik:AjaxUpdatedControl ControlID="rgPageLinks" LoadingPanelID="RadAjaxLoadingPanel1" />
            </UpdatedControls>
        </telerik:AjaxSetting>
        <telerik:AjaxSetting AjaxControlID="lbSavePage">
            <UpdatedControls>
                <telerik:AjaxUpdatedControl ControlID="mainContent" LoadingPanelID="RadAjaxLoadingPanel1" />
                <telerik:AjaxUpdatedControl ControlID="tbPageContent" LoadingPanelID="RadAjaxLoadingPanel1" />
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
        <p class="col_2 edge" style="margin-right: 225px;">
            <span>Display Name:</span><br />
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbDisplayName" /><br />
            <span>SEO Title:</span><br />
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbSeoTitle" /><br />
            <span>SEO Keywords:</span><br />
            <idea:TextBox
            runat="server"
            TextMode="MultiLine"
            Height="150px"
            Width="450px"
            ID="tbSeoKeywords" /><br />
        </p>
        <p class="col_2">
            <span>Is Active:</span><br />
            <idea:CheckBox
            runat="server"
            ID="cbIsActive" /><br />
            <span>SEO Description:</span><br />
            <idea:TextBox
            runat="server"
            TextMode="MultiLine"
            Height="195px"
            Width="450px"
            ID="tbSeoDescription" /><br />
        </p>
    </div>

    <div id="div1" class="grid_16" style="border-bottom: 1px solid #CCC; ">
        <p style="margin-bottom: 0px !important;">
            <span>Title:</span><br />
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbTitle" /><br />
            <span>Sub Title:</span><br />
            <idea:TextBox
            runat="server"
            Width="450px"
            ID="tbSubTitle" /><br />
            <span>Page Content:</span><br />
            <asp:TextBox
            runat="server"
            Width="100%"
            ID="tbPageContent"
            Height="250px"
            TextMode="MultiLine" />
         </p><br /><br />
    </div>

    <div id="Div2" class="grid_16" style="border-bottom: 1px solid #CCC;">
        <p>
            <telerik:RadGrid
            runat="server"
            ID="rgPageLinks"
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
                        DataField="ImagePath" 
                        HeaderText="Image" 
                        UniqueName="Upload">
                            <ItemTemplate>
                                <telerik:RadBinaryImage 
                                runat="server" 
                                ID="RadBinaryImage1" 
                                ImageUrl='<%#Eval("ImagePath") %>'
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
                        DataField="URL" 
                        HeaderText="URL" 
                        SortExpression="URL"
                        UniqueName="URL">
                            <ItemTemplate>
                                <%# Eval("URL")%>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <idea:TextBox
                                runat="server"
                                Text='<%# Eval("URL") %>'
                                ID="tbURL">
                                </idea:TextBox>
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn 
                        DataField="LinkContent" 
                        HeaderText="Content" 
                        SortExpression="LinkContent"
                        UniqueName="LinkContent">
                            <ItemTemplate>
                                <%# Eval("LinkContent")%>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <idea:TextBox
                                runat="server"
                                Text='<%# Eval("LinkContent") %>'
                                TextMode="MultiLine"
                                Height="100px"
                                Width="350px"
                                ID="tbLinkContent">
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
                                    ToolTip="Edit Link"
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
                                    ToolTip="Delete Link"
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
