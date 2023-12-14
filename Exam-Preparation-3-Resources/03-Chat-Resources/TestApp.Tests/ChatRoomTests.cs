using System;
using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        //arrange
        string sender = "Petkan";
        string message = "Hello world";

        //act

        this._chatRoom.SendMessage(sender, message);

        //assert

        Assert.That(this._chatRoom.DisplayChat().Contains("Chat Room Messages:"));
        Assert.That(this._chatRoom.DisplayChat().Contains($"{sender}: {message}"));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        //arrange

        //act

        string result = this._chatRoom.DisplayChat();

        //assert


        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        //arrange
        string sender = "Petkan";
        string message = "Hello world";
        string sender2 = "Ivan";
        string message2 = "Hi BG";

        //act
        this._chatRoom.SendMessage(sender, message);
        this._chatRoom.SendMessage(sender2, message2);
        //assert

        Assert.That(this._chatRoom.DisplayChat().Contains("Chat Room Messages:"));
        Assert.That(this._chatRoom.DisplayChat().Contains($"{sender.Trim()}: {message.Trim()}"));
        Assert.That(this._chatRoom.DisplayChat().Contains($"{sender2.Trim()}: {message2.Trim()}"));
    }
}
