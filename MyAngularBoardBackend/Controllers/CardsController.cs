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
        // GET: api/Cards
        [HttpGet]
        public IEnumerable<CardDto> Get()
        {
          return Data.Instance.Cards;
        }

        // GET: api/Cards/5
        [HttpGet("{id}")]
        public CardDto Get(int id)
        {
          return Data.Instance.Cards.FirstOrDefault(card => card.Id == id);
        }

        // POST: api/Cards
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // POST: api/cards/move
        [HttpPost("move")]
        public bool MoveCards([FromBody] MoveCardDto moveCardDto)
        {
          return Data.Instance.MoveCard(moveCardDto);
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
