using SchoolControlSystem.Model;
using SchoolControlSystem.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolControlSystem.Forms.InstructorService
{
    public partial class ShowCourseStudentList : Form
    {
        InstructorServices instructorServices;

        public ShowCourseStudentList(InstructorServices instructorServices)
        {
            this.instructorServices = instructorServices;
            InitializeComponent();
        }

        private void ShowCourseStudentList_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].TextAlign = HorizontalAlignment.Center;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            List<Student> students;

            listView1.Items.Clear();
            controlMessage.Text = "";

            if(Utilities.CourseExists(courseCodeText.Text))
            {
                students = instructorServices.GetCourseStudentList(courseCodeText.Text);

                foreach(var student in students)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { student.name, student.ID.ToString() }));
                }
            }
            else
            {
                controlMessage.Text = "Course doesn't exist";
            }
        }
    }
}
