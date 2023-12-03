namespace EnterNumbersException;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentException();
            }

            double result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
        catch (ArgumentException)

        {
            Console.WriteLine("Invalid Number!");
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid format.");
        }

        finally
        {

            Console.WriteLine("Goodbye.");
        }



    }
}
}

