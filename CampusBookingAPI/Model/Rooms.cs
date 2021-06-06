using CampusBookingAPI.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusBookingAPI.Model
{
    public class Rooms
    {
        [Key]
        public int Id { get; set; }
        public string roomName { get; set; }
        public string location { get; set; }
        public byte seating { get; set; }
        public RoomType typeOfRoom { get; set; }//meeting or studyroom
#nullable enable
        public string? equipment { get; set; }//what tools do the room have
        public string? description { get; set; }
        public ICollection<Comments>? comments { get; set; }
#nullable disable
    }
}
