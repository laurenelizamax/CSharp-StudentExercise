using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentSlack { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Student()
        {
            Exercises = new List<Exercise>();
        }

    }

}