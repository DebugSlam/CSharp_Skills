
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int middleDigit = (numbers.Count -1) / 2;
int neibDigit = middleDigit + 1;

double result = (numbers[middleDigit] + numbers[neibDigit]) / 2.0;

Console.WriteLine($"{result:F2}");