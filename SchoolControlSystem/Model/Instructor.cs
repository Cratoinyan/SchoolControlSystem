using SchoolControlSystem.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolControlSystem.Model
{
    public class Instructor
    {
        public string name { get; set; }
        [Key]
        public int ID { get; set; }
        public string birthDate { get; set; }
        public List<Course> course { get; set; } = new List<Course>();
    }
}