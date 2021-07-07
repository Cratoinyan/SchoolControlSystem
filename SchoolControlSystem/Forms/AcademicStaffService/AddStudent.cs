using SchoolControlSystem.ModelServices;
using SchoolControlSystem.ModelServices.Enrollment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolControlSystem.Forms.AcademicStaffService
{
    public partial class AddStudent : Form
    {
        AcademicStaffServices academicStaffServices;
        IEnrollment enrollment;

        public AddStudent(AcademicStaffServices academicStaffServices)
        {
            this.academicStaffServices = academicStaffServices;
            InitializeComponent();
        }
        private void enter_Click(object sender, EventArgs e)
        {
            enrollment = new EnrollStudent(academicStaffServices.studentDataBase);
            enrollment.Enroll(studentNameText.Text, dateTimePicker1.Value.ToShortDateString());
            controlMessage.Text = enrollment.message;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}