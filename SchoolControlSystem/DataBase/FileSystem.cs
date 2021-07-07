using SchoolControlSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolControlSystem.DataBase
{
    class FileSystem : IStudentDataBase
    {
        public Student GetStudent(int ID)
        {
            return null;

        }
        public void AddStudent(Student student)
        {

        }
        public Schedule GetSchedule(int ID)
        {
            return null;
        }
        public List<CourseGrades> GetCourseGrades(int ID)
        {
            return null;

        }
        public List<Course> GetCourses(int ID)
        {
            return null;
        }
        public void AddCourse(int ID, string courseCode)
        {

        }
        public bool CourseIsAvaliableToAdd(int ID, string courseCode)
        {
            return true;
        }
        public void DropCourse(int ID, string courseCode)
        {

        }
        public bool CourseIsAvaliableToDrop(int ID, string courseCode)
        {
            return true;
        }
    }
}