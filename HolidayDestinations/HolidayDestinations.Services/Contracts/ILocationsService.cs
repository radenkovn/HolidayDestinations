namespace HolidayDestinations.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface ILocationsService
    {
        IQueryable<Location> GetAll();
    }
}
