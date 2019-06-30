using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DataModel;
using DataModel.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAngularBoardBackend.Controllers
{
  [Route("api/[controller]")]
  public class ColumnsController : Controller
  {
    // GET: api/<controller>
    [HttpGet]
    public IEnumerable<ColumnDto> Get()
    {
      return Data.Instance.GetColumns(3);
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<controller>
    [HttpPost]
    public ColumnDto Post([FromBody]ColumnDto value)
    {
      return Data.Instance.AddColumn(value);
    }

    // POST: api/columns/move
    [HttpPost("move")]
    public bool MoveColumns([FromBody] MoveColumnDto moveColumnDto)
    {
      return Data.Instance.MoveColumn(moveColumnDto);
    }

    // PUT api/<controller>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
