using CampusBookingAPI.DbContextMysql;
using CampusBookingAPI.Model;
using CampusBookingAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CampusBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly CampusApiDbContext context;
        public BookingsController(CampusApiDbContext context)
        {
            this.context = context;
        }
        // GET: api/<BookingsController>
        [HttpGet]
        public IEnumerable<Bookings> Get()
        {
            var bookings = context.bookings.ToArray();
            var users = context.users.ToArray();
            var rooms = context.rooms.ToArray();

            foreach (var s in bookings)
            {
               s.user = users.Where(item => item.Id == s.user.Id).FirstOrDefault();
               s.Room = rooms.Where(item => item.Id == s.Room.Id).FirstOrDefault();
            }
             
            return bookings;
        }

        // GET api/<BookingsController>/5
        [HttpGet("id={id}")]
        public Bookings Get(int id)
        {
            context.rooms.ToArray();
            context.users.ToArray();
            return context.bookings.Where(item => item.Id == id).FirstOrDefault();
        }

        // POST api/<BookingsController>
        [HttpPost]
        public IActionResult Post(Bookings data) 
        {
            if (data != null)
            {
                data.user = context.users.Where(item => item.userName == data.user.userName).FirstOrDefault();
                data.Room = context.rooms.Where(item => item.roomName == data.Room.roomName).FirstOrDefault();
                context.bookings.Add(data);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound(new { message = "Post was null" });
            }
          
        }
    }
}
