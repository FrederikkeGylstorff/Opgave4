using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave1;
using Opgave4.managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Opgave4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {

        private IManageFootballPlayers mgr = new ManageFootballPlayer();

        // GET: api/<FootballPlayerController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return mgr.Get();
        }

        // GET api/<FootballPlayerController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<FootballPlayerController>
        [HttpPost]
        public bool Post([FromBody] FootballPlayer value)
        {
            return mgr.Create(value);
        }

        // PUT api/<FootballPlayerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] FootballPlayer value)
        {
            return mgr.Update(id, value);
        }

        // DELETE api/<FootballPlayerController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return mgr.Delete(id);
        }
    }
}
