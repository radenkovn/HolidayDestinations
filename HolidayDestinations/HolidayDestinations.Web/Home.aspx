<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HolidayDestinations.Web.Home" %>

<asp:Content ID="HomeContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Destinations</h1>
    <asp:Repeater
        runat="server"
        ID="DestinationsRepeater"
        SelectMethod="DestinationsRepeater_GetData"
        ItemType="HolidayDestinations.Models.Destination">
        <HeaderTemplate>
            <h2>Top Travel Offers</h2>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-4">
                            <h4 class="text-info">Picture</h4>
                            <img class="col-md-12" src="https://palacestation.sclv.com/~/media/Images/Page%20Background%20Images/Palace/Hotel/PS_Hotel_KingRoom_new.jpg" />
                        </div>
                        <div class="col-md-7">
                            <h3><a href="/viewDestination.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a> <small><%#: Item.Category.Name %></small></h3>
                            <p>
                                <%#: Item.Description.Length >= 500 ? Item.Description.Substring(0, 500) + "..." : Item.Description%>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="row">
                        <p>Date:<%# Item.Date %> </p>
                        <div class="text-info">
                            Category: <%#: Item.Category.Name %>
                        </div>
                        <div>
                            Stars: <%#: Item.Category.Rating %>
                        </div>
                        <div class="text-success">
                            Location: <%#: Item.Location.Name %>
                        </div>
                        <div class="text-primary">
                            Price:  <%#: Item.Price %>
                        </div>
                        <div class="text-muted">
                            <i>by <%#: Item.User.UserName %></i>
                        </div>
                    </div>
                </div>

            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
