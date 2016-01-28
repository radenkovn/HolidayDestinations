namespace HolidayDestinations.Web.MappedModels
{
    using HolidayDestinations.Models;
    using System;
    public class ReservationResponseModel
    {
        public ReservationResponseModel(Reservation reservation)
        {
            this.Id = reservation.Id;
            this.DateOfReservation = reservation.DateOfReservation;
            this.Title = reservation.Destination.Title;
            this.Price = reservation.Destination.Price;
            this.Location = reservation.Destination.Location.Name;
        }

        public int Id { get; set; }

        public DateTime DateOfReservation { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string Location { get; set; }

    }
}