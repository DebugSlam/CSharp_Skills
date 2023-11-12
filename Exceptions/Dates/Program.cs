using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"\b(?<Day>\d{2})([-.\/])(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";

Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(text);

foreach (Match match in matches)
{
 Console.WriteLine($"Day: {match.Groups[2]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");

}