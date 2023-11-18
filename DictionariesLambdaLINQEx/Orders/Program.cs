Dictionary<string, double[]> products = new();

string[] input = new string[] { "", "", "" } ;

while (input[0] != "stop")
{
    input = Console.ReadLine().Split().ToArray();
    if (input[0] == "buy")
    {
        break;
    }
    else
    {
        double price = double.Parse(input[1]);

        int quantity = int.Parse(input[2]);

        if (products.ContainsKey(input[0]))
        {
            products[input[0]][0] = price;
            products[input[0]][1] += quantity;
        }
        else
        {
            // If the key does not exist, add a new entry to the dictionary
            products.Add(input[0], new double[] { price, quantity });
        }
    }

}
foreach (var pair in products)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value[0] * pair.Value[1]:F2}");
}