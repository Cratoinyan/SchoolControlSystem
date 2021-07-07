using SchoolControlSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolControlSystem.DataBase
{
    public interface IStudentDataBase
    {
        Student GetStudent(int ID);
        void AddStudent(Student student);
        Schedule GetSchedule(int ID);
        List<CourseGrades> GetCourseGrades(int ID);
        List<Course> GetCourses(int ID);
        void AddCourse(int ID, string courseCode);
        bool CourseIsAvaliableToAdd(int ID, string courseCode);
        void DropCourse(int ID, string courseCode);
        bool CourseIsAvaliableToDrop(int ID, string courseCode);
    }
}
