<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDestination.aspx.cs" Inherits="HolidayDestinations.Web.Private.AddDestination" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvAddDestination"
        runat="server"
        InsertMethod="fvAddDestination_InsertItem"
        ItemType="HolidayDestinations.Models.Destination"
        DefaultMode="Insert">
        <InsertItemTemplate>
            <h3>Title:
               
                <asp:TextBox Text="<%# BindItem.Title %>" ID="fvInsertTitle" runat="server" />
            </h3>
            <p>
                <label class="col-md-12 text-info">
                    Category:               
                    <asp:DropDownList
                        ID="ddlInsertCategory"
                        runat="server"
                        DataTextField="Name"
                        DataValueField="Id"
                        SelectMethod="ddlInsertCategory_GetData"
                        SelectedValue="<%# BindItem.CategoryId %>"
                        CssClass="form-control text-primary">
                    </asp:DropDownList>

                </label>
            </p>

            <p>
                <label class="col-md-12 text-info">
                    Location:               
                    <asp:DropDownList
                        ID="DropDownList1"
                        runat="server"
                        DataTextField="Name"
                        DataValueField="Id"
                        SelectMethod="ddlInsertLocation_GetData"
                        SelectedValue="<%# BindItem.LocationId %>"
                        CssClass="form-control text-primary">
                    </asp:DropDownList>
                </label>
            </p>
            <p>
                Content:               
                <asp:TextBox Text="<%# BindItem.Description %>" ID="tbDescription" runat="server" TextMode="MultiLine" Rows="8" />
                <asp:FileUpload ID="imageUploadControl" runat="server" />
            </p>
            <asp:Button Text="Insert" CommandName="Insert" runat="server" CssClass="btn btn-success" />
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
