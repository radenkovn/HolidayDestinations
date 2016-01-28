namespace HolidayDestinations.Web.Cache
{
    using System;
    using Models;
    using System.Linq;

    public static class CachedData
    {
        public static IQueryable<Destination> cachedDestinations;
        public static DateTime cachedDate;
    }
}