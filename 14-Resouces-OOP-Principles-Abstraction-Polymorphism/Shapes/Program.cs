using System;
namespace Raiding.Models.Heroes;

using Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Uncomment Code");
        int radius = int.Parse(Console.ReadLine()!);
        IDrawable circle = new Circle(radius);

        int width = int.Parse(Console.ReadLine()!);
        int height = int.Parse(Console.ReadLine()!);
        IDrawable rectangle = new Rectangle(width, height);

        Druid hero = new Heroes.Druid("Pesho");

        circle.Draw();
        rectangle.Draw();
    }
}