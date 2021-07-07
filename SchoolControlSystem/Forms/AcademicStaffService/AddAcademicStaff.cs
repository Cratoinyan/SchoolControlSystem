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
    public partial class AddAcademicStaff : Form
    {
        AcademicStaffServices academicStaffServices;
        IEnrollment enrollment;

        public AddAcademicStaff(AcademicStaffServices academicStaffServices)
        {
            this.academicStaffServices = academicStaffServices;
            InitializeComponent();
        }
        private void enter_Click(object sender, EventArgs e)
        {
            enrollment = new EnrollAcademicStaff(academicStaffServices.academicStaffDataBase);
            enrollment.Enroll(acadenicStaffNameText.Text, dateTimePicker1.Value.ToShortDateString());
            controlMessage.Text = enrollment.message;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}