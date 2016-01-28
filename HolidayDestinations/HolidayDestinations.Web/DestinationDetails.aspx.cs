namespace HolidayDestinations.Web
{
    using System;
    using System.Web.ModelBinding;

    using Microsoft.AspNet.Identity;
    using Ninject;

    using HolidayDestinations.Services.Contracts;

    public partial class DestinationDetails : System.Web.UI.Page
    {
        [Inject]
        public IDestinationsService DestinationsService { get; set; }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Models.Destination fvDestination_GetItem([QueryString]string id)
        {
            int idToSearch;
            if (!int.TryParse(id, out idToSearch) || this.DestinationsService.GetById(idToSearch) == null)
            {
                this.Response.Redirect("/Home.aspx");
                return null;
            }
            return this.DestinationsService.GetById(idToSearch);
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            var currentUserId = this.Page.User.Identity.GetUserId();

        }
    }
}