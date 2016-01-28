namespace HolidayDestinations.Web
{
    using System.Data.Entity;

    using HolidayDestinations.Data;
    using HolidayDestinations.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HolidayDestinationsDbContext, Configuration>());

            HolidayDestinationsDbContext.Create().Database.Initialize(true);
        }
    }
}