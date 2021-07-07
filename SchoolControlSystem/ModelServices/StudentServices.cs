using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;
using System.Collections.Generic;

namespace SchoolControlSystem.ModelServices
{
    public class StudentServices
    {
        public IStudentDataBase studentDataBase;

        public StudentServices(IStudentDataBase studentDataBase)
        {
            this.studentDataBase = studentDataBase;
        }

        public Schedule GetSchedule(IGetSchedule schedule, string code)
        {
            return schedule.GetSchedule(code);
        }

        public List<CourseGrades> GetCourseGrades(int ID)
        {
            return studentDataBase.GetCourseGrades(ID);
        }

        public void AddCourse(int ID, string courseCode)
        {
            studentDataBase.AddCourse(ID, courseCode);
        }

        public void DropCourse(int ID, string courseCode)
        {
            studentDataBase.DropCourse(ID, courseCode);
        }

        public List<Course> GetCourseList(int ID)
        {
            return studentDataBase.GetCourses(ID);
        }

        public bool CourseIsAvaliableToAdd(int ID, string courseCode)
        {
            return studentDataBase.CourseIsAvaliableToAdd(ID, courseCode);
        }

        public bool CourseIsAvaliableToDrop(int ID, string courseCode)
        {
            return studentDataBase.CourseIsAvaliableToDrop(ID, courseCode);
        }
    }
}