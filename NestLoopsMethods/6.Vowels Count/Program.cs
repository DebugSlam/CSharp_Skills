string text = Console.ReadLine();

int cnt = VowelsCount(text);
Console.WriteLine(cnt);

static int VowelsCount(string text)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)

    {
        char symbol = text[i];


        switch (symbol)
        {
            case 'o':
            case 'u':
            case 'e':
            case 'i':
            case 'a':
            case 'O':
            case 'U':
            case 'E':
            case 'I':
            case 'A':
                count++;
                break;
        }



    }
    return count;
}