using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using DataModel;
using DataModel.Dtos;

namespace DAL
{
  public class Data
  {
    private IEnumerable<Column> _columns { get; set; }
    private IEnumerable<Card> _cards { get; set; }

    public Data()
    {
      _columns = new[]
      {
        new Column
        {
          Id = 1,
          OrderNo = 1,
          Title = "ColumnOne"
        },
        new Column
        {
          Id = 2,
          OrderNo = 2,
          Title = "BackendColumnTitleForColumnTwoqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq"
        },
        new Column
        {
          Id = 3,
          OrderNo = 3,
          Title = "ColumnThree"
        },
        new Column
        {
          Id = 4,
          OrderNo = 4,
          Title = "BackendColumnTitleForColumnFour"
        },
        new Column
        {
          Id = 5,
          OrderNo = 5,
          Title = "BackendColumnTitleForColumnFive"
        }
      };

      _cards = new List<Card>
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
          },
          new Card{
            Id = 7,
            Title = "TestCard7",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3
          },
          new Card{
            Id = 8,
            Title = "TestCard8",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3
          },
          new Card{
            Id = 9,
            Title = "TestCard9",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 3
          },
          new Card{
            Id = 10,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4
          },
          new Card{
            Id = 11,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4
          },
          new Card{
            Id = 12,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 4
          },
          new Card{
            Id = 13,
            Title = "TestCard4",
            Description = "4TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5
          },
          new Card{
            Id = 14,
            Title = "TestCard5",
            Description = "5TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5
          },
          new Card{
            Id = 15,
            Title = "TestCard6",
            Description = "6TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 5
          },
        };
    }

    public Data(IEnumerable<Column> columns, IEnumerable<Card> cards)
    {
      _columns = columns;
      _cards = cards;
    }

    public IEnumerable<Card> Cards => _cards;

    public IEnumerable<ColumnDto> Columns => _columns.Select(col => new ColumnDto
    {
      Id = col.Id,
      OrderNo = col.OrderNo,
      Title = col.Title,
      Cards = Cards.Where(car => car.ColumnId == col.Id)
    });

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

    public bool MoveColumn(MoveColumnDto moveColumnDto)
    {
      try
      {
        //change 0-based to 1-based
        moveColumnDto.NewColumnOrderNo++;
        moveColumnDto.PreviousColumnOrderNo++;

        if (moveColumnDto.NewColumnOrderNo == moveColumnDto.PreviousColumnOrderNo)
          return true;

        var column = _columns.FirstOrDefault(col => col.OrderNo == moveColumnDto.PreviousColumnOrderNo);

        if (column == null)
        {
          Log();
          return false;
        }

        column.OrderNo = moveColumnDto.NewColumnOrderNo;
        
        if (moveColumnDto.NewColumnOrderNo > moveColumnDto.PreviousColumnOrderNo)
        {
          _columns.Where(col =>
              col.OrderNo <= moveColumnDto.NewColumnOrderNo &&
              col.OrderNo > moveColumnDto.PreviousColumnOrderNo &&
              col.Id != column.Id)
            .ToList().ForEach(col => { col.OrderNo--; });
        }
        else
        {
          _columns.Where(col =>
              col.OrderNo >= moveColumnDto.NewColumnOrderNo &&
              col.OrderNo < moveColumnDto.PreviousColumnOrderNo &&
              col.Id != column.Id)
            .ToList().ForEach(col => { col.OrderNo++; });
        }
      }
      catch (Exception)
      {
        Log();
        return false;
      }

      return true;
    }

    private void Log()
    {
      //throw new NotImplementedException();
    }
  }
}
