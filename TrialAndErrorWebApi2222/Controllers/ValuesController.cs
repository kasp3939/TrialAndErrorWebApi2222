using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrialAndErrorWebApi2222.Model;

namespace TrialAndErrorWebApi2222.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {        
        // GET api/values
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return Repo.GetAllFlights();            
        }

        // GET api/values/1
        [HttpGet("{id}")]
        public IActionResult GetByIdet(int id)
        {
            return Ok(Repo.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
