using System;

class HelloWorld
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        int SumOdds = 0;
        int SumEven = 0;

        string result = "";

        bool found = false;

        for (int number = number1; number <= number2; number++)
        {
            string numberStr = number.ToString();
            int lengthStr = numberStr.Length; // 6

            SumEven = 0;
            SumOdds = 0;



            for (int n = 0; n < lengthStr; n++)
            {
                char digit = numberStr[n];
                int digitValue = int.Parse(digit.ToString());

                if (n % 2 == 0)
                {
                    SumEven += digitValue;
                }
                else
                {
                    SumOdds += digitValue;
                }
            }

            if (SumEven == SumOdds)
            {
                Console.Write(number + " ");
            }


        }


    }   
}
