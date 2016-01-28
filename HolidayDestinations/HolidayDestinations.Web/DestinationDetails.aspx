<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DestinationDetails.aspx.cs" Inherits="HolidayDestinations.Web.DestinationDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="fvDestination"
        SelectMethod="fvDestination_GetItem"
        ItemType="HolidayDestinations.Models.Destination">
        <ItemTemplate>
            <table cellspacing="0" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <td colspan="2">
                            <h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
                            <p>
                                <%#: Item.Description %>
                            </p>
                            <p>
                                <span>Author: <%#: Item.User.UserName %></span>
                                <span class="pull-right text-info">Date: <%# Item.Date %></span>
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td class="row">
                            <img class="col-lg-12" src="https://palacestation.sclv.com/~/media/Images/Page%20Background%20Images/Palace/Hotel/PS_Hotel_KingRoom_new.jpg" />
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <td>
                            <i class="pull-right text-muted">By: <%#: Item.User.UserName %></i>
                        </td>
                    </tr>
                </tfoot>
            </table>
        </ItemTemplate>
    </asp:FormView>
    <asp:LoginView runat="server" ViewStateMode="Disabled">
        <LoggedInTemplate>
            <holidayDestinations:ReservationBook runat="server" ID="ReservationBook"/>
        </LoggedInTemplate>
    </asp:LoginView>
</asp:Content>
