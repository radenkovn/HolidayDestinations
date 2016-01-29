<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDestination.aspx.cs" ValidateRequest="false" Inherits="HolidayDestinations.Web.Private.AddDestination" %>

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
                <asp:TextBox Text="<%#: BindItem.Title %>" ID="fvInsertTitle" runat="server" CssClass="" />
            </label>
            <asp:RequiredFieldValidator ErrorMessage="You cannot post an empty title!" ControlToValidate="fvInsertTitle" runat="server" CssClass="text-danger" />
            <label class="col-md-12 text-info">
                Price:
                <asp:TextBox Text="<%#: BindItem.Price %>" ID="fvInsertPrice" runat="server" />
            </label>
            <asp:RequiredFieldValidator ErrorMessage="You cannot post an empty price!" ControlToValidate="fvInsertPrice" runat="server" CssClass="text-danger" />
            <asp:CustomValidator ErrorMessage="Not a valid price!" OnServerValidate="PriceValidate" ControlToValidate="fvInsertPrice" runat="server" CssClass="text-danger" />
            <div>
                <label class="col-md-12 text-info">
                    Category:               
                    <asp:DropDownList
                        ID="ddlInsertCategory"
                        runat="server"
                        DataTextField="Name"
                        DataValueField="Id"
                        SelectMethod="ddlInsertCategory_GetData"
                        SelectedValue="<%#: BindItem.CategoryId %>"
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
                    <asp:TextBox Text="<%# BindItem.Description %>" ID="fvInsertDescription" runat="server" TextMode="MultiLine" Rows="8" />
                    <asp:FileUpload ID="imageUploadControl" runat="server" />
                </label>
                <asp:RequiredFieldValidator ErrorMessage="You cannot post an empty description!" ControlToValidate="fvInsertDescription" runat="server" CssClass="text-danger" />
                <asp:CustomValidator ErrorMessage="Your description is too short!" OnServerValidate="DesctiptionValidate" ControlToValidate="fvInsertDescription" runat="server" CssClass="text-danger" />
                <asp:CustomValidator ErrorMessage="Not a valid picture!" OnServerValidate="PictureValidate" ControlToValidate="imageUploadControl" runat="server" />
            </div>
            <asp:Button Text="Insert" CommandName="Insert" runat="server" CssClass="btn btn-success" />
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
