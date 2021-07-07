using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolControlSystem.Model
{
    public class Course
    {
        [Key]
        public string Code { get; set; }
        public Instructor instructor { get; set; }
        public List<CourseGrades> CourseGrades { get; set; } = new List<CourseGrades>();
        public List<CourseSchedule> courseSchedules { get; set; }  = new List<CourseSchedule>();
    }
}