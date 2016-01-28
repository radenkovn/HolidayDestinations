using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayDestinations.Services.Contracts
{
    public interface IReservationsService
    {
        void CreateReservation(string userId, int destinationId);
    }
}
