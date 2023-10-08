using System;
class Program
{
    static void Main()
    {

        

        int Period = int.Parse(Console.ReadLine());

        int doctors = 7;

        int PatientsForDay = 0;

        int AmountPatiensCheked = 0;

        int AmountPatiensUncheked = 0;


        for (int i = 1; i <= Period; i++)
        {
            PatientsForDay = int.Parse(Console.ReadLine());


            if (i % 3 == 0)

            {
                if (AmountPatiensUncheked > AmountPatiensCheked)

                { doctors++; }


            }

            if (PatientsForDay > doctors)
            {
                AmountPatiensUncheked += PatientsForDay - doctors;
                AmountPatiensCheked += doctors;
            }

            else
            {
                AmountPatiensCheked += PatientsForDay;
            }


        }

        
            Console.WriteLine($"Treated patients: {AmountPatiensCheked}.");

        Console.WriteLine($"Untreated patients: {AmountPatiensUncheked}.");
    }
}


