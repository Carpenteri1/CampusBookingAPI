using CampusBookingAPI.DbContextMysql;
using CampusBookingAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IEnumerable<Bookings>> Get()
        {
            var bookings = context.bookings.ToArray();
            var users = context.users.ToArray();
            var rooms = context.rooms.ToArray();

            foreach (var s in bookings)
            {
               s.user = users.Where(item => item.Id == s.user.Id).FirstOrDefault();
               s.room = rooms.Where(item => item.Id == s.room.Id).FirstOrDefault();
            }
             
            return bookings;
        }

        // GET api/<BookingsController>/5
        [HttpGet("{id}")]
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
            return Ok();
        }

        // PUT api/<BookingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
