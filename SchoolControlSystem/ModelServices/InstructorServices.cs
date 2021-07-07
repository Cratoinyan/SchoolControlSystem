using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;
using System.Collections.Generic;

namespace SchoolControlSystem.ModelServices
{
    public class InstructorServices
    {
        IInstructorDataBase instructorDataBase;

        public InstructorServices(IInstructorDataBase instructorDataBase)
        {
            this.instructorDataBase = instructorDataBase;
        }

        public List<Student> GetCourseStudentList(string courseCode)
        {
            return instructorDataBase.GetCourseStudentList(courseCode);
        }

        public List<Student> GetStudentList(int instructorID)
        {
            return instructorDataBase.GetInstructorStudentList(instructorID);
        }

        public void UpdateStudentGrade(int studentID, string courseCode, int grade)
        {
            instructorDataBase.UpdateStudentGrade(studentID, courseCode, grade);
        }
    }
}