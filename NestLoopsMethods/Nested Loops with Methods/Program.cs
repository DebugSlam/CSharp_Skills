int N = int.Parse(Console.ReadLine());
//всяка една стойност на първото число
for (int firstN = 2; firstN <= N; firstN +=2)
    //всяка една
{

    //всяка една стойност на второто число
    for (int secondN = 1; secondN <= N; secondN += 2)
    {
        Console.WriteLine($"{firstN}{secondN}{firstN * secondN} ");
       
    }
}

