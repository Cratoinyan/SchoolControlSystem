using Microsoft.EntityFrameworkCore;
using SchoolControlSystem.Model;

namespace SchoolControlSystem.DataBase
{
    public class SchoolContext : DbContext
    {
        public DbSet<AcademicStaff> academicStaffs { get; set; }
        public DbSet<CourseGrades> courseGrades { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Student> students { get; set; }
        public SchoolContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS;database=University;Trusted_Connection=True;User ID=sa;password=8816vgbyokm;");
        }

    }
}
