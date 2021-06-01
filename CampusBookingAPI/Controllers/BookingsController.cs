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
        public IEnumerable<Bookings> Get()
        {
            return context.bookings.ToArray();
        }

        // GET api/<BookingsController>/5
        [HttpGet("{id}")]
        public Bookings Get(int id)
        {
            return context.bookings.Where(item => item.Id == id).FirstOrDefault();
        }

        // POST api/<BookingsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
