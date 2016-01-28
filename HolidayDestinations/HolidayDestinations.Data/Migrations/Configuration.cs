namespace HolidayDestinations.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    public sealed class Configuration : DbMigrationsConfiguration<HolidayDestinationsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HolidayDestinationsDbContext context)
        {
            if (context.Destinations.Any())
            {
                return;
            }

            var seed = new Seed(new Models.User()
            {
                UserName = "BestTrips"
            });

            context.Users.Add(seed.Author);

            context.SaveChanges();

            seed.Categories.ForEach(x => context.Categories.Add(x));

            seed.Locations.ForEach(x => context.Locations.Add(x));

            seed.Destinations.ForEach(x => context.Destinations.Add(x));

            context.SaveChanges();
        }
    }
}
