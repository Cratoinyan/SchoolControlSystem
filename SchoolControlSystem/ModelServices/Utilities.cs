using Microsoft.EntityFrameworkCore;
using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;
using System.Linq;

namespace SchoolControlSystem.ModelServices
{
    static class Utilities
    {
        static SchoolContext schoolContext = new SchoolContext();
        static public bool InstructorExists(int ID)
        {
            if (schoolContext.instructors.Find(ID) != null)
            {
                return true;
            }
            return false;
        }
        static public bool CourseExists(string code)
        {
            if (schoolContext.courses.Find(code) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool StudentExists(int studentID)
        {
            if (schoolContext.students.Find(studentID) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool StudentTakesThisCourse(int studentID, string courseCode)
        {
            Student student = schoolContext.students.Include(s => s.grades)
                                                    .ThenInclude(g => g.Course)
                                                    .Single(s => s.ID.Equals(studentID));

            if(student.grades.Exists(g => g.Course.Code.Equals(courseCode)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
