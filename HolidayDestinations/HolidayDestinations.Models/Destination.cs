namespace HolidayDestinations.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Destination
    {
        private ICollection<Reservation> reservations;

        public Destination()
        {
            this.reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }

        public string PhotoUrl { get; set; }

        public DestinationType DestinationType { get; set; }

        public virtual ICollection<Reservation> Reservations { get { return this.reservations; } set { this.reservations = value; } }
    }
}
