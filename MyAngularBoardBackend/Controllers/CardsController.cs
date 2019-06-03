using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DataModel;
using DataModel.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MyAngularBoardBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
      private Data Data { get; set; }
      public CardsController()
      {
        Data = new Data();
      }

        // GET: api/Cards
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cards/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Data.Cards.FirstOrDefault(card => card.Id == id));
        }

        // POST: api/Cards
        [HttpPost]
        public void Post([FromBody] string value)
        {
          var reasd = 1;
        }

        // POST: api/cards/move
        [HttpPost("move")]
        public bool MoveCards([FromBody] MoveCardDto moveCardDto)
        {
          return Data.MoveCard(moveCardDto);
        }

        // PUT: api/Cards/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
