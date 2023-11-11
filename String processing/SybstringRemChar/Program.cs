string searchString = Console.ReadLine();


string inputString = Console.ReadLine();

string output = "";

while (inputString.IndexOf(searchString) >=0)
{

    output = inputString.Replace(searchString, string.Empty);
    inputString = output;
    
}

Console.WriteLine(output);
