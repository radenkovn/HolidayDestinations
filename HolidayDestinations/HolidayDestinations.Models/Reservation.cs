namespace HolidayDestinations.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Reservation
    {
        public int Id { get; set; }

        public DateTime DateOfReservation { get; set; }

        public int DestinationId { get; set; }

        [ForeignKey("DestinationId")]
        public virtual Destination Destination { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
