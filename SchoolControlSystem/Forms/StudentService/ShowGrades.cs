using SchoolControlSystem.DataBase;
using SchoolControlSystem.Model;
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
    public partial class ShowGrades : Form
    {
        StudentServices studentServices;

        public ShowGrades(StudentServices studentServices)
        {
            this.studentServices = studentServices;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            List<CourseGrades> courseGrades;

            Int32.TryParse(StudentID.Text, out ID);

            controlMessage.Text = "";

            if (Utilities.StudentExists(ID))
            {
                courseGrades = studentServices.GetCourseGrades(ID);

                listView1.Items.Clear();
                foreach (var grade in courseGrades)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { grade.Course.Code, grade.grade.ToString() }));
                }
            }
            else
            {
                controlMessage.Text = "Student doesn't exist";
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
