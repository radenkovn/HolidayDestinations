<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomePagination.ascx.cs" Inherits="HolidayDestinations.Web.Controls.HomePagination" %>
<asp:UpdatePanel runat="server" ID="UpdatePanel">
    <ContentTemplate>
        <div class="text-center">
            <a href="/Home?page=1" class="btn btn-info btn-sm">1</a>
            <a href="/Home?page=2" class="btn btn-info btn-sm">2</a>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
