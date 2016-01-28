<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDestination.aspx.cs" Inherits="HolidayDestinations.Web.Private.AddDestination" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvAddDestination"
        runat="server"
        InsertMethod="fvAddDestination_InsertItem"
        ItemType="HolidayDestinations.Models.Destination"
        DefaultMode="Insert">
        <InsertItemTemplate>
            <br />
            <label class="col-md-12 text-info">
                Title:
                <asp:TextBox Text="<%# BindItem.Title %>" ID="fvInsertTitle"  runat="server" CssClass="" />
            </label>
            <label class="col-md-12 text-info">
                Price:
                <asp:TextBox Text="<%# BindItem.Price %>" ID="TextBox1" runat="server" />
            </label>
            <div>
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
            </div>

            <div>
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
            </div>
            <div>
                <label class="col-md-12 text-info">
                    Content:               
                    <asp:TextBox Text="<%# BindItem.Description %>" ID="tbDescription" runat="server" TextMode="MultiLine" Rows="8" />
                    <asp:FileUpload ID="imageUploadControl" runat="server" />
                </label>
            </div>
            <asp:Button Text="Insert" CommandName="Insert" runat="server" CssClass="btn btn-success" />
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
