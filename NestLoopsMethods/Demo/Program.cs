count int number = int.Parse(Console.ReadLine());

bool isPrime = CheckPrimeNumber(number);

if (isPrime)
{ Console.WriteLine("Is prime"); }

else

    { Console.WriteLine("Is NOT prime"); }


static bool CheckPrimeNumber(int number)
{
    int count = 0;

    for (int i = 1; i <= number; i++)
    {

        if (number % i == 0)
        {
            count++;
        }
    }

    return count == 2;
}
