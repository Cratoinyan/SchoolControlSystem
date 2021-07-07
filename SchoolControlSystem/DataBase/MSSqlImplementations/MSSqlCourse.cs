using Microsoft.EntityFrameworkCore;
using SchoolControlSystem.DataBase.Interfaces;
using SchoolControlSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolControlSystem.DataBase.MSSqlImplementations
{
    class MSSqlCourse : ICourseDataBase
    {
        SchoolContext schoolContext;

        public MSSqlCourse(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        public Course GetCourse(string courseCode)
        {
            return schoolContext.courses.Include(c => c.CourseGrades).Include(c => c.courseSchedules).Include(c => c.instructor).Single(c => c.Code.Equals(courseCode));
        }
        public void AddCourse(Course course)
        {
            schoolContext.courses.Add(course);
        }
        public void FillCourseDataBase(List<Instructor> instructors)
        {
            string courseCode;

            for(int i = 0; i < 5; i++)
            {
                courseCode = "bil" + i + "0" + i;
                schoolContext.courses.Add(new Course()
                {
                    Code = courseCode,
                    instructor = instructors[i]
                });
            }

            FillCourseSchedule();
            schoolContext.SaveChanges();
        }


        public void FillCourseSchedule()
        {
            int initialHour = 9;
            int finishingHour = 11;

            foreach (var course in schoolContext.courses.Include(c => c.courseSchedules).ToList())
            {
                for (int i = 0; i < 7; i++)
                {
                    course.courseSchedules.Add(new CourseSchedule());
                }

                Day dayOfClass = Day.Monday;
                foreach (var day in course.courseSchedules)
                {
                    day.day = dayOfClass;
                    day.initialHour = initialHour;
                    day.endHour = finishingHour;

                    dayOfClass++;
                }

                initialHour++;
                finishingHour++;
            }

            schoolContext.SaveChanges();
        }
    }
}
