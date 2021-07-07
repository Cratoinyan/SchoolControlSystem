
namespace SchoolControlSystem.Forms.StudentService
{
    partial class ShowCourseList
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
            this.studentID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CourseCode = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.controlMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(57, 55);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(100, 23);
            this.studentID.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "StudentID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseCode
            // 
            this.CourseCode.FormattingEnabled = true;
            this.CourseCode.ItemHeight = 15;
            this.CourseCode.Location = new System.Drawing.Point(471, 55);
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Size = new System.Drawing.Size(120, 94);
            this.CourseCode.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlMessage
            // 
            this.controlMessage.AutoSize = true;
            this.controlMessage.Location = new System.Drawing.Point(57, 94);
            this.controlMessage.Name = "controlMessage";
            this.controlMessage.Size = new System.Drawing.Size(0, 15);
            this.controlMessage.TabIndex = 4;
            // 
            // ShowCourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CourseCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentID);
            this.Name = "ShowCourseList";
            this.Text = "ShowCourseList";
            this.Load += new System.EventHandler(this.ShowCourseList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox CourseCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label controlMessage;
    }
}