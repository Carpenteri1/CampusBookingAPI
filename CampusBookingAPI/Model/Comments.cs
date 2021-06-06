using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusBookingAPI.Model
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public string comment { get; set; }
        public int rating { get; set; }
    }
}
