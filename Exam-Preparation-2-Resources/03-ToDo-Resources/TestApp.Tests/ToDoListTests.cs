using System;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        //arrange
        string taskTitle = "Go to Work";
        DateTime data = DateTime.Now;

        //act
        this._toDoList.AddTask(taskTitle, data );
        string result = this._toDoList.DisplayTasks();


        //assert
        Assert.That(result.Contains($"[ ] {taskTitle} - Due:"));
        Assert.That(result.Contains("To-Do List:"));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        //arrange
        string taskTitle = "Go to Work";
        DateTime data = DateTime.Now;

        //act
        this._toDoList.AddTask(taskTitle, data);
        this._toDoList.CompleteTask(taskTitle);

        string result = this._toDoList.DisplayTasks();


        //assert
        Assert.That(result.Contains($"[✓] {taskTitle} - Due:"));
        Assert.That(result.Contains("To-Do List:"));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        //arrange
        string taskTitle = "Go to Work";
        DateTime data = DateTime.Now;
        string anotherTask = "Swimming";

        //act
        this._toDoList.AddTask(taskTitle, data);


        // Assert
        Assert.Throws<ArgumentException>(() => this._toDoList.CompleteTask(anotherTask));


    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        //act

        string result = this._toDoList.DisplayTasks();

        //assert

        Assert.That(result, Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        //arrange
        string taskTitle = "Go to Work";
        DateTime data = DateTime.Now;
        string anotherTask = "Swimming";
        DateTime data2 = DateTime.MaxValue;

        //act
        this._toDoList.AddTask(taskTitle, data);

        this._toDoList.AddTask(anotherTask, data2);

        this._toDoList.CompleteTask(taskTitle);

        string result = this._toDoList.DisplayTasks();


        //assert
        Assert.That(result.Contains($"[✓] {taskTitle} - Due:"));
        Assert.That(result.Contains("To-Do List:"));
        Assert.That(result.Contains($"[ ] {anotherTask} - Due:"));
    }
}
