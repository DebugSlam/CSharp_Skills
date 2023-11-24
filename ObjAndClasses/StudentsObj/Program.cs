using System.Collections.Generic;

namespace ObjAndClasses
{


    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Students> origStudents = new List<Students>();

            while (command != "end")
            {
                string[] studentsStr = command.Split(" ");
                string stdFirstName = studentsStr[0];
                string stdLastName = studentsStr[1];
                int stdAge = int.Parse(studentsStr[2]);
                string stdTown = studentsStr[3];


                Students currentStudent = new Students
                    (
                        stdFirstName,
                        stdLastName,
                        stdAge,
                        stdTown
                    );
                
                origStudents.Add(currentStudent);

                command = Console.ReadLine();

            }

            string typeCommand = Console.ReadLine();


            List<Students> filteredStudents = origStudents
                    .Where(x => x.Town == typeCommand)
                    .ToList();

            foreach (Students student in origStudents)
            {
                Console.WriteLine($"{student.} " +
                    $"{student.SecondName} is {student.Age} years old.");
            }
            
        }

    }

    public class Students
    {
        public Students(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            SecondName = lastName;
            Age = age;
            Town = town;
        }
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

    }
}



