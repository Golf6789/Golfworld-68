using System;

namespace TrainingApp
{
    class Teacher : Person
    {
        public string Position { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Teacher: {FirstName} {LastName}, Position: {Position}");
        }
    }
}
