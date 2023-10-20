
int number = int.Parse(Console.ReadLine());

List<string> products = new List<string>(4);

for (int i = 0; i < number;i++)
{

    products.Add(Console.ReadLine());

}

products.Sort();

for (int i = 0; i < number; i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");
}
