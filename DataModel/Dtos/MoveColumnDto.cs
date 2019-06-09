using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Dtos
{
  public class MoveColumnDto
  {
    public int PreviousColumnOrderNo { get; set; }//1-based (not 0-based)
    public int NewColumnOrderNo { get; set; }//1-based

    public MoveColumnDto(int previous, int newOne)
    {
      PreviousColumnOrderNo = previous;
      NewColumnOrderNo = newOne;
    }
  }
}
