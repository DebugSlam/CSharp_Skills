int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

//всяка една стойност на първото число ЧЕТНО
for (int firstN = 2; firstN <= max1; firstN +=2)

{


    //всяка една стойност на второто число PRIME
    for (int secondN = 1; secondN <= max2; secondN++)
    {

            //всяка една стойност на третото число
            for (int thirdN = 2; thirdN <= max3; thirdN += 2)
            {
                if (secondN == 2 || secondN == 3 || secondN == 5 || secondN == 7)

                {
                    Console.WriteLine($"{firstN}{secondN}{thirdN}");


                }

            }

        
    }
}