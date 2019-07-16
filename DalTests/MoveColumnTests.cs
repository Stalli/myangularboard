using System.Collections.Generic;
using System.Linq;
using DAL;
using DataModel;
using DataModel.Dtos;
using NUnit.Framework;

namespace Tests
{
  public class MoveColumnTests
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
    public void GeneralTest()
    {
      data.MoveColumn(new MoveColumnDto(2, 4));

      Assert.AreEqual(1, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(2, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void NeighborsTest()
    {
      data.MoveColumn(new MoveColumnDto(2, 3));

      Assert.AreEqual(1, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(2, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void ToLeftEdgeTest()
    {
      data.MoveColumn(new MoveColumnDto(4, 1));

      Assert.AreEqual(2, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(1, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void FromLeftEdgeTest()
    {
      data.MoveColumn(new MoveColumnDto(1, 4));

      Assert.AreEqual(4, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(1, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(2, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void ToRightEdgeTest()
    {
      data.MoveColumn(new MoveColumnDto(2, 5));

      Assert.AreEqual(1, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(2, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void FromRightEdgeTest()
    {
      data.MoveColumn(new MoveColumnDto(5, 2));

      Assert.AreEqual(1, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(2, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void FromLeftEdgeToRightEdgeTest()
    {
      data.MoveColumn(new MoveColumnDto(1, 5));

      Assert.AreEqual(5, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(1, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(2, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void FromRightEdgeToLeftEdgeTest()
    {
      data.MoveColumn(new MoveColumnDto(5, 1));

      Assert.AreEqual(2, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(1, data.Columns.First(col => col.Id == 5).OrderNo);
    }

    [Test]
    public void NoMoveTest()
    {
      data.MoveColumn(new MoveColumnDto(2, 2));

      Assert.AreEqual(1, data.Columns.First(col => col.Id == 1).OrderNo);
      Assert.AreEqual(2, data.Columns.First(col => col.Id == 2).OrderNo);
      Assert.AreEqual(3, data.Columns.First(col => col.Id == 3).OrderNo);
      Assert.AreEqual(4, data.Columns.First(col => col.Id == 4).OrderNo);
      Assert.AreEqual(5, data.Columns.First(col => col.Id == 5).OrderNo);
    }
  }
}
