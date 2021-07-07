using SchoolControlSystem.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolControlSystem.Forms.StudentService
{
    public partial class DropCourse : Form
    {
        StudentServices studentServices;
        public DropCourse(StudentServices studentServices)
        {
            this.studentServices = studentServices;
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            int studentID;
            string courseCode = courseCodeText.Text;
            Int32.TryParse(studentIDText.Text, out studentID);

            if (Utilities.StudentExists(studentID))
            {
                if (Utilities.CourseExists(courseCode))
                {
                    if (studentServices.CourseIsAvaliableToDrop(studentID, courseCode))
                    {
                        studentServices.DropCourse(studentID, courseCode);
                        controlMessage.Text = "Course Dropped";
                    }
                    else
                    {
                        controlMessage.Text = "Course cannot be dropped";
                    }
                }
                else
                {
                    controlMessage.Text = "Course doesn't exist";
                }
            }
            else
            {
                controlMessage.Text = "Student doesn't exist";
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
