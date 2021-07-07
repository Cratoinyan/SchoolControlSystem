
namespace SchoolControlSystem.Forms.StudentService
{
    partial class AddCourse
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
            this.enter = new System.Windows.Forms.Button();
            this.controlMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentIDText
            // 
            this.studentIDText.Location = new System.Drawing.Point(59, 49);
            this.studentIDText.Name = "studentIDText";
            this.studentIDText.Size = new System.Drawing.Size(100, 23);
            this.studentIDText.TabIndex = 0;
            this.studentIDText.Text = "StudentID";
            // 
            // courseCodeText
            // 
            this.courseCodeText.Location = new System.Drawing.Point(59, 78);
            this.courseCodeText.Name = "courseCodeText";
            this.courseCodeText.Size = new System.Drawing.Size(100, 23);
            this.courseCodeText.TabIndex = 1;
            this.courseCodeText.Text = "Course Code";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(59, 146);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(100, 23);
            this.enter.TabIndex = 2;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlMessage
            // 
            this.controlMessage.AutoSize = true;
            this.controlMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.controlMessage.Location = new System.Drawing.Point(70, 117);
            this.controlMessage.Name = "controlMessage";
            this.controlMessage.Size = new System.Drawing.Size(0, 15);
            this.controlMessage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlMessage);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.courseCodeText);
            this.Controls.Add(this.studentIDText);
            this.Name = "AddCourse";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIDText;
        private System.Windows.Forms.TextBox courseCodeText;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label controlMessage;
        private System.Windows.Forms.Button button1;
    }
}