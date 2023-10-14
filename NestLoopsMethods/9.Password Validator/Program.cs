
string password = Console.ReadLine();

if (!PasswordLength(password) && LetterAndDigits(password) && !DigitsLessThanTwo(password))
{ Console.WriteLine("Password is valid"); }

else
{
    if (PasswordLength(password))
    {
        Console.WriteLine("Password must be between 6 and 10 characters");

    }

    if (!LetterAndDigits(password))
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    if (DigitsLessThanTwo(password))
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}

static bool LetterAndDigits(string text)
{
    bool lettersAndDigits = true;

    for (int i = 0; i < text.Length; i++)

    {
        char symbol = text[i];

        if (char.IsDigit(symbol) || char.IsLetter(symbol))

        {
            lettersAndDigits = true;
        }
        else
        {
            lettersAndDigits = false;
            break;
        }
    }

    return lettersAndDigits;
}

static bool DigitsLessThanTwo(string text)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)

    {
        char symbol = text[i];
       

        if (char.IsDigit(symbol))

        {
            count++;
        }

    }

    return count < 2;
}

static bool PasswordLength(string password)
{
    if (password.Length <= 5 || password.Length > 10)
    {
        return true;

    }

    return false;
}