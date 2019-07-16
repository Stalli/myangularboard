using System.Collections.Generic;
using System.Linq;
using DAL;
using DataModel;
using DataModel.Dtos;
using NUnit.Framework;

namespace Tests
{
  public class UpdateCardTests
  {
    private Data data;

    [SetUp]
    public void Setup()
    {
      data = new Data
      (
        new List<Column>(),
        new List<Card>
        {
          new Card
          {
            Id = 1,
            Title = "TestCard1",
            Description =
              "TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
            ColumnId = 1
          }
        },
        new List<Comment>
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
            Text = "2Awesome comment"
          },
          new Comment
          {
            Id = 3,
            CardId = 1,
            Text = "3Awesome comment"
          }
        }
      );
    }

    [Test]
    public void BasicUpdateTest()
    {
      var cardId = 1;
      var newTitle = "Updated title";
      var newDescription = "Updated description";
      var newColumnId = 2;

      data.UpdateCard(new CardDto
      {
        Id = cardId,
        Title = newTitle,
        Description = newDescription,
        ColumnId = newColumnId
      });

      var card = data.Cards.FirstOrDefault(c => c.Id == cardId);

      Assert.NotNull(card);
      Assert.AreEqual(newTitle, card.Title);
      Assert.AreEqual(newDescription, card.Description);
      Assert.AreEqual(newColumnId, card.ColumnId);
    }

    [Test]
    public void AllCommentsRemovedTest()
    {
      var cardId = 1;

      Assert.AreNotEqual(0, data.Comments.Count(c => c.CardId == cardId));

      data.UpdateCard(new CardDto
      {
        Id = cardId
      });

      Assert.AreEqual(0, data.Comments.Count(c => c.CardId == cardId));
    }

    [Test]
    public void CommentsRemovedAndUpdatedTest()
    {
      var cardId = 1;
      var commentId = 1;
      var newCommentText = "Updated comment";

      Assert.AreNotEqual(1, data.Comments.Count(c => c.CardId == cardId));

      data.UpdateCard(new CardDto
      {
        Id = cardId,
        Comments = new List<Comment>
        {
          new Comment
          {
            CardId = commentId,
            Text = newCommentText
          }
        }
      });

      Assert.AreEqual(1, data.Comments.Count(c => c.CardId == cardId));
      Assert.AreEqual(newCommentText, data.Comments.First(c => c.CardId == cardId).Text);
    }

    [Test]
    public void CommentsUpdatedTest()
    {
      var cardId = 1;
      var commentId1 = 1;
      var newCommentText1 = "Updated comment1";
      var commentId2 = 2;
      var newCommentText2 = "Updated comment2";
      var commentId3 = 3;
      var newCommentText3 = "Updated comment3";

      Assert.AreEqual(3, data.Comments.Count(c => c.CardId == cardId));

      data.UpdateCard(new CardDto
      {
        Id = cardId,
        Comments = new List<Comment>
        {
          new Comment
          {
            CardId = cardId,
            Text = newCommentText1
          },
          new Comment
          {
            CardId = cardId,
            Text = newCommentText2
          },
          new Comment
          {
            CardId = cardId,
            Text = newCommentText3
          }
        }
      });

      Assert.AreEqual(3, data.Comments.Count(c => c.CardId == cardId));
      Assert.AreEqual(newCommentText1, data.Comments.First(c => c.CardId == cardId && c.Id == commentId1).Text);
      Assert.AreEqual(newCommentText2, data.Comments.First(c => c.CardId == cardId && c.Id == commentId2).Text);
      Assert.AreEqual(newCommentText3, data.Comments.First(c => c.CardId == cardId && c.Id == commentId3).Text);
    }

    [Test]
    public void NewCommentTest()
    {
      var cardId = 1;
      var newCommentText = "newCommentTitle";

      Assert.AreEqual(0, data.Comments.Count(c => c.CardId == cardId && c.Text == newCommentText));

      data.UpdateCard(new CardDto
      {
        Id = cardId,
        Comments = new List<Comment>
        {
          new Comment
          {
            Text = newCommentText,
            CardId = cardId
          }
        }
      });

      Assert.AreEqual(1, data.Comments.Count(c => c.CardId == cardId));
      Assert.AreEqual(newCommentText, data.Comments.First(c => c.CardId == cardId).Text);
    }
  }
}
