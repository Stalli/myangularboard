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
    private static Data _instance;
    private List<Column> _columns { get; set; }
    private List<Card> _cards { get; set; }
    private List<Comment> _comments { get; set; }

    private Data()
    {
      _columns = new List<Column>
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

      _comments = new List<Comment>
      {
        new Comment
        {
          Id = 1,
          CardId = 1,
          Text = "Awesome comment"
        },
        new Comment
        {
          Id = 2,
          CardId = 1,
          Text = "Qasdasdasd comment"
        },
        new Comment
        {
          Id = 3,
          CardId = 2,
          Text = "Adadsasdsdsd comment"
        },
        new Comment
        {
          Id = 4,
          CardId = 2,
          Text = "Ffweefefwefwefwefwefwef comment"
        },
        new Comment
        {
          Id = 5,
          CardId = 3,
          Text = "Fwdewdwede comment"
        },
      };
    }

    public static Data Instance => _instance ?? (_instance = new Data());

    public Data(List<Column> columns, List<Card> cards, List<Comment> comments)
    {
      _columns = columns;
      _cards = cards;
      _comments = comments;
    }

    public IEnumerable<ColumnDto> Columns => _columns.Select(col => new ColumnDto
    {
      Id = col.Id,
      OrderNo = col.OrderNo,
      Title = col.Title,
      Cards = _cards.Where(car => car.ColumnId == col.Id)
    });

    public IEnumerable<CardDto> Cards => _cards.Select(car => new CardDto
    {
      Id = car.Id,
      Title = car.Title,
      Description = car.Description,
      ColumnId = car.ColumnId,
      Comments = _comments.Where(com => com.CardId == car.Id)
    });

    public IEnumerable<Comment> Comments => _comments.Select(c => c);

    public IEnumerable<ColumnDto> GetColumns(int count)
    {
      return Columns.Take(count);
    }

    public bool MoveCard(MoveCardDto moveCardDto)
    {
      //var card = Columns.SelectMany(column => column.Cards).FirstOrDefault(c => c.Id == moveCardDto.CardId);

      //var currentColumn = card?.Column;
      //currentColumn?.Cards.ToList().Remove(card);

      //Columns.FirstOrDefault(col => col.Id == moveCardDto.TargetColumnId)?.Cards.ToList().Add(card);

      //return Columns;

      var card = _cards.FirstOrDefault(car => car.Id == moveCardDto.CardId);
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
    }

    public ColumnDto AddColumn(ColumnDto input)
    {
      var id = _columns.Max(col => col.Id) + 1;
      var orderNumber = _columns.Max(col => col.OrderNo) + 1;

      _columns.Add(new Column
      {
        Id = id,
        OrderNo = orderNumber,
        Title = input.Title
      });

      return new ColumnDto
      {
        Id = id,
        OrderNo = orderNumber,
        Title = input.Title
      };
    }

    public Comment AddComment(Comment input)
    {
      input.Id = (_comments.Any() ? _comments.Max(com => com.Id) : 0) + 1;

      _comments.Add(input);

      return input;
    }

    public CardDto AddCard(CardDto input)
    {
      input.Id = _cards.Max(car => car.Id) + 1;

      _cards.Add(new Card
      {
        Id = input.Id,
        ColumnId = input.ColumnId,
        Title = input.Title
      });

      return input;
    }

    public void UpdateCard(CardDto input)
    {
      var card = _cards.FirstOrDefault(c => c.Id == input.Id);

      card.Title = input.Title;
      card.ColumnId = input.ColumnId;
      card.Description = input.Description;


      if (input.Comments == null)
      {
        _comments.RemoveAll(com => com.CardId == input.Id);
      }
      else
      {
        // some comment could be deleted from card at the front, but is still in card.Comments at the backend
        _comments.RemoveAll(com =>
          com.CardId == input.Id &&
          !input.Comments.Select(ic => ic.Id).Contains(com.Id));

        foreach (var comment in input.Comments)
          UpdateComment(comment);
      }
    }

    public void UpdateComment(Comment input)
    {
      var comment = _comments.FirstOrDefault(c => c.Id == input.Id) ?? AddComment(input);

      comment.Text = input.Text;
      comment.CardId = input.CardId;
    }
  }
}
