using SchoolControlSystem.DataBase;

namespace SchoolControlSystem.ModelServices
{
    public class AcademicStaffServices
    {
        public IStudentDataBase studentDataBase;
        public IInstructorDataBase instructorDataBase;
        public IAcademicStaffDataBase academicStaffDataBase;

        public AcademicStaffServices(IStudentDataBase studentDataBase
                                    , IInstructorDataBase instructorDataBase
                                    , IAcademicStaffDataBase academicStaffDataBase)
        {
            this.studentDataBase = studentDataBase;
            this.instructorDataBase = instructorDataBase;
            this.academicStaffDataBase = academicStaffDataBase;
        }
    }
}