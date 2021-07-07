using System.ComponentModel.DataAnnotations;

namespace SchoolControlSystem.Model
{
    public class CourseSchedule
    {
        [Key]
        public int Id { get; set; }
        public Course Course { get; set; }
        public Day day { get; set; }
        public int initialHour { get; set; }
        public int endHour { get; set; }
    }
}