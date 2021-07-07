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
    public partial class ShowInstructorStudentList : Form
    {
        InstructorServices instructorServices;
        public ShowInstructorStudentList(InstructorServices instructorServices)
        {
            this.instructorServices = instructorServices;
            InitializeComponent();
        }


        private void enter_Click(object sender, EventArgs e)
        {
            int instructorID;
            List<Student> students;

            controlMessage.Text = "";
            listView1.Items.Clear();

            Int32.TryParse(instructorIDText.Text, out instructorID);

            if(Utilities.InstructorExists(instructorID))
            {
                students = instructorServices.GetStudentList(instructorID);

                foreach(var student in students)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        student.name,
                        student.ID.ToString()
                    }));
                }
            }
            else
            {
                controlMessage.Text = "Instructor doesn't exist";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
