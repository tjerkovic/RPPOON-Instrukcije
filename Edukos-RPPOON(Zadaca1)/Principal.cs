using System.Collections.Generic;

namespace Edukos_RPPOON_Zadaca_
{
    class Principal : Person
    {
        public List<Student> students;
        public List<Teacher> teachers;
        public Principal(string firstName, string lastName, int id)
            : base(firstName, lastName, id)
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public void ShowSchoolGrades()
        {
            foreach (Student student in students)
            {
                student.ShowGrades();
            }
        }
    }
}

