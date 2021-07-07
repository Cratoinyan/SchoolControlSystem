
namespace SchoolControlSystem.Forms.InstructorService
{
    partial class UpdateStudentGrade
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
            this.courseCodeText = new System.Windows.Forms.TextBox();
            this.gradeText = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.controlMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentIDText
            // 
            this.studentIDText.Location = new System.Drawing.Point(51, 48);
            this.studentIDText.Name = "studentIDText";
            this.studentIDText.Size = new System.Drawing.Size(100, 23);
            this.studentIDText.TabIndex = 0;
            this.studentIDText.Text = "Student ID";
            // 
            // courseCodeText
            // 
            this.courseCodeText.Location = new System.Drawing.Point(51, 94);
            this.courseCodeText.Name = "courseCodeText";
            this.courseCodeText.Size = new System.Drawing.Size(100, 23);
            this.courseCodeText.TabIndex = 1;
            this.courseCodeText.Text = "Course Code";
            // 
            // gradeText
            // 
            this.gradeText.Location = new System.Drawing.Point(51, 141);
            this.gradeText.Name = "gradeText";
            this.gradeText.Size = new System.Drawing.Size(100, 23);
            this.gradeText.TabIndex = 2;
            this.gradeText.Text = "Grade";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(51, 215);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(100, 23);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(51, 288);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // controlMessage
            // 
            this.controlMessage.AutoSize = true;
            this.controlMessage.Location = new System.Drawing.Point(51, 181);
            this.controlMessage.Name = "controlMessage";
            this.controlMessage.Size = new System.Drawing.Size(0, 15);
            this.controlMessage.TabIndex = 5;
            // 
            // UpdateStudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlMessage);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.gradeText);
            this.Controls.Add(this.courseCodeText);
            this.Controls.Add(this.studentIDText);
            this.Name = "UpdateStudentGrade";
            this.Text = "UpdateStudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIDText;
        private System.Windows.Forms.TextBox courseCodeText;
        private System.Windows.Forms.TextBox gradeText;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label controlMessage;
    }
}