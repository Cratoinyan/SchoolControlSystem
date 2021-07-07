using SchoolControlSystem.Forms.AcademicStaffService;
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
    public partial class AcademicStaffForm : Form
    {
        AcademicStaffServices academicStaffServices;
        public AcademicStaffForm(AcademicStaffServices academicStaffServices)
        {
            this.academicStaffServices = academicStaffServices;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudent(academicStaffServices);
            addStudent.Location = this.Location;
            addStudent.StartPosition = FormStartPosition.Manual;
            addStudent.FormClosing += delegate { this.Show(); };
            addStudent.Show();
            this.Hide();
        }//add student
        private void addInstructor_Click(object sender, EventArgs e)
        {
            var addInstructor = new AddInstructor(academicStaffServices);
            addInstructor.Location = this.Location;
            addInstructor.StartPosition = FormStartPosition.Manual;
            addInstructor.FormClosing += delegate { this.Show(); };
            addInstructor.Show();
            this.Hide();
        }
        private void addAcademicStaff_Click(object sender, EventArgs e)
        {
            var addAcademicStaff = new AddAcademicStaff(academicStaffServices);
            addAcademicStaff.Location = this.Location;
            addAcademicStaff.StartPosition = FormStartPosition.Manual;
            addAcademicStaff.FormClosing += delegate { this.Show(); };
            addAcademicStaff.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//exit the page
    }
}
