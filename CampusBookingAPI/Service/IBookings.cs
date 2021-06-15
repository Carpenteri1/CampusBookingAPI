using CampusBookingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusBookingAPI.Service
{
    public interface IBookings
    {
        public int Id { get; set; }
        public DateTime timeStart { set; get; }
        public DateTime timeEnd { get; set; }
#nullable enable
        public string? className { get; set; }
        public byte? seatsBooked { get; set; }
        public Rooms? Room { get; set; }
        public Users? user { get; set; }
#nullable disable

    }
}
