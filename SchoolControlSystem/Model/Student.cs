using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolControlSystem.Model
{
    public class Student
    {
        public string name { get; set; }
        [Key]
        public int ID { get; set; }
        public string birthDate { get; set; }
        public List<CourseGrades> grades { get; set; } = new List<CourseGrades>();
    }
}