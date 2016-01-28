namespace HolidayDestinations.Services
{
    using System.Linq;

    using HolidayDestinations.Services.Contracts;
    using Data.Repositories;
    using Models;
    public class LocationsService : ILocationsService
    {
        private IRepository<Location> locations;
        public LocationsService(IRepository<Location> locations)
        {
            this.locations = locations;
        }

        public IQueryable<Location> GetAll()
        {
            return this.locations.All();
        }
    }
}
