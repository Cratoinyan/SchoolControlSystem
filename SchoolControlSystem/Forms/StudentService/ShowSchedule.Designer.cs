
namespace SchoolControlSystem.Forms.StudentService
{
    partial class ShowSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentIDText = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.controlMessage = new System.Windows.Forms.Label();
            this.studentScheduleChekBox = new System.Windows.Forms.CheckBox();
            this.courseScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // studentIDText
            // 
            this.studentIDText.Location = new System.Drawing.Point(51, 50);
            this.studentIDText.Name = "studentIDText";
            this.studentIDText.Size = new System.Drawing.Size(100, 23);
            this.studentIDText.TabIndex = 0;
            this.studentIDText.Text = "Student ID";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(51, 121);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 23);
            this.enter.TabIndex = 1;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(51, 250);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(318, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 223);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Monday";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tuesday";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Wednesday";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thursday";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Friday";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Saturday";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sunday";
            // 
            // controlMessage
            // 
            this.controlMessage.AutoSize = true;
            this.controlMessage.Location = new System.Drawing.Point(51, 88);
            this.controlMessage.Name = "controlMessage";
            this.controlMessage.Size = new System.Drawing.Size(0, 15);
            this.controlMessage.TabIndex = 4;
            // 
            // studentScheduleChekBox
            // 
            this.studentScheduleChekBox.AutoSize = true;
            this.studentScheduleChekBox.Location = new System.Drawing.Point(172, 50);
            this.studentScheduleChekBox.Name = "studentScheduleChekBox";
            this.studentScheduleChekBox.Size = new System.Drawing.Size(118, 19);
            this.studentScheduleChekBox.TabIndex = 5;
            this.studentScheduleChekBox.Text = "Student Schedule";
            this.studentScheduleChekBox.UseVisualStyleBackColor = true;
            this.studentScheduleChekBox.CheckedChanged += new System.EventHandler(this.studentScheduleChekBox_CheckedChanged);
            // 
            // courseScheduleCheckBox
            // 
            this.courseScheduleCheckBox.AutoSize = true;
            this.courseScheduleCheckBox.Location = new System.Drawing.Point(172, 76);
            this.courseScheduleCheckBox.Name = "courseScheduleCheckBox";
            this.courseScheduleCheckBox.Size = new System.Drawing.Size(114, 19);
            this.courseScheduleCheckBox.TabIndex = 6;
            this.courseScheduleCheckBox.Text = "Course Schedule";
            this.courseScheduleCheckBox.UseVisualStyleBackColor = true;
            this.courseScheduleCheckBox.CheckedChanged += new System.EventHandler(this.courseScheduleCheckBox_CheckedChanged);
            // 
            // ShowSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseScheduleCheckBox);
            this.Controls.Add(this.studentScheduleChekBox);
            this.Controls.Add(this.controlMessage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.studentIDText);
            this.Name = "ShowSchedule";
            this.Text = "ShowStudentSchedule";
            this.Load += new System.EventHandler(this.ShowSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIDText;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label controlMessage;
        private System.Windows.Forms.CheckBox studentScheduleChekBox;
        private System.Windows.Forms.CheckBox courseScheduleCheckBox;
    }
}