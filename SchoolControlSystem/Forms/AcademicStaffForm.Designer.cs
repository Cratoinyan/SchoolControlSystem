
namespace SchoolControlSystem.Forms
{
    partial class AcademicStaffForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addInstructor = new System.Windows.Forms.Button();
            this.addAcademicStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addInstructor
            // 
            this.addInstructor.Location = new System.Drawing.Point(100, 113);
            this.addInstructor.Name = "addInstructor";
            this.addInstructor.Size = new System.Drawing.Size(123, 51);
            this.addInstructor.TabIndex = 1;
            this.addInstructor.Text = "Add Instructor";
            this.addInstructor.UseVisualStyleBackColor = true;
            this.addInstructor.Click += new System.EventHandler(this.addInstructor_Click);
            // 
            // addAcademicStaff
            // 
            this.addAcademicStaff.Location = new System.Drawing.Point(100, 170);
            this.addAcademicStaff.Name = "addAcademicStaff";
            this.addAcademicStaff.Size = new System.Drawing.Size(123, 51);
            this.addAcademicStaff.TabIndex = 2;
            this.addAcademicStaff.Text = "Add Academic Staff";
            this.addAcademicStaff.UseVisualStyleBackColor = true;
            this.addAcademicStaff.Click += new System.EventHandler(this.addAcademicStaff_Click);
            // 
            // AcademicStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addAcademicStaff);
            this.Controls.Add(this.addInstructor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AcademicStaffForm";
            this.Text = "Academic Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addInstructor;
        private System.Windows.Forms.Button addAcademicStaff;
    }
}