using SchoolControlSystem.Forms;
using SchoolControlSystem.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolControlSystem
{
    public partial class MainMenu : Form
    {
        AcademicStaffServices academicStaffServices;
        InstructorServices instructorServices;
        StudentServices studentServices;

        public MainMenu(AcademicStaffServices academicStaffServices, InstructorServices instructorServices, StudentServices studentServices)
        {
            this.academicStaffServices = academicStaffServices;
            this.instructorServices = instructorServices;
            this.studentServices = studentServices;

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var acadenicStaffMenu = new AcademicStaffForm(academicStaffServices);
            acadenicStaffMenu.Location = this.Location;
            acadenicStaffMenu.StartPosition = FormStartPosition.Manual;
            acadenicStaffMenu.FormClosing += delegate { this.Show(); };
            acadenicStaffMenu.Show();
            this.Hide();
        }//academic staff menu
        private void button2_Click(object sender, EventArgs e)
        {
            var instructorMenu = new InstructorForm(instructorServices);
            instructorMenu.Location = this.Location;
            instructorMenu.StartPosition = FormStartPosition.Manual;
            instructorMenu.FormClosing += delegate { this.Show(); };
            instructorMenu.Show();
            this.Hide();
        }//instructor menu
        private void button3_Click(object sender, EventArgs e)
        {
            var studetnMenu = new StudentForm(studentServices);
            studetnMenu.Location = this.Location;
            studetnMenu.StartPosition = FormStartPosition.Manual;
            studetnMenu.FormClosing += delegate { this.Show(); };
            studetnMenu.Show();
            this.Hide();
        }//student menu
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }//exit the application
    }
}
