namespace FarmOOPHierarchy;
using FarmOOPHierarchy.Animal;
using FarmOOPHierarchy.Animal.Mammal;
using FarmOOPHierarchy.Animal.Mammal.Feline;
using FarmOOPHierarchy.Food;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entry point");

        Cat cat = new Cat("Sura", "1.1", "Varna", "sphinx");

        Console.WriteLine(cat.Talk());

        Vegetable vegetable = new Vegetable(4);

        cat.Weight += 4 * 0.3;


        Console.WriteLine(cat);
    }

}

