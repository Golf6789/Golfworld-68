using System;

namespace TrainingApp
{
    class GeneralPerson : Person
    {
        public string Company { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"General: {FirstName} {LastName}, Company: {Company}");
        }
    }
}
