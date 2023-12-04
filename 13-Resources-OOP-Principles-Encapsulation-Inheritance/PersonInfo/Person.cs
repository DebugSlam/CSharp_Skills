using System;
namespace PersonInfo;


public class Person
{
    
    private string _firstName;
    private string _lastName;
    private int _age;

    private const int NAME_MIN = 3;
    // Public properties with private setters
    public string FirstName
    {
        get { return this._firstName; }
        private set
        {
            if (NAME_MIN< 3)

            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN} symbols!");
            }

            this._firstName = value;
        }
    }
    public string LastName
    {
        get { return this._lastName; }
        private set
        {
            if (NAME_MIN < 3)

            {
                throw new ArgumentException($"Last name cannot contain fewer than {NAME_MIN} symbols!");
            }

            this._lastName = value;
        }
    }
    public int Age
    {
        get { return this._age; }
        private set
        {
            if (value <= 0)

            {
                throw new ArgumentException("Age must not be zero or negative integer");
            }

            this._age = value;

        }
    }

    // Constructor to initialize the Person object with values for FirstName, LastName, and Age
    public Person(string firstName, string lastName, int age)
    {
       

        this.FirstName = firstName;

        this.LastName = lastName;

        this.Age = age;
    }

    public override string ToString()
    {
        
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} old."; 
        }
    }
}