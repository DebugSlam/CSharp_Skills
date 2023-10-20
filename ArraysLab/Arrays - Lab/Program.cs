int N = int.Parse(Console.ReadLine());
int[] numbers = new int[N];

for (int index = 0; index < numbers.Length; index++)
{
    numbers[index] = int.Parse(Console.ReadLine());

}
for (int i = numbers.Length-1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}


