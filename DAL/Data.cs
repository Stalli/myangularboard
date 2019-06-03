using System;
using System.Collections.Generic;
using System.Linq;
using DataModel;
using DataModel.Dtos;

namespace DAL
{
  public class Data
  {
    public Data()
    {
      Columns = new List<Column>
        {
          new Column
          {
            Id = 1,
            Title = "BackendColumnTitleForColumnOne"
          },
          new Column
          {
            Id = 2,
            Title = "BackendColumnTitleForColumnTwo"
          }
        };

      Cards = new List<Card>
        {
          new Card{
            Id = 1,
            Title = "TestCard1",
            Description = "TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1
            },
          new Card{
            Id = 2,
            Title = "TestCard2",
            Description = "2TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1
          },
          new Card{
            Id = 3,
            Title = "TestCard3",
            Description = "3TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1
          },
          new Card{
            Id = 4,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2
          },
          new Card{
            Id = 5,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2
          },
          new Card{
            Id = 6,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 2
          }
        };
    }
    public IEnumerable<Card> Cards { get; set; }
    public IEnumerable<Column> Columns { get; set; }

    public bool MoveCard(MoveCardDto moveCardDto)
    {
      //var card = Columns.SelectMany(column => column.Cards).FirstOrDefault(c => c.Id == moveCardDto.CardId);

      //var currentColumn = card?.Column;
      //currentColumn?.Cards.ToList().Remove(card);

      //Columns.FirstOrDefault(col => col.Id == moveCardDto.TargetColumnId)?.Cards.ToList().Add(card);

      //return Columns;

      var card = Cards.FirstOrDefault(car => car.Id == moveCardDto.CardId);
      if (card == null)
      {
        Log();
        return false;
      }

      card.ColumnId = moveCardDto.TargetColumnId;

      return true;
    }

    private void Log()
    {
      //throw new NotImplementedException();
    }
  }
}
