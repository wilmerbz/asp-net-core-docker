using HelloAspNetCore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET api/<MyController>/Neo
        [HttpGet("{key}/{value}")]
        public string Set(string key, string value)
        {
            var set = DataManager.Instance.SetValue(key, value);
            return $"{key} : {value} ({set})";
        }

        // GET api/<MyController>/Neo
        [HttpGet("{key}")]
        public string Get(string key)
        {
            var value = DataManager.Instance.GetValue(key);

            return $"{key} : {value}";
        }

    }
}
