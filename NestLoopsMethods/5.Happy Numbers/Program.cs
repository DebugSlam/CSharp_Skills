int N = int.Parse(Console.ReadLine());

//{d1}{d2}{d3}  is happy when d1+d2 == d3 + d3 == N

for (int firstN = 1; firstN <= 9; firstN++)

{

    //всяка една стойност на второто число
    for (int secondN = 0; secondN <= 9; secondN++)
    {
        //всяка една стойност на третото число
        for (int thirdN = 0; thirdN <= 9; thirdN++)
        {
            for (int forthN = 0; forthN <= 9; forthN++)
            {
                if (firstN + secondN == N && thirdN + forthN == N)
                {
                    Console.Write($"{firstN}{secondN}{thirdN}{forthN} ");
                }
            }
        }
    }
}