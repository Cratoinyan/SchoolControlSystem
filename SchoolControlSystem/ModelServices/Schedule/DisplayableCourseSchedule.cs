using Microsoft.EntityFrameworkCore;
using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolControlSystem.ModelServices
{
    class DisplayableCourseSchedule : IGetSchedule
    {
        SchoolContext schoolContext = new SchoolContext();



        public Schedule GetSchedule(string courseCode)
        {
            int i = 0;
            int schoolHours = 9;
            Schedule schedule = new Schedule();
            List<CourseSchedule> courseSchedules;

            Course course = schoolContext.courses
                            .Include(c => c.courseSchedules)
                            .Single(c => c.Code.Equals(courseCode));

            courseSchedules = course.courseSchedules;
            courseSchedules.Sort((x, y) => x.day.CompareTo(y.day));

            foreach (List<string> day in schedule.schedule)
            {
                for (int j = courseSchedules[i].initialHour - schoolHours; j < courseSchedules[i].endHour - schoolHours; j++)
                {
                    day[j] = course.Code;
                }
                i++;
            }

            return schedule;
        }
    }
}
