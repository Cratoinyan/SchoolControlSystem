using SchoolControlSystem.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SchoolControlSystem.DataBase
{
    public class DataBaseUtilities
    {
        SchoolContext schoolContext;
        CourseDataBase courseDataBase;

        public DataBaseUtilities(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
            courseDataBase = new CourseDataBase(this.schoolContext);
        }
        public void FillAllDataBases()
        {
            string studentName;
            string instructorName;
            string courseCode;

            for(int i = 0; i < 5; i++)
            {
                studentName = "stu" + (i + 1);
                instructorName = "ins" + (i + 1);
                courseCode = "bil" + (i + 1) + "0" + (i + 1);

                schoolContext.students.Add(new Student()
                {
                    name = studentName,
                    birthDate = DateTime.Now.AddYears(-20).ToShortDateString(),

                });

                schoolContext.instructors.Add(new Instructor()
                {
                    name = instructorName,
                    birthDate = DateTime.Now.AddYears(-20).ToShortDateString()
                });

                schoolContext.SaveChanges();

                schoolContext.courses.Add(new Course()
                {
                    Code = courseCode,
                    instructor = schoolContext.instructors.Single(i => i.name.Equals(instructorName))
                });
            }

            courseDataBase.FillCourseSchedules();
            schoolContext.SaveChanges();
        }
    }
}
