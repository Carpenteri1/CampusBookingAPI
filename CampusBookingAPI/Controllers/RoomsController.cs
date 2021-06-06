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
    public class RoomsController : ControllerBase
    {
        private readonly CampusApiDbContext context;
        public RoomsController(CampusApiDbContext context)
        {
            this.context = context;
        }
        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Rooms> Get()
        {
            var rooms = context.rooms.ToArray();
            var comments = context.comments.ToArray();

            return rooms;
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public Rooms Get(int id)
        {
            var room = context.rooms.Where(item => item.Id == id).FirstOrDefault();
            var comments = context.comments.ToArray();
            return room;
        }

        // POST api/<RoomsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
