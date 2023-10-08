using System;
namespace Csharp_Book_Solutions;
class HelloWorld
{
    static void Main()
    {

        int count = int.Parse(Console.ReadLine());
        double WashMashin = double.Parse(Console.ReadLine()); ;
        int ToyPrice = int.Parse(Console.ReadLine());
        int brother = 0;
        double amountMoney = 10.0;
        double amountToy = 0.0;
        double savedMoney = 0;


        for (int i = count; i > 0; i--)
        {

            if (i % 2 == 0)
            {


                savedMoney += (amountMoney);
                amountMoney += 10;
                brother++;

            }

            else
            {
                amountToy += ToyPrice;
            }


        }

        double N = amountToy + savedMoney - brother - WashMashin;

        if (N >= 0)

        { Console.WriteLine($"Yes! {N:f2}"); }

        else

        { Console.WriteLine($"No! {(Math.Abs(N)):f2}"); }
    }
}