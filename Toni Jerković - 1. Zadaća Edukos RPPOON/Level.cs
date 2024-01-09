using System.Collections.Generic;

namespace Edukos_RPPOON_Zadaca_
{
    public class Level
    {
        public string levelName;
        public List<Student> students;
        public Level(string levelName)
        {
            students = new List<Student>();
            this.levelName = levelName;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public void ShowLevelGrades()
        {
            foreach (Student student in students)
            {
                student.ShowGrades();
            }
        }
    }
}

