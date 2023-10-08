namespace ddd;
class Program
{
    static void Main(string[] args)
    {
        string input = "101010";

         
        
            char secondChar = input[1]; 
            int secondDigit = int.Parse(secondChar.ToString()); 
            Console.WriteLine(secondDigit); // Output: 0 (assuming the input is "101010")
        

    }
}