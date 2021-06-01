using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusBookingAPI.Model
{
    public class Bookings
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { set; get; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
#nullable enable
        public string? className { get; set; }
        public byte? seatsBooked { get; set; }
#nullable disable
        public Rooms room { get; set; }
        public Users user { get; set; }

    }
}
