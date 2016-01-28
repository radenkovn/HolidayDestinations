namespace HolidayDestinations.Services.Contracts
{
    using System.Linq;

    using HolidayDestinations.Models;
    
    public interface IReservationsService
    {
        void CreateReservation(string userId, int destinationId);

        IQueryable<Reservation> GetAllByUser(string userId);
    }
}
