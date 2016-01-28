﻿namespace HolidayDestinations.Services
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
            this.destinations.Add(newDestination);
            this.destinations.SaveChanges();
        }
    }
}
