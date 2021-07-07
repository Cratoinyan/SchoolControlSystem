using System;
using SchoolControlSystem.Model;

namespace SchoolControlSystem.DataBase
{
    public class StudentDataBase
    {
        public SchoolContext SchoolContext;

        public StudentDataBase(SchoolContext schoolContext)
        {
            this.SchoolContext = schoolContext;
        }
        public void AddStudent(Student student, SchoolContext schoolContext)
        {
            schoolContext.students.Add(student);
        }
        public void FillStudentDataBase()
        {
            for (int i = 0; i < 5; i++)
            {
                SchoolContext.students.Add(new Student()
                {
                    name = "stu" + (i + 1),
                    ID = i + 1,
                    birthDate = DateTime.Now.AddYears(-20).ToShortDateString()
                });
            }
        }
    }
}
