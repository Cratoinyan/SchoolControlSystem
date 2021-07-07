using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using SchoolControlSystem.ModelServices;
using System.Windows.Forms;
using SchoolControlSystem.Model;

namespace SchoolControlSystem.Forms.StudentService
{
    public partial class ShowCourseList : Form
    {
        StudentServices studentServices;
        public ShowCourseList(StudentServices studentServices)
        {
            this.studentServices = studentServices;
            InitializeComponent();
        }

        private void ShowCourseList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            Int32.TryParse(studentID.Text, out ID);

            controlMessage.Text = "";

            if (Utilities.StudentExists(ID))
            {
                List<Course> courses = studentServices.GetCourseList(ID);

                CourseCode.Items.Clear();
                foreach (var course in courses)
                {
                    CourseCode.Items.Add(course.Code);
                }
            }
            else
            {
                controlMessage.Text = "Student Doesn't Exist";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
