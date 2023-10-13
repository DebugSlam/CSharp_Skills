
static int AreaOfTriangle(int width, int lenght)
    {

    return width * lenght;
}



int width = int.Parse(Console.ReadLine());

int lenght= int.Parse(Console.ReadLine());

int Area = AreaOfTriangle(width, lenght);

Console.WriteLine(Area);