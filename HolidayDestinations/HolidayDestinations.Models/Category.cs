namespace HolidayDestinations.Models
{
    using System.Collections.Generic;

    public class Category
    {
        private ICollection<Destination> destinations;

        public Category()
        {
            this.destinations = new HashSet<Destination>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public CategoryRating Rating { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
