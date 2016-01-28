namespace HolidayDestinations.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;
    public class HolidayDestinationsDbContext : IdentityDbContext<User>, IHolidayDestinationsDbContext
    {
        public HolidayDestinationsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Destination> Destinations { get; set; }

        public IDbSet<Reservation> Reservations { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Location> Locations { get; set; }

        public static HolidayDestinationsDbContext Create()
        {
            return new HolidayDestinationsDbContext();
        }
    }
}
