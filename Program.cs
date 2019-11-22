using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise list with 4 exercises added to the list
            {
                Exercise firstEx = new Exercise();
                firstEx.ExerciseName = "Basic Website";
                firstEx.ExerciseLanguage = "HTML";

                Exercise secondEx = new Exercise();
                secondEx.ExerciseName = "Website with Style";
                secondEx.ExerciseLanguage = "CSS";

                Exercise thirdEx = new Exercise();
                thirdEx.ExerciseName = "Nutshell with JS";
                thirdEx.ExerciseLanguage = "Javascript";

                Exercise fourthEx = new Exercise();
                fourthEx.ExerciseName = "Nutshell with React";
                fourthEx.ExerciseLanguage = "React";

                List<Exercise> exercises = new List<Exercise>()
                {
                        firstEx,
                        secondEx,
                        thirdEx,
                        fourthEx
                };

                // List of Cohorts
                List<Cohort> cohorts = new List<Cohort>();

                Cohort cohort33 = new Cohort("Cohort 33");
                Cohort cohort34 = new Cohort("Cohort 34");
                Cohort cohort35 = new Cohort("Cohort 35");

                cohorts.Add(cohort33);
                cohorts.Add(cohort34);
                cohorts.Add(cohort35);

                // List of Students

                Student student1 = new Student();
                student1.StudentFirstName = " Dylan";
                student1.StudentLastName = "Pickle";
                student1.StudentSlack = "dylp";

                Student student2 = new Student();
                student2.StudentFirstName = "Shirish";
                student2.StudentLastName = "Shrestha";
                student2.StudentSlack = "shirishshrestha";

                Student student3 = new Student();
                student3.StudentFirstName = "Heidi";
                student3.StudentLastName = "Smith";
                student3.StudentSlack = "heidismith";

                Student student4 = new Student();
                student4.StudentFirstName = "Lauren";
                student4.StudentLastName = "Maxwell";
                student4.StudentSlack = "laureneliza";

                List<Student> students = new List<Student>()
                {
                    student1,
                    student2,
                    student3,
                    student4
                };

                // Add students to Cohorts
                cohort33.Students.Add(student1);
                cohort34.Students.Add(student2);
                cohort35.Students.Add(student3);
                cohort35.Students.Add(student4);

                // List of Instructors
                List<Instructor> teachers = new List<Instructor>();

                Instructor teacher1 = new Instructor();
                teacher1.TeachFirstName = "Madi";
                teacher1.TeachLastName = "Peper";
                teacher1.TeachSlack = "madipeper";
                teacher1.Speciality = "Knows how to explain things";

                Instructor teacher2 = new Instructor();
                teacher2.TeachFirstName = "Mo";
                teacher2.TeachLastName = "Silvera";
                teacher2.TeachSlack = "mo";
                teacher2.Speciality = "joking around";

                Instructor teacher3 = new Instructor();
                teacher3.TeachFirstName = "Adam";
                teacher3.TeachLastName = "Sheaffer";
                teacher3.TeachSlack = "adamsheaf";
                teacher3.Speciality = "Makes sure everyone is understanding";

                teachers.Add(teacher1);
                teachers.Add(teacher2);
                teachers.Add(teacher3);

                // Assigning Instructors to a cohort
                cohort33.Instructors.Add(teacher1);
                cohort34.Instructors.Add(teacher2);
                cohort35.Instructors.Add(teacher3);

                // Assigning exercises to each of the students
                teacher1.assignStudentExercise(student4, fourthEx);
                teacher2.assignStudentExercise(student3, thirdEx);
                teacher3.assignStudentExercise(student2, secondEx);
                teacher3.assignStudentExercise(student1, firstEx);

                // Display which students are working on which exercises
                foreach (Student student in students)
                {
                    foreach (Exercise exercise in student.Exercises)
                    {
                        Console.WriteLine($"{student.StudentFirstName} {student.StudentLastName}  is working on {exercise.ExerciseName}");
                    }

                }

            }
        }
    }
}
