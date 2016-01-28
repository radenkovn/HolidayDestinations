<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Destinations.aspx.cs" Inherits="HolidayDestinations.Web.Destinations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="lvDestinations" runat="server"
        DataKeyNames="Id"
        ItemType="HolidayDestinations.Models.Destination"
        SelectMethod="lvDestinations_GetData">
        <LayoutTemplate>
            <br />
            <div>
                <label class="text-primary">Order by: </label>
                <asp:HyperLink NavigateUrl="?orderBy=Date" Text="Date" runat="server" CssClass="btn btn-sm btn-primary"></asp:HyperLink>
                <asp:HyperLink NavigateUrl="?orderBy=Category.Name" Text="Name" runat="server" CssClass="btn btn-sm btn-primary"></asp:HyperLink>
                <asp:HyperLink NavigateUrl="?orderBy=Price" runat="server" Text="Price" CssClass="btn btn-sm btn-primary"></asp:HyperLink>
                <asp:HyperLink NavigateUrl="?orderBy=Location.Name" runat="server" Text="Location" CssClass="btn btn-sm btn-primary"></asp:HyperLink>
            </div>
            <div class="row" id="itemPlaceholder" runat="server"></div>
            <br />
            <br />
            <holidayDestinations:DestinationsPagination runat="server" ID="DestonationsPagination" />

        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-4">
                            <h4 class="text-info">Picture</h4>
                            <img class="col-md-12" src="https://palacestation.sclv.com/~/media/Images/Page%20Background%20Images/Palace/Hotel/PS_Hotel_KingRoom_new.jpg" />
                        </div>
                        <div class="col-md-7">
                            <h3><a href="/DestinationDetails.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a> <small><%#: Item.Category.Name %></small></h3>
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

    </asp:ListView>
</asp:Content>
