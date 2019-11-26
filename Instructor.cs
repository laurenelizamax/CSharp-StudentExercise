using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor : NSSPerson
    {
        public string Slack { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Cohort Cohort { get; set; }
        public string Speciality { get; set; }


        public void assignStudentExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }

    }

}