static string Repeat(string text,int times)
{
    string output = "";
    for (int i = 0; i < times; i++)

    {
        output += text;
    }

    return output;

}



string Text = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = Repeat(Text, count);

Console.WriteLine(result);

