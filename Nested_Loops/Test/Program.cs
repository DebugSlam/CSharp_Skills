namespace Test;
class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int startRange, endRange;

        if (!int.TryParse(Console.ReadLine(), out startRange) ||
            !int.TryParse(Console.ReadLine(), out endRange) ||
            startRange < 0 || endRange < 0)
        {
            Console.WriteLine("Invalid input. Please enter non-negative integers.");
            return;
        }

        if (startRange > endRange)
        {
            Console.WriteLine("Start range cannot be greater than end range.");
            return;
        }

        int rows = endRange - startRange + 1;
        int cols = (int)Math.Ceiling((double)rows / 10); // Display 10 numbers per row

        // Create a grid to represent numbers in the specified range
        char[,] grid = new char[rows, cols];

        int currentRow = 0, currentCol = 0;

        for (int num = startRange; num <= endRange; num++)
        {
            grid[currentRow, currentCol] = IsPrime(num) ? '*' : ' ';
            currentRow++;

            if (currentRow == rows)
            {
                currentRow = 0;
                currentCol++;
            }
        }

        // Print the grid
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(grid[row, col]);
            }
            Console.WriteLine();
        }
    }
}