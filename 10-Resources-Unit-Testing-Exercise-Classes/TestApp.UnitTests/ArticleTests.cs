using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    // TODO: write the setup method
    private Article _article;
    [SetUp]
    public void SetUp()
    {
        this._article = new Article();

    }

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input = { "Article article1  author1",
            "article2 Content2 author2",
            "Asddsd Asdasd Author3" };


        // Act
        Article result = this._article.AddArticles(input);

        //string result = Article.AddArticles(input);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        var inuptArticle = new Article()
        {
            ArticleList = new()
            { new Article()
            { Author = "Ivan",
                Content = "Some stuff",
                Title = "Test"
            },

                new Article()
                { Author = "Stoyan",
                    Content = "Other things",
                    Title = "Test2"
                }

            }
        };

        string expected = $"Test - Some stuff: Ivan{Environment.NewLine}" +
            $"Test2 - Other things: Stoyan";
        // Act
        string result = this._article.GetArticleList(inuptArticle, "title");

        // Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        var inuptArticle = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Ivan",
                    Content = "Some stuff",
                    Title = "Test"
                },

                new Article()
                {
                    Author = "Stoyan",
                    Content = "Other things",
                    Title = "Test2"
                }

            }

        };
        // Act
        string result = this._article.GetArticleList(inuptArticle, "not-criteria");

        // Assert
        Assert.AreEqual(result, string.Empty);
    }
}
