namespace HolidayDestinations.Web.Account
{
    using System;
    using System.Linq;
    using System.Web.UI;

    using Microsoft.AspNet.Identity;
    using Ninject;

    using HolidayDestinations.Models;
    using Services.Contracts;
    using MappedModels;
    using System.Collections.Generic;
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
        public IQueryable<ReservationResponseModel> gvReservations_GetData()
        {
            var userId = this.Page.User.Identity.GetUserId();
            var currentReservations = this.ReservationsService.GetAllByUser(userId).ToList().ToList();
            var mappedReservations = new List<ReservationResponseModel>();
            foreach (var reservation in currentReservations)
            {
                mappedReservations.Add(new ReservationResponseModel(reservation));
            }
            var reservationsToReturn = mappedReservations.AsQueryable().OrderByDescending(x => x.DateOfReservation);
            if (reservationsToReturn.Count() == 0)
            {
                this.FailureText.Text = "No Reservations found!";
                this.ErrorMessage.Visible = true;
            }
            return reservationsToReturn;
        }
    }
}