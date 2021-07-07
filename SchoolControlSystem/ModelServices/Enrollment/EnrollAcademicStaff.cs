using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;

namespace SchoolControlSystem.ModelServices.Enrollment
{
    public class EnrollAcademicStaff : IEnrollment
    {
        IAcademicStaffDataBase academicStaffDataBase;

        public string message { get; set; } = "Academic Staff Added";

        public EnrollAcademicStaff(IAcademicStaffDataBase academicStaffDataBase)
        {
            this.academicStaffDataBase = academicStaffDataBase;
        }
        public void Enroll(string name, string birthdate)
        {
            academicStaffDataBase.AddAcademicStaff(new AcademicStaff()
            {
                name = name,
                birthDate = birthdate
            });
        }
    }
}
