using System.Diagnostics;

Dictionary<string, List<double>> studentGrade = new();

int count = int.Parse(Console.ReadLine());


for (int i = 0; i < count; i++)
{
    string name = Console.ReadLine();

    double grade = double.Parse(Console.ReadLine());

    if (studentGrade.ContainsKey(name))
    {
        studentGrade[name].Add(grade);
 
    }
    else
    {
        // If the key does not exist, add a new entry to the dictionary
        studentGrade.Add(name, new List<double> { grade });
    }

}
foreach (var pair in studentGrade)
{
    string studentName = pair.Key;
    List<double> grades = pair.Value;

    // Calculate average grade using LINQ
    double averageGrade = grades.Average();

    if (averageGrade >= 4.50)

    Console.WriteLine($"{studentName} -> {averageGrade:F2}");
}

