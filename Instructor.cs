using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        public string TeachFirstName { get; set; }
        public string TeachLastName { get; set; }
        public string TeachSlack { get; set; }
        public Cohort Cohort { get; set; }
        public string Speciality { get; set; }

        public void assignStudentExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }

    }

}