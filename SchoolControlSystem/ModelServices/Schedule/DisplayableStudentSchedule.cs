using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;
using System;

namespace SchoolControlSystem.ModelServices
{
    public class DisplayableStudentSchedule : IGetSchedule
    {
        IStudentDataBase studentDataBase;
        public DisplayableStudentSchedule(IStudentDataBase studentDataBase)
        {
            this.studentDataBase = studentDataBase;
        }
        public Schedule GetSchedule(string ID)
        {
            int studentID;

            Int32.TryParse(ID, out studentID);

            return studentDataBase.GetSchedule(studentID);
        }
    }
}
