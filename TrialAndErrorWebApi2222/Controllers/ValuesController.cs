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
        public void ChangeFlight(int _flightNumber, string fromLocation, string toLocation)
        {
            Repo.ChangeFlight(_flightNumber, fromLocation, toLocation);
        }
    }
}
