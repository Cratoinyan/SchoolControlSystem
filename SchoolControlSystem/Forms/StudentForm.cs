using SchoolControlSystem.Forms.StudentService;
using SchoolControlSystem.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolControlSystem.Forms
{
    public partial class StudentForm : Form
    {
        StudentServices studentServices;
        public StudentForm(StudentServices studentServices)
        {
            this.studentServices = studentServices;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var showSchedule = new ShowSchedule(studentServices);
            showSchedule.Location = this.Location;
            showSchedule.StartPosition = FormStartPosition.Manual;
            showSchedule.FormClosing += delegate { this.Show(); };
            showSchedule.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var showGrades = new ShowGrades(studentServices);
            showGrades.Location = this.Location;
            showGrades.StartPosition = FormStartPosition.Manual;
            showGrades.FormClosing += delegate { this.Show(); };
            showGrades.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var showCourseList = new ShowCourseList(studentServices);
            showCourseList.Location = this.Location;
            showCourseList.StartPosition = FormStartPosition.Manual;
            showCourseList.FormClosing += delegate { this.Show(); };
            showCourseList.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var addCourse = new AddCourse(studentServices);
            addCourse.Location = this.Location;
            addCourse.StartPosition = FormStartPosition.Manual;
            addCourse.FormClosing += delegate { this.Show(); };
            addCourse.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var dropCourse = new DropCourse(studentServices);
            dropCourse.Location = this.Location;
            dropCourse.StartPosition = FormStartPosition.Manual;
            dropCourse.FormClosing += delegate { this.Show(); };
            dropCourse.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
