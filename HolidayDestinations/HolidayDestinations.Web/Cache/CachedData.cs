namespace HolidayDestinations.Web.Cache
{
    using System;
    using HolidayDestinations.Models;
    using System.Linq;
    public class CachedData
    {
        private IQueryable<Destination> cachedDestinations;
        private DateTime cachedDate;
    }
}