using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace SumOfIntegersExceptions;
class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();

        List<string> mashUp = new List<string>(line.Split(' '));

        List<int> justIntegers = new List<int>();

        int sum = 0;
        foreach (string i in mashUp)
        {
            try
            {
                int addInt = int.Parse(i);

                justIntegers.Add(addInt);

            }

            catch (OverflowException)
            {
                Console.WriteLine($"The element '{i}' is out of range!");
            }

            catch (FormatException)
            {
                Console.WriteLine($"The element '{i}' is in wrong format!");
            }

            finally
            {
                sum = justIntegers.Sum();
                Console.WriteLine($"Element '{i}' processed - current sum: {sum}");
            }
        }

        
        Console.WriteLine("The total sum of all integers is: " + sum);
    }

}