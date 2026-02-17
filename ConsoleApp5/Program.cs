using System;

namespace TrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.CourseName = "C# Training";

            Student s1 = new Student
            {
                FirstName = "Kwan",
                LastName = "A",
                StudentID = "65001",
                Faculty = "Computer Science"
            };

            Teacher t1 = new Teacher
            {
                FirstName = "Somchai",
                LastName = "B",
                Position = "Professor"
            };

            c1.Register(s1);
            c1.Register(t1);

            c1.ShowParticipants();

            Console.ReadLine();
        }
    }
}
