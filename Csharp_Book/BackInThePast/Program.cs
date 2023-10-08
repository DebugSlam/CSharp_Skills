using System;
class Program
{
    static void Main()
    {
        
    double GetMoney = double.Parse(Console.ReadLine());

        int YearToLive = int.Parse(Console.ReadLine());

        int age = 18;

        double AmountSpent = 0.0;



        for (int i = 1800; i <= YearToLive; i++)
        {

            
            if (i % 2 == 0)
            { AmountSpent += 12000; }

            else 
            { AmountSpent += 12000 + 50 * age; }

            age++;

        }

        double enough = GetMoney - AmountSpent;

        if (enough >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {enough:f2} dollars left.");
                }

        else
        {
            Console.WriteLine($"He will need {(Math.Abs(enough)):f2} dollars to survive.");
                }
        
    }
}

