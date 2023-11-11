string[] s = Console.ReadLine().Split(" ");

string output = "";

for (int i = 0; i < s.Length; i++)
{
 

    string currentWord = s[i];

        for(int n = 1; n <= currentWord.Length; n++)
        {
        output += currentWord;
            
        }   
}

    Console.WriteLine(output);
