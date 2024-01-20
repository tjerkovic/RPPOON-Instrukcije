using System;
using System.Collections.Generic;
using System.Linq;

namespace Edukos_RPPOON_Zadaca_
{
    public class Teacher: Person
    {
        public List<string> subjects;
        public Teacher(string firstName, string lastName, int id, List<string> subjects)
            : base(firstName, lastName, id)
        {
            subjects = new List<string>();
            this.subjects = subjects;
        }
        public void AddGradeToStudent(Student student, int grade)
        {
            student.AddGrade(grade);
        }
        public void ShowStudentGrades(List<Student> level)
        {
            foreach (Student student in level)
            {
                student.ShowGrades();
            }
        }
    }
}

