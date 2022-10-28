using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiodataController : ControllerBase
    {
        List<Biodata> biodatas = new List<Biodata>() {
            new Biodata("Jojoe", "Backend", 36, "Accountant learning to become a developer")

            };


        // GET: api/<BiodataController>
        [HttpGet]
        public IEnumerable<Biodata> Get()
        {
            return biodatas;
        }

        // GET api/<BiodataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BiodataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BiodataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BiodataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
