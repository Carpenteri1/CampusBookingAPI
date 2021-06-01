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
    public class RatingController : ControllerBase
    {
        private readonly CampusApiDbContext context;
        public RatingController(CampusApiDbContext context)
        {
            this.context = context;
        }
        // GET: api/<RatingController>
        [HttpGet]
        public IEnumerable<Ratings> Get()
        {
            return context.rating.ToArray();
        }

        // GET api/<RatingController>/5
        [HttpGet("{id}")]
        public Ratings Get(int id)
        {
            return context.rating.Where(item => item.Id == id).FirstOrDefault();
        }

        // POST api/<RatingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RatingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RatingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
