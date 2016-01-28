namespace HolidayDestinations.Services
{
    using HolidayDestinations.Data.Repositories;
    using HolidayDestinations.Models;
    using HolidayDestinations.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DestinationsService: IDestinationsService
    {
        private IRepository<Destination> destinations;
        public DestinationsService(IRepository<Destination> destinations)
        {
            this.destinations = destinations;
        }
        public IQueryable<Destination> GetLatest()
        {
            var timeToCompare = DateTime.Now;
            return this.destinations.All().Where(x => x.Date > timeToCompare).OrderBy(x => x.Date - timeToCompare);
        }
    }
}
