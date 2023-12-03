using System.Xml.Linq;

namespace Exceptions2;
class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int prevNum = 1;

        while (numbers.Count <10 && prevNum < 99)
        {
            try
            {
                int num = ReadNumber(prevNum, 100);

                numbers.Add(num);
                prevNum = num;
            }
          
        
      
            catch (ArgumentException)
            {
            Console.WriteLine($"Your number is not in range {prevNum} - 100!");
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }

            
        }
        Console.WriteLine(string.Join(", ", numbers));
    }

    public static int ReadNumber(int start, int end)
    {
        int num = int.Parse(Console.ReadLine());

        if (num <= start || num >= end)
        { throw new ArgumentException(); }

        return num;


    }


}



