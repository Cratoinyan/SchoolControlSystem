using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;

namespace SchoolControlSystem.ModelServices.Enrollment
{
    class EnrollInstructor : IEnrollment
    {
        IInstructorDataBase instructorDataBase;
        public string message { get; set; } = "Instructor Added";

        public EnrollInstructor(IInstructorDataBase instructorDataBase)
        {
            this.instructorDataBase = instructorDataBase;
        }

        public void Enroll(string name, string birthdate)
        {
            instructorDataBase.AddInstructor(new Instructor()
            {
                name = name,
                birthDate = birthdate
            });
        }
    }
}
