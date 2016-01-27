namespace HolidayDestinations.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class HolidayDesitantionsDbContext : IdentityDbContext<User>
    {
        public HolidayDesitantionsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static HolidayDesitantionsDbContext Create()
        {
            return new HolidayDesitantionsDbContext();
        }
    }
}
