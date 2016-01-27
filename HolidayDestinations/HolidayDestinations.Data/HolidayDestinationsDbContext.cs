namespace HolidayDestinations.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class HolidayDestinationsDbContext : IdentityDbContext<User>, IHolidayDestinationsDbContext
    {
        public HolidayDestinationsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static HolidayDestinationsDbContext Create()
        {
            return new HolidayDestinationsDbContext();
        }
    }
}
