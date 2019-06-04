using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
  public class Card
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int ColumnId { get; set; }
  }
}
