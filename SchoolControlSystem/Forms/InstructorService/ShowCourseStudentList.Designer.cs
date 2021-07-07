
namespace SchoolControlSystem.Forms.InstructorService
{
    partial class ShowCourseStudentList
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
            this.courseCodeText = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.studentName = new System.Windows.Forms.ColumnHeader();
            this.studentID = new System.Windows.Forms.ColumnHeader();
            this.controlMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseCodeText
            // 
            this.courseCodeText.Location = new System.Drawing.Point(58, 62);
            this.courseCodeText.Name = "courseCodeText";
            this.courseCodeText.Size = new System.Drawing.Size(100, 23);
            this.courseCodeText.TabIndex = 0;
            this.courseCodeText.Text = "Course Code";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(58, 104);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 23);
            this.enter.TabIndex = 1;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(58, 246);
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
            this.studentName,
            this.studentID});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(386, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 207);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // studentName
            // 
            this.studentName.Text = "Student Name";
            this.studentName.Width = 120;
            // 
            // studentID
            // 
            this.studentID.Text = "Student ID";
            this.studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentID.Width = 120;
            // 
            // controlMessage
            // 
            this.controlMessage.AutoSize = true;
            this.controlMessage.Location = new System.Drawing.Point(254, 144);
            this.controlMessage.Name = "controlMessage";
            this.controlMessage.Size = new System.Drawing.Size(0, 15);
            this.controlMessage.TabIndex = 4;
            // 
            // ShowCourseStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlMessage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.courseCodeText);
            this.Name = "ShowCourseStudentList";
            this.Text = "ShowCourseStudentList";
            this.Load += new System.EventHandler(this.ShowCourseStudentList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseCodeText;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.Label controlMessage;
    }
}