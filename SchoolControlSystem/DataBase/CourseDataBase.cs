using Microsoft.EntityFrameworkCore;
using SchoolControlSystem.Model;
using System;
using System.Linq;

namespace SchoolControlSystem.DataBase
{
    public class CourseDataBase
    {
        public SchoolContext schoolContext;

        public CourseDataBase(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        public void AddCourse(Course course)
        {
            schoolContext.courses.Add(course);
        }
        public void FillCourseSchedules()
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

            Console.WriteLine();
            schoolContext.SaveChanges();
        }
    }
}
