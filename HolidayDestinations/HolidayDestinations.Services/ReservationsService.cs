﻿namespace HolidayDestinations.Services
{
    using HolidayDestinations.Data.Repositories;
    using HolidayDestinations.Models;
    using HolidayDestinations.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReservationsService : IReservationsService
    {
        private IRepository<Reservation> reservations;
        public ReservationsService(IRepository<Reservation> reservations)
        {
            this.reservations = reservations;
        }

        public void CreateReservation(string userId, int destinationId)
        {
            var reservationToAdd = new Reservation
            {
                UserId = userId,
                DestinationId = destinationId,
                DateOfReservation = DateTime.Now
            };
            this.reservations.Add(reservationToAdd);
            this.reservations.SaveChanges();
        }

        public IQueryable<Reservation> GetAllByUser(string userId)
        {
            return this.reservations.All().Where(x => x.UserId == userId);
        }
    }
}
