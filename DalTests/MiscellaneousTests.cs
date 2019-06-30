using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DataModel;
using NUnit.Framework;

namespace DalTests
{
  public class MiscellaneousTests
  {

    private Data data;

    [SetUp]
    public void Setup()
    {
      data = new Data
      (
        new List<Column>
        {
          new Column
          {
            Id = 1,
            OrderNo = 1,
            Title = "BackendColumnTitleForColumnOne"
          },
          new Column
          {
            Id = 2,
            OrderNo = 2,
            Title = "BackendColumnTitleForColumnTwo"
          },
          new Column
          {
            Id = 3,
            OrderNo = 3,
            Title = "BackendColumnTitleForColumnThree"
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
        },
        new List<Card>
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
          }
        },
        new List<Comment>()
      );
    }

    [Test]
    public void GetColumnsTest()
    {
      var count = 3;

      Assert.GreaterOrEqual(data.Columns.Count(), count);

      var columns = data.GetColumns(count);

      Assert.AreEqual(count, columns.Count());
    }

  }
}
