using SchoolControlSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolControlSystem.DataBase
{
    public interface IInstructorDataBase
    {
        void AddInstructor(Instructor instructor);

        void UpdateStudentGrade(int ID, string courseCode, int grade);

        void FillInstructorDataBase();

        List<Instructor> GetInstructors();

        List<Student> GetCourseStudentList(string courseCode);

        List<Student> GetInstructorStudentList(int instructorID);

    }
}
