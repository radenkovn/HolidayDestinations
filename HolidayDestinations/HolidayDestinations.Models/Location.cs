using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayDestinations.Models
{
    public class Location
    {
        private ICollection<Destination> destinations;

        public Location()
        {
            this.destinations = new HashSet<Destination>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Destination> Destinations { get { return this.destinations; } set { this.destinations = value; } }
    }
}
