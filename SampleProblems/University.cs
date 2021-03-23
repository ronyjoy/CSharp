using System;
using System.Collections.Generic;

namespace SampleProblems
{
    public class University
    {


        public University()
        {
        }

        public static List<String> getStudentNamesInAlphabeticalOrder()
        {
            //database data
            List<Student> students = new List<Student>();
            students.Add(new Student(26, "Thomas", "A"));
            students.Add(new Student(38, "Sonu", "B"));
            students.Add(new Student(21, "Asha", "A"));
            students.Add(new Student(38, "Joy", "C"));

            students.Sort();
            ///login to make alphabetical order
            ///
            List<String> studentNames = new List<string>();
            foreach(Student student in students)
            {
                studentNames.Add(student.name);
            }

            return studentNames;

        }

        //public static List<String> searchStudentWithAGrade()
        //{

        //}
    }
}
