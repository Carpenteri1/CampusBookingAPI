using CampusBookingAPI.Data;
using CampusBookingAPI.Data.TestData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusBookingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestDataController : ControllerBase
    {
        private readonly ILogger<TestData> _logger;

        public TestDataController(ILogger<TestData> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<TestData> Get()
        {
            return TestData.GetTestDatas();
        }/*
        [HttpGet]
        [Route("{id}")]
        public TestData Get(int id)
        {
            return TestData.GetTestDataById(id);
        }*/

        public IActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(e.GetHashCode());
            }
        }
        [HttpPost]
        [Route("{id}")]
        public IActionResult Post(int id)
        {
            return Ok();
        }
             
    }
}
