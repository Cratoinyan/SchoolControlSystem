using SchoolControlSystem.Model;

namespace SchoolControlSystem.DataBase
{
    public class MSSqlAcademicStaff : IAcademicStaffDataBase
    {
        SchoolContext schoolContext;

        public MSSqlAcademicStaff(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        public void AddAcademicStaff(AcademicStaff academicStaff)
        {
            schoolContext.academicStaffs.Add(academicStaff);
        }
    }
}
