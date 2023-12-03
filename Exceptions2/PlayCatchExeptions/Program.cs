using System;
using System.Linq;

namespace PlayCatchExeptions;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        
        int numOfExeptions = 0;

        while (numOfExeptions < 3)
        {
            string commandLine = Console.ReadLine();
            string[] commandParameters = commandLine.Split(" ");
            string command = commandParameters[0];

            
            try
            {
                int index = int.Parse(commandParameters[1]);

                if (command == "Replace")
                {


                    int element = int.Parse(commandParameters[2]);

                    numbers[index] = element;


                }

                else if (command == "Print")
                {


                    int endIndex = int.Parse(commandParameters[2]);
                    string result = "";

                    for (int x = index; x <= endIndex; x++)
                    {
                        
                        result += numbers[x].ToString();
                        if (x < endIndex)
                        { result += ", "; }

                 
                    }
                        Console.WriteLine(result);
                    
                }
                else if (command == "Show")
                {

                    Console.WriteLine(numbers[index]);
                }
            }

            catch (FormatException)
            {
                numOfExeptions++;
                Console.WriteLine("The variable is not in the correct format!");
            }

            catch (IndexOutOfRangeException)
            {

                numOfExeptions++;
                Console.WriteLine("The index does not exist!");
            }

          
        }

        Console.WriteLine(string.Join(", ", numbers));


    }
}

