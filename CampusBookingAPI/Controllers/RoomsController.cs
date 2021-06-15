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
        public IEnumerable<Rooms> GetAllRooms()
        {
            var rooms = context.rooms.ToArray();
            var comments = context.comments.ToArray();

            return rooms;
        }
        // GET api/<RoomsController>/5
        [HttpGet("id={id}")]
        public Rooms GetRoomById(int id)
        {
            var room = context.rooms.Where(item => item.Id == id).FirstOrDefault();
            var comments = context.comments.ToArray();
            return room;
        }
        
        [HttpGet("name={roomName}")]
        public Rooms GetRoomByName(string roomName)
        {
            var room = context.rooms.Where(item => item.roomName == roomName).FirstOrDefault();
            var comments = context.comments.ToArray();
            return room;
        }
    }
}
