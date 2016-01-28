<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="HolidayDestinations.Web.Account.Reservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvReservations" runat="server"
        ItemType="HolidayDestinations.Models.Reservation"
        SelectMethod="gvReservations_GetData"
        AllowPaging="true"
        PageSize="5"
        AllowSorting="true"
        DataKeyNames="Id"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField SortExpression="Destination.Name" HeaderText="Destination" DataField="Destination.Name" />
            <asp:BoundField SortExpression="Destination.Price" HeaderText="Price" DataField="Destination.Price" />
            <asp:BoundField SortExpression="DateOfReservation" HeaderText="Date" DataField="DateOfReservation" />
        </Columns></asp:GridView>
</asp:Content>
