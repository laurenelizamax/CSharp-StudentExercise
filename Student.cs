using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student : NSSPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slack { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Student()
        {
            Exercises = new List<Exercise>();
        }

    }

}