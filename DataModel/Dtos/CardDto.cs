using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Dtos
{
  public class CardDto
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public IEnumerable<Comment> Comments { get; set; }
  }
}
