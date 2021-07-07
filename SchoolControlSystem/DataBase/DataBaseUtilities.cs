using SchoolControlSystem.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SchoolControlSystem.DataBase.Interfaces;

namespace SchoolControlSystem.DataBase
{
    public class DataBaseUtilities
    {
        IStudentDataBase studentDataBase;
        ICourseDataBase courseDataBase;
        IInstructorDataBase instructorDataBase;

        public DataBaseUtilities(IStudentDataBase studentDataBase, ICourseDataBase courseDataBase, IInstructorDataBase instructorDataBase)
        {
            this.studentDataBase = studentDataBase;
            this.courseDataBase = courseDataBase;
            this.instructorDataBase = instructorDataBase;
        }
        public void FillAllDataBases()
        {
            studentDataBase.FillStudentDataBase();
            instructorDataBase.FillInstructorDataBase();
            courseDataBase.FillCourseDataBase(instructorDataBase.GetInstructors());
        }
    }
}
