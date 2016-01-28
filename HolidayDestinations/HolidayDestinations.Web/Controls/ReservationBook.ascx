<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ReservationBook.ascx.cs" Inherits="HolidayDestinations.Web.Controls.ReservationBook" %>

<asp:UpdatePanel runat="server" ID="UpdatePanel">
    <ContentTemplate>
        <asp:Button Text="Book" ID="btnBook" OnClick="btnBook_Click" runat="server" CssClass="btn btn-primary"></asp:Button>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnBook" EventName="Click" />
    </Triggers>
</asp:UpdatePanel>
