using System.Xml.Linq;

string input = "A113735592";
List<object> parsedValues = new List<object>();
int sumEven =  0;

int sumOdd = 0;

foreach (char c in input)
{
    if (char.IsDigit(c))
    {
        // If the character is a digit, parse it as an integer
        parsedValues.Add(int.Parse(c.ToString()));
        
    }
    else
    {
        // If the character is not a digit, parse it as its ASCII value
        parsedValues.Add((int)c);
    }
}

foreach (object value in parsedValues)
{
    string result = string.Join("", parsedValues);
}


//string result = string.Join("", elements);

//