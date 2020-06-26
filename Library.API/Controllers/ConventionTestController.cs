using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ConventionTestController : ControllerBase
    {
        // GET: api/<ConventionTestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ConventionTestController>/5
        [HttpGet("{id}")]
        //[ApiConventionMethod(typeof(DefaultApiConventions),
        //    nameof(DefaultApiConventions.Get))]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConventionTestController>
        [HttpPost]
        //[ApiConventionMethod(typeof(CustomConventions),
        //    nameof(CustomConventions.Insert))]
        public void Insert([FromBody] string value)
        {
        }

        // PUT api/<ConventionTestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConventionTestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
