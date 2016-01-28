namespace HolidayDestinations.Web.Cache
{
    using System;
    using HolidayDestinations.Models;
    public class CachedData
    {
        private IQueryable<Destination> cachedDestinations;
        private DateTime cachedDate;
    }
}