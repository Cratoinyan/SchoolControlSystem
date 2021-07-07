using SchoolControlSystem.DataBase;
using SchoolControlSystem.DataBase.Interfaces;
using SchoolControlSystem.DataBase.MSSqlImplementations;
using SchoolControlSystem.Model;
using SchoolControlSystem.ModelServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolControlSystem
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            SchoolContext schoolContext = new SchoolContext();
            IStudentDataBase studentDataBase = new MSSqlStudent(schoolContext);
            IInstructorDataBase instructorDataBase = new MSSqlInstructor(schoolContext);
            IAcademicStaffDataBase academicStaffDataBase = new MSSqlAcademicStaff(schoolContext);
            ICourseDataBase courseDataBase = new MSSqlCourse(schoolContext);
            DataBaseUtilities dataBaseUtilities = new DataBaseUtilities(studentDataBase, courseDataBase, instructorDataBase);

            AcademicStaffServices academicStaffService = new AcademicStaffServices(studentDataBase
                                                                                , instructorDataBase
                                                                                , academicStaffDataBase);
            InstructorServices instructorServices = new InstructorServices(instructorDataBase);
            StudentServices studentServices = new StudentServices(studentDataBase);

            Application.Run(new MainMenu(academicStaffService, instructorServices, studentServices));
        }
    }
}