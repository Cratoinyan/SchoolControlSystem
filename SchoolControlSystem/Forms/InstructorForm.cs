using SchoolControlSystem.ModelServices;
using SchoolControlSystem.Forms.InstructorService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolControlSystem.Forms
{
    public partial class InstructorForm : Form
    {
        InstructorServices instructorServices;
        public InstructorForm(InstructorServices instructorServices)
        {
            this.instructorServices = instructorServices;

            InitializeComponent();
        }
        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var showCourseStudentList = new ShowCourseStudentList(instructorServices);
            showCourseStudentList.Location = this.Location;
            showCourseStudentList.StartPosition = FormStartPosition.Manual;
            showCourseStudentList.FormClosing += delegate { this.Show(); };
            showCourseStudentList.Show();
            this.Hide();
        }//show course student list
        private void button2_Click(object sender, EventArgs e)
        {
            var showInstructorStudentList = new ShowInstructorStudentList(instructorServices);
            showInstructorStudentList.Location = this.Location;
            showInstructorStudentList.StartPosition = FormStartPosition.Manual;
            showInstructorStudentList.FormClosing += delegate { this.Show(); };
            showInstructorStudentList.Show();
            this.Hide();
        }//show instructor student list
        private void button3_Click(object sender, EventArgs e)
        {
            var updateStudentGrade = new UpdateStudentGrade(instructorServices);
            updateStudentGrade.Location = this.Location;
            updateStudentGrade.StartPosition = FormStartPosition.Manual;
            updateStudentGrade.FormClosing += delegate { this.Show(); };
            updateStudentGrade.Show();
            this.Hide();
        }//update student grade
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }//exit the page

    }
}
