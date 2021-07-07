using System.ComponentModel.DataAnnotations;

namespace SchoolControlSystem.Model
{
   public class CourseGrades
    {
        [Key]
        public int Id { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public int grade { get; set; }      
    }
}
