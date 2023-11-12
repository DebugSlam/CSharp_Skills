using System.Text.RegularExpressions;
string text = Console.ReadLine();


string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}\b";

Regex regex = new Regex(pattern);
Match match = regex.Match(text);

MatchCollection matches = regex.Matches(text);



Console.WriteLine(string.Join(", ", matches));
//Console.WriteLine(match.Groups.Count);
//Console.WriteLine("{0}", match.Groups[0]);

//Console.WriteLine("Name: \" {0}\"", match.Groups[1]);
//Console.WriteLine("Name: \" {0}\"", match.Groups[2]);