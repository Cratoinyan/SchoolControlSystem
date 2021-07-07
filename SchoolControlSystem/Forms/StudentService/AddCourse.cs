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
    public partial class AddCourse : Form
    {
        StudentServices studentServices;
        public AddCourse(StudentServices studentServices)
        {
            this.studentServices = studentServices;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studentID;
            string courseCode = courseCodeText.Text;
            Int32.TryParse(studentIDText.Text, out studentID);
            controlMessage.Text = "";

            if (Utilities.StudentExists(studentID))
            {
                if(Utilities.CourseExists(courseCode))
                {
                    if (studentServices.CourseIsAvaliableToAdd(studentID, courseCode))
                    {
                        studentServices.AddCourse(studentID, courseCode);
                        controlMessage.Text = "Course Added";
                    }
                    else
                    {
                        controlMessage.Text = "Course cannot be added";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
