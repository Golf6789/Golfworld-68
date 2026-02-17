using System;

namespace TrainingApp
{
    class Student : Person
    {
        public string StudentID { get; set; }
        public string Faculty { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, ID: {StudentID}, Faculty: {Faculty}");
        }
    }
}
