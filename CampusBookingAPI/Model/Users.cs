using CampusBookingAPI.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusBookingAPI.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public TypeOfAccount typeofAccount { get; set; }
#nullable enable
        public ICollection<Bookings>? bookings{get;set;}
        public ICollection<Ratings>? Rated { get; set; }
#nullable disable    
    }
}
