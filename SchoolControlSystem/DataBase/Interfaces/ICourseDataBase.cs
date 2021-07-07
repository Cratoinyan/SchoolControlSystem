using SchoolControlSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolControlSystem.DataBase.Interfaces
{
    public interface ICourseDataBase
    {
        Course GetCourse(string courseCode);
        void AddCourse(Course course);
        void FillCourseDataBase(List<Instructor> instructors);
        void FillCourseSchedule();
    }
}
