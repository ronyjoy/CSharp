using System;
namespace SampleProblems
{
    public class Student : IComparable<Student>
    {
        public int age { get; set; }
        public string name { get; set; }
        public String grade { get; set; }

        //
        public Student(int age, string name, string grade)
        {
            this.age = age;
            this.name = name;
            this.grade = grade;
        }

        public int CompareTo(Student other)
        {
            return this.name.CompareTo(other.name);
        }
    }
}
