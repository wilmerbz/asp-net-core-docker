using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET: api/<MyController>
        [HttpGet]
        public string Get()
        {
            return "Hello from Docker!" ;
        }

        // GET api/<MyController>/Neo
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return $"Hello, {name}!";
        }

    }
}
