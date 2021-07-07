using SchoolControlSystem.Model;

namespace SchoolControlSystem.DataBase
{
    public class CourseGradesDataBase
    {
        public SchoolContext schoolContext;

        public CourseGradesDataBase(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        public void AddCourseGrade(CourseGrades courseGrades)
        {
            schoolContext.courseGrades.Add(courseGrades);
        }
    }


}
