namespace HolidayDestinations.Services.Contracts
{
    using HolidayDestinations.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDestinationsService
    {
        IQueryable<Destination> GetLatest();
        Destination GetById(int id);

        IQueryable<Destination> GetAll();

    }
}
