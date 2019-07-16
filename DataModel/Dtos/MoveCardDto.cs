using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Dtos
{
  public class MoveCardDto
  {
    public int CardId { get; set; }
    public int TargetColumnId { get; set; }
  }
}
