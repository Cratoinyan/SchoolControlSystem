
namespace SchoolControlSystem.Forms.InstructorService
{
    partial class ShowInstructorStudentList
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
            this.enter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.instructorIDText = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.studentName = new System.Windows.Forms.ColumnHeader();
            this.studentID = new System.Windows.Forms.ColumnHeader();
            this.controlMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(71, 133);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(71, 244);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // instructorIDText
            // 
            this.instructorIDText.Location = new System.Drawing.Point(71, 83);
            this.instructorIDText.Name = "instructorIDText";
            this.instructorIDText.Size = new System.Drawing.Size(100, 23);
            this.instructorIDText.TabIndex = 2;
            this.instructorIDText.Text = "Instructor ID";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentName,
            this.studentID});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(414, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 214);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // studentName
            // 
            this.studentName.Text = "Student Name";
            this.studentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.controlMessage.Location = new System.Drawing.Point(262, 133);
            this.controlMessage.Name = "controlMessage";
            this.controlMessage.Size = new System.Drawing.Size(0, 15);
            this.controlMessage.TabIndex = 4;
            // 
            // ShowInstructorStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlMessage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.instructorIDText);
            this.Controls.Add(this.back);
            this.Controls.Add(this.enter);
            this.Name = "ShowInstructorStudentList";
            this.Text = "ShowInstructorStudentList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox instructorIDText;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.Label controlMessage;
    }
}