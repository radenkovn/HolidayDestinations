﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Destinations.aspx.cs" Inherits="HolidayDestinations.Web.Destinations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="lvDestinations" runat="server"
        DataKeyNames="Id"
        ItemType="HolidayDestinations.Models.Destination"
        SelectMethod="lvDestinations_GetData">
        <LayoutTemplate>
            <asp:HyperLink NavigateUrl="?orderBy=Date" runat="server" CssClass="btn btn-sm btn-info"></asp:HyperLink>
            <asp:HyperLink NavigateUrl="?orderBy=Category.Name" runat="server" CssClass="btn btn-sm btn-info"></asp:HyperLink>
            <asp:HyperLink NavigateUrl="?orderBy=Price" runat="server" CssClass="btn btn-sm btn-info"></asp:HyperLink>
            <asp:HyperLink NavigateUrl="?orderBy=Location.Name" runat="server" CssClass="btn btn-sm btn-info"></asp:HyperLink>

            <div class="row" id="itemPlaceholder" runat="server"></div>
            <br />
            <br />
            <asp:DataPager runat="server" PageSize="5">
                <Fields>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="true"  ShowNextPageButton="false" ButtonCssClass="btn btn-primary"/>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="false"  ShowNextPageButton="true" ButtonCssClass="btn btn-primary"/>
                </Fields>
            </asp:DataPager>
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
