static int CompareInt(int n1, int n2)
{
    if (n1 > n2)
    {

        return n1;
    }
    else
    { return n2; }
}

static char CompareChar(char n1, char n2)
{
    if (n1 > n2)
    {

        return n1;
    }
    else
    { return n2; }
}
static string CompareString(string n1, string n2)
{
    if (n1.CompareTo(n2) > 0)
    {

        return n1;
    }
    else
    { return n2; }
}


string Type= Console.ReadLine();

if (Type == "int")

{

    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int result = CompareInt(num1, num2);
    Console.WriteLine(result);

}

else if (Type == "char")

{

    char ch1 = char.Parse(Console.ReadLine());
    char ch2 = char.Parse(Console.ReadLine());
    char result = CompareChar(ch1, ch2);
    Console.WriteLine(result);

}

else if (Type == "string")

{

    string ch1 = Console.ReadLine();
    string ch2 = Console.ReadLine();
    string result = CompareString(ch1, ch2);
    Console.WriteLine(result);

}

