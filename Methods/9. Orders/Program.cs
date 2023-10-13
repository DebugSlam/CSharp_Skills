string product = Console.ReadLine();

int quantity = int.Parse(Console.ReadLine());

double Amount = CalculateOrder(product, quantity);

static double CalculateOrder(string prod, int quan)
{
    double sum = 0;
   if (prod == "coffee")
    {
        sum = 1.5 * quan;

    }

   else if (prod == "water")
    {
        sum = 1.00 * quan;

    }

    else if (prod == "coke")
    {
        sum = 1.40 * quan;

    }

    else if (prod == "snacks")
    {
        sum = 2.00 * quan;

    }

    return sum;
}

Console.WriteLine($"{Amount:F2}");


