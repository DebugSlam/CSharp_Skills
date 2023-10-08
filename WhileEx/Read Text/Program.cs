namespace SumOfNumbers;
class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int vowelWeight = 0;

        for (int i = 0; i < text.Length; i += 1)

        {
            switch (text[i])
            {
                case 'a': vowelWeight += 1; break;
                case 'e': vowelWeight += 2; break;
                case 'i': vowelWeight += 3; break;
                case 'o': vowelWeight += 4; break;
                case 'u': vowelWeight += 5; break;
            }

        }

        Console.WriteLine(vowelWeight);
    }
}
