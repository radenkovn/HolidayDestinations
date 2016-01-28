namespace HolidayDestinations.Web.Account
{
    using System;
    using System.Linq;
    using System.Web.UI;

    using Microsoft.AspNet.Identity;
    using Ninject;

    using HolidayDestinations.Models;
    using Services.Contracts;

    public partial class Reservations : Page
    {
        [Inject]
        public IReservationsService ReservationsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Reservation> gvReservations_GetData()
        {
            var userId = this.Page.User.Identity.GetUserId();
            return this.ReservationsService.GetAllByUser(userId);
        }
    }
}