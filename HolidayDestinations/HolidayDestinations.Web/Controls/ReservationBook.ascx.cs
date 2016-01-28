namespace HolidayDestinations.Web.Controls
{
    using System;
    using System.Web.UI;

    using Microsoft.AspNet.Identity;
    using Ninject;

    using HolidayDestinations.Services.Contracts;
    public partial class ReservationBook : System.Web.UI.UserControl
    {
        [Inject]
        public IReservationsService ReservationsService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }
            var currentUserId = this.Page.User.Identity.GetUserId();
            var currentDestinationId = int.Parse(this.Request.QueryString["id"]);
            this.ReservationsService.CreateReservation(currentUserId, currentDestinationId);

            this.Response.Redirect("/Private/Reservations");
        }
    }
}