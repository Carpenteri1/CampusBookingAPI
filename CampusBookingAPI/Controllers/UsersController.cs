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
    public class UsersController : ControllerBase
    {
        public readonly CampusApiDbContext context;
        public UsersController(CampusApiDbContext context)
        {
            this.context = context;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Users> GetAllUsers()
        {
            return context.users.ToArray();
        }

        // GET api/<UsersController>/5
        [HttpGet("id={id}")]
        public Users GetUserById(int id)
        {
            return context.users.Where(item => item.Id == id).FirstOrDefault();
        }
        // GET api/<UsersController>/5
        [HttpGet("name={userName}")]
        public Users GetUserByName(string userName)
        {
            return context.users.Where(item => item.userName == userName).FirstOrDefault();
        }
    }
}
