using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;

namespace SchoolControlSystem.ModelServices.Enrollment
{
    class EnrollStudent : IEnrollment 
    {
        IStudentDataBase studentDataBase;
        public string message { get; set; } = "Student Added";

        public EnrollStudent(IStudentDataBase studentDataBase)
        {
            this.studentDataBase = studentDataBase;
        }
        public void Enroll(string name, string birthdate)
        {
            studentDataBase.AddStudent(new Student()
            {
                name = name,
                birthDate = birthdate
            });
        }
    }
}
