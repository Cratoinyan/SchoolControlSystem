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
    public partial class ShowSchedule : Form
    {
        StudentServices studentServices;
        IGetSchedule schedule;

        public ShowSchedule(StudentServices studentServices)
        {
            this.studentServices = studentServices;
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            int studentID;
            Schedule studentSchedule;
            List<string> hour = new List<string>();

            Int32.TryParse(studentIDText.Text, out studentID);
            listView1.Items.Clear();
            controlMessage.Text = "";

            if(studentScheduleChekBox.Checked == true 
                && !Utilities.StudentExists(studentID))
            {
                controlMessage.Text = "Student doesn't exist";
                return;
            }
            else if(courseScheduleCheckBox.Checked == true 
                && !Utilities.CourseExists(studentIDText.Text))
            {
                controlMessage.Text = "Course doesn't exist";
                return;
            }
            studentSchedule = studentServices.GetSchedule(schedule, studentIDText.Text);

                for(int i = 0 ; i < 9 ; i++)
                {
                    hour.Clear();
                    for(int j = 0; j < 7 ; j++)
                    {
                        hour.Add(studentSchedule.schedule[j][i]);
                    }
                    listView1.Items.Add(new ListViewItem(hour.ToArray()));
                }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentScheduleChekBox_CheckedChanged(object sender, EventArgs e)
        {
            if(studentScheduleChekBox.Checked == true)
            {
                courseScheduleCheckBox.Checked = false;
                schedule = new DisplayableStudentSchedule(studentServices.studentDataBase);
            }
            else
            {
                courseScheduleCheckBox.Checked = true;
            }

        }

        private void courseScheduleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(courseScheduleCheckBox.Checked == true)
            {
                studentScheduleChekBox.Checked = false;
                schedule = new DisplayableCourseSchedule();
            }
            else
            {
                studentScheduleChekBox.Checked = true;
            }
        }

        private void ShowSchedule_Load(object sender, EventArgs e)
        {
            studentScheduleChekBox.Checked = true;
        }
    }
}