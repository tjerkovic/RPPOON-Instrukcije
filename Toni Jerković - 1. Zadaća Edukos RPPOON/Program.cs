using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukos_RPPOON_Zadaca_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(5, "Ivo", "Ivic", 123098);
            Student student2 = new Student(5, "Ana", "Anic", 345678);
            Teacher teacher1 = new Teacher("Hrvoje", "Hrvic", 123456, new List<string> { "Matemaika", "Informatika" });
            student1.AddGrade(3);
            student2.AddGrade(4);
            student1.AddGrade(5);
            student2.ShowGrades();
            student1.ShowGrades();
            teacher1.AddGradeToStudent(student2, 1);
            teacher1.AddGradeToStudent(student1, 2);
            Principal principal1 = new Principal("Luka", "Lukic", 456098);
            principal1.AddStudent(student1);
            principal1.AddStudent(student2);
            principal1.AddTeacher(teacher1);
            //principal1.RemoveStudent(student1);
            principal1.ShowSchoolGrades();
            Level level = new Level("Level5");
            level.AddStudent(student1);
            teacher1.ShowStudentGrades(level.students);
        }
    }
}

