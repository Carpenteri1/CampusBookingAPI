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
    public class CommentsController : ControllerBase
    {
        private readonly CampusApiDbContext context;
        public CommentsController(CampusApiDbContext context)
        {
            this.context = context;
        }
        // GET: api/<RatingController>
        [HttpGet]
        public IEnumerable<Comments> Get()
        {
            var comments = context.comments.ToArray();
            return comments;
        }

        // GET api/<RatingController>/5
        [HttpGet("{id}")]
        public Comments Get(int id)
        {
            context.rooms.ToArray();
            context.users.ToArray();
            return context.comments.Where(item => item.id == id).FirstOrDefault();
        }

        [HttpPost("{id}")]
        [Route("/{id}")]
        public IActionResult Post([FromBody]Comments comments,[FromRoute] int id)
        {
            if(id > 0)
            {
                try
                {
                    var room = context.rooms.Where(item => item.Id == id).FirstOrDefault();
                    var user = context.users.Where(item => item.Id == 3).FirstOrDefault();
                    context.comments.ToArray();
                    room.comments.Add(comments);
                    user.comments.Add(comments);
                    context.SaveChanges();
                    return Ok();
                    
                }
                catch(Exception e)
                {
                    return NotFound(new { message = $"{e.Message}" });
                }
              
            }
             return NotFound(new { message = "Post was null" });

        }

        [HttpPut]
        
        public IActionResult Put([FromBody]Comments comments)
        {
                try
                {
                   // comments.rating = comments.rating + 1;
                    context.Update(comments);
                    context.SaveChanges();
                    return Ok();
                }
                catch(Exception e)
                {
                    return NotFound(new { message = $"{e.Message}" });
                }
        }

    }
}
