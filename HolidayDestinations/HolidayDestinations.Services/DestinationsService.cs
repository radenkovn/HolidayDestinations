namespace HolidayDestinations.Services
{
    using HolidayDestinations.Data.Repositories;
    using HolidayDestinations.Models;
    using HolidayDestinations.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DestinationsService : IDestinationsService
    {
        private const int DefaultLatestCount = 10;
        private const string DefaultPhotoUrl = "https://palacestation.sclv.com/~/media/Images/Page%20Background%20Images/Palace/Hotel/PS_Hotel_KingRoom_new.jpg";
        private const string DefaultDescription = "No description.";
        private IRepository<Destination> destinations;

        public DestinationsService(IRepository<Destination> destinations)
        {
            this.destinations = destinations;
        }
        public IQueryable<Destination> GetLatest()
        {
            var timeToCompare = DateTime.Now;
            return this.destinations.All().Where(x => DbFunctions.DiffDays(timeToCompare, x.Date) > 0).OrderBy(x => x.Date).Take(DefaultLatestCount);
        }

        public Destination GetById(int id)
        {
            return this.destinations.GetById(id);
        }

        public IQueryable<Destination> GetAll()
        {
            return this.destinations.All();
        }

        public void Create(Destination newDestination)
        {
            if (newDestination.PhotoUrl == null)
            {
                newDestination.PhotoUrl = DefaultPhotoUrl;
            }
            if (newDestination.Description == null)
            {
                newDestination.Description = DefaultDescription;
            }
            this.destinations.Add(newDestination);
            this.destinations.SaveChanges();
        }
    }
}
