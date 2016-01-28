<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DestinationsPagination.ascx.cs" Inherits="HolidayDestinations.Web.Controls.DestinationsPaging" %>

<asp:DataPager runat="server" PageSize="5">
    <Fields>
        <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-primary" />
        <asp:NumericPagerField />
        <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowNextPageButton="true" ButtonCssClass="btn btn-primary" />
    </Fields>
</asp:DataPager>
