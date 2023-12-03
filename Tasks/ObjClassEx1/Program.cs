using static ObjClassEx1.Program;

namespace ObjClassEx1;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string information = Console.ReadLine();

        List<Student> origStudent = new List<Student>();

        for (int i = 0; i < number; i++)
        {
            string[] informationArray = information.Split(" ");
            string firstName = informationArray[0];
            string secondName = informationArray[1];
            double grade = double.Parse(informationArray[2]);

            Student currentStudent = new Student
            (

            firstName,
            secondName,
            grade

            );

            origStudent.Add(currentStudent);


            information = Console.ReadLine();
        }

        List<Student> filterStudent = origStudent.OrderByDescending(x => x.Grade).ToList();

        foreach (Student student in filterStudent)
        {
            Console.WriteLine($"{student.FirstName} " +
                $"{student.SecondName}: {student.Grade:F2}");
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            SecondName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public double Grade { get; set; }

    }
}
