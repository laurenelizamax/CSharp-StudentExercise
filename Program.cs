using System;
using System.Collections.Generic;
using System.Linq;

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

                Cohort cohort33 = new Cohort("Cohort 33");
                Cohort cohort34 = new Cohort("Cohort 34");
                Cohort cohort35 = new Cohort("Cohort 35");

                List<Cohort> cohorts = new List<Cohort>()
                {
                        cohort33,
                        cohort34,
                        cohort35
                };

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

                Student student5 = new Student();
                student5.StudentFirstName = "Phil";
                student5.StudentLastName = "Griswold";
                student5.StudentSlack = "phil";

                List<Student> students = new List<Student>()
                {
                    student1,
                    student2,
                    student3,
                    student4,
                    student5
                };

                // Add students to Cohorts
                cohort33.Students.Add(student1);
                cohort34.Students.Add(student2);
                cohort35.Students.Add(student3);
                cohort35.Students.Add(student4);
                cohort35.Students.Add(student5);

                // List of Instructors

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


                List<Instructor> teachers = new List<Instructor>()
                                {
                                    teacher1,
                                    teacher2,
                                    teacher3
                                };


                // Assigning Instructors to a cohort
                cohort33.Instructors.Add(teacher1);
                cohort34.Instructors.Add(teacher2);
                cohort35.Instructors.Add(teacher3);

                // Assigning exercises to each of the students
                teacher1.assignStudentExercise(student4, fourthEx);
                teacher2.assignStudentExercise(student3, thirdEx);
                teacher3.assignStudentExercise(student2, secondEx);
                teacher3.assignStudentExercise(student1, firstEx);
                teacher3.assignStudentExercise(student4, thirdEx);
                teacher3.assignStudentExercise(student4, firstEx);


                // Display which students are working on which exercises
                foreach (Student student in students)
                {
                    foreach (Exercise exercise in student.Exercises)
                    {
                        Console.WriteLine($"{student.StudentFirstName} {student.StudentLastName}  is working on {exercise.ExerciseName}");
                    }

                }
                Console.WriteLine("=============================");

                // Display Exercises done in Javascript
                var jsExercises = exercises.Where(ex => ex.ExerciseLanguage == "Javascript").ToList();
                Console.WriteLine("List of Exercises in Javascript");
                foreach (Exercise exercise in jsExercises)
                {
                    Console.WriteLine($"{exercise.ExerciseName}");
                }

                // Display Students in Cohort 35
                var studentsIn35 = cohorts.Where(co => co.CohortName == "Cohort 35").SelectMany(c => c.Students)
                .Distinct();
                Console.WriteLine("Students in Cohort 35");
                foreach (var student in studentsIn35)
                {
                    Console.WriteLine($"{student.StudentFirstName}");
                }

                // Display Teachers in Cohort 33
                var teachersIn33 = cohorts.Where(co => co.CohortName == "Cohort 33").SelectMany(c => c.Instructors)
                .Distinct();
                Console.WriteLine("Teachers in Cohort 35");
                foreach (var teacher in teachersIn33)
                {
                    Console.WriteLine($"{teacher.TeachFirstName}");
                }

                Console.WriteLine("====================");

                // Sort students by their last name
                var studentOrder = students.OrderBy(name => name.StudentLastName).ToList();

                foreach (var student in studentOrder)
                {
                    Console.WriteLine($"{student.StudentLastName}");
                }
                Console.WriteLine("====================");

                // Display any students that are NOT assigned an exercise 
                var studentsWOEx = students.Where(ex => ex.Exercises.Count == 0).ToList();

                foreach (var stud in studentsWOEx)
                {
                    Console.WriteLine($"{stud.StudentFirstName}");
                }
                Console.WriteLine("====================");

                // Display the Student working on the most exercises
                var studentWMost = students.Select(s => new
                {
                    firstName = s.StudentFirstName,
                    numOfExercises = s.Exercises.Count()
                }).OrderByDescending(s => s.numOfExercises).FirstOrDefault();

                Console.WriteLine($"{studentWMost.firstName} has {studentWMost.numOfExercises}");

                Console.WriteLine("====================");

                // Display the number of students in each cohort
                var numStudentsInCohorts = cohorts.Select(c => new
                {
                    cohortName = c.CohortName,
                    numOfStudents = c.Students.Count()
                }).ToList();

                foreach (var student in numStudentsInCohorts)
                {
                    Console.WriteLine($"{student.cohortName} has {student.numOfStudents} students.");
                }
            }
        }
    }
}
