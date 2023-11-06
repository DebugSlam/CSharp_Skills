string input = "D020100021";
int iterations = int.Parse(Console.ReadLine());


string nonNumericPrefix = new string(input.TakeWhile(char.IsLetter).ToArray());

string numericPortion = new string(input.SkipWhile(c => !char.IsDigit(c)).ToArray());

if (int.TryParse(numericPortion, out int number))
{
    for (int i = 1; i<=iterations;i++ )
    { // Increment the number
    number++;

        string incrementedNumericPortion = number.ToString("D" + numericPortion.Length);
        // Create the new string without lead Null losses!
        string newString = nonNumericPrefix + incrementedNumericPortion;

    Console.WriteLine(NewMethod(newString)); // Outputs the increments calling the Method for Check Digit: "A113735593"
    }
}


static string NewMethod(string code)
{
    int sumOdd = (int)code[0];
    int sumEven = 0;
    int numericValue = (int)code[0];

    List<int> digits = code.Where(char.IsDigit)
        .Select(digitChar => int
        .Parse(digitChar.ToString()))
        .ToList();



    for (int i = 0; i < digits.Count; i++)
    {
        int numeric = digits[i];

        if (i % 2 == 0)
        {
            sumEven += numeric;
        }
        else
        {
            sumOdd += numeric;
        }
    }

    int stepD = sumEven * 2 + sumOdd;
    int checkDigit = (10 - stepD % 10) % 10;

    string result = code + checkDigit.ToString();

    return result;
}

