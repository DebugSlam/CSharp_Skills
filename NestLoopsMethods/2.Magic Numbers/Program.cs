int N = int.Parse(Console.ReadLine());
//всяка една стойност на първото число
for (int firstN = 1; firstN <= 9; firstN++)

{

    //всяка една стойност на второто число
    for (int secondN = 0; secondN <= 9; secondN++)
    {
        //всяка една стойност на третото число
        for (int thirdN = 0; thirdN <= 9; thirdN++)
        {
            if (firstN * secondN * thirdN == N)
            {
                Console.Write($"{firstN}{secondN}{thirdN} ");
            }
        }
    }
}