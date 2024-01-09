using System;
using System.Collections.Generic;

namespace Edukos_RPPOON_Zadaca_
{
    public class Student: Person
    {
        public List<int> grades;
        int level;
        public Student(int level, string firstName, string lastName, int id)
            : base(firstName, lastName, id)
        {
            grades = new List<int>();
            this.level = level;
        }
        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }
        public void ShowGrades()
        {
            Console.WriteLine($"\nStudent: {FirstName} {LastName} with grades: {string.Join(", ", grades)}.");
        }
    }
}

