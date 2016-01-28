<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="HolidayDestinations.Web.Account.Reservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="gvReservations" runat="server"
        ItemType="HolidayDestinations.Web.MappedModels.ReservationResponseModel"
        SelectMethod="gvReservations_GetData"
        AllowPaging="true"
        PageSize="4"
        AllowSorting="true"
        DataKeyNames="Id"
        AutoGenerateColumns="false"
        CssClass="Grid">
        <Columns>
            <asp:BoundField SortExpression="Title" HeaderText="Title" DataField="Title" ControlStyle-CssClass="col-md-3"/>
            <asp:BoundField SortExpression="Price" HeaderText="Price" DataField="Price" />
            <asp:BoundField SortExpression="DateOfReservation" HeaderText="Date" DataField="DateOfReservation" />
            <asp:BoundField SortExpression="Location" HeaderText="Location" DataField="Location" />
        </Columns></asp:GridView>
</asp:Content>
