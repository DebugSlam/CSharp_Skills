string strNumber = "A12345";

List<int> digits = strNumber
    .Where(char.IsDigit)
    .Select(digitChar => int.Parse(digitChar.ToString()))
    .ToList();

List<string> elementsResult = new List<string>();

// Add 'A' as a string to the list
elementsResult.Add(strNumber[0].ToString());

// Filter out non-digit characters and add the remaining digits as strings

// Add 'A' at index 0 of the list

foreach (int item in digits)
{
    elementsResult.Add(item);
}

string result = string.Join("", elementsResult);

Console.WriteLine(result);