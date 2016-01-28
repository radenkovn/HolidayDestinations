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

        public int CategoryId { get; set; }

        public DateTime Date { get; set; }

        public int LocationId { get; set; }

        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<Reservation> Reservations { get { return this.reservations; } set { this.reservations = value; } }
    }
}
