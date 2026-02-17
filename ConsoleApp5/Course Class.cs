using System;
using System.Collections.Generic;

namespace TrainingApp
{
    class Course : ICourse
    {
        public string CourseName { get; set; }

        private List<Person> participants = new List<Person>();

        public void Register(Person person)
        {
            participants.Add(person);
        }

        public void ShowParticipants()
        {
            Console.WriteLine("Participants in " + CourseName);
            foreach (var p in participants)
            {
                p.ShowInfo();
            }
        }
    }
}
