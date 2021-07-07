using System.ComponentModel.DataAnnotations;

namespace SchoolControlSystem.Model
{
    public class AcademicStaff
    {
        public string name { get; set; }
        [Key]
        public int ID { get; set; }
        public string birthDate { get; set; }
    }
}
