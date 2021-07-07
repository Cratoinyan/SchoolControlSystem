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
    public partial class UpdateStudentGrade : Form
    {
        InstructorServices instructorServices;

        public UpdateStudentGrade(InstructorServices instructorServices)
        {
            this.instructorServices = instructorServices;
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            int studentID;
            int grade;

            Int32.TryParse(studentIDText.Text, out studentID);
            Int32.TryParse(gradeText.Text, out grade);

            if (Utilities.StudentExists(studentID))
            {
                if (Utilities.CourseExists(courseCodeText.Text))
                {
                    if (Utilities.StudentTakesThisCourse(studentID, courseCodeText.Text))
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            instructorServices.UpdateStudentGrade(studentID, courseCodeText.Text, grade);
                            controlMessage.Text = "Grade updated";
                        }
                        else
                        {
                            controlMessage.Text = "Grade should be between 0 and 100";
                        }
                    }
                    else
                    {
                        controlMessage.Text = "Student doesn't take this course";
                    }
                }
                else
                {
                    controlMessage.Text = "Course doesn't exist";
                }
            }
            else
            {
                controlMessage.Text = " Student doesn't exist";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }      
}
