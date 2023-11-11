
string s = Console.ReadLine();

while (s != "end")
{
    
    

    string c = Reverse(s);


    Console.WriteLine($"{s} = {c}");
    s = Console.ReadLine();

}
    static string Reverse(string s)

    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
