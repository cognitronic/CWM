<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageLinksView.ascx.cs" Inherits="CWM.Website.Views.PageLinksView" %>
<div id="internalContent" class="grid_16">
<telerik:RadListView
runat="server"
AllowPaging="false"
ID="dlDetails"
OnNeedDataSource="DetailsNeedDataSource"
Width="100%"
RepeatColumns="3">
    <ItemTemplate>
        <p <%# (Container.DataItemIndex + 1) % 3 == 0 ? "class='right'" : String.Empty %>>
            <a href='<%# Eval("URL") %>' target='_blank'>
                <img src='<%# Eval("ImagePath") %>' style="width: 280px; height: 225px;" alt='<%# Eval("Title") %>' />
            </a>
            <strong><%# Eval("Title") %> </strong><br />
            <%# Eval("LinkContent") %> 
        </p>
    </ItemTemplate>
</telerik:RadListView>
</div>