using System;
using System.Xml.Linq;

namespace ObjAndClasses
{
    public class Dog
    {
        public Dog()
        {
            Name = "Default name";
        }


        public Dog (string name, string breed, int age)
            {
            Name = name;
            Breed = breed;
            Age = 1;
            }
        public string Name { get; set; }

        public string Breed { get; set; }


        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name}: Bau Bau");
        }
    }
}

