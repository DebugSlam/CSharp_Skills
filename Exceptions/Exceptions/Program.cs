using System.Text.RegularExpressions;

string text = Console.ReadLine();


string pattern = @"([A-Z][a-z]+)[ ]([A-Z][a-z]+)";

Regex regex = new Regex(pattern);
Match match = regex.Match(text);

MatchCollection matches = regex.Matches(text);

foreach (Match match1 in matches)
{
    Console.Write(match1.Value + " ");
}

Console.WriteLine();
Console.WriteLine(match.Groups.Count);
Console.WriteLine("{0}", match.Groups[0]);

Console.WriteLine("Name: \" {0}\"", match.Groups[1]);
Console.WriteLine("Name: \" {0}\"", match.Groups[2]);