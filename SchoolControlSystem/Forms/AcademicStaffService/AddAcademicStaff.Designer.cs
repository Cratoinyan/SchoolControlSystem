
namespace SchoolControlSystem.Forms.AcademicStaffService
{
    partial class AddAcademicStaff
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
            this.controlMessage = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Back = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.acadenicStaffNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controlMessage
            // 
            this.controlMessage.AutoSize = true;
            this.controlMessage.Location = new System.Drawing.Point(27, 129);
            this.controlMessage.Name = "controlMessage";
            this.controlMessage.Size = new System.Drawing.Size(0, 15);
            this.controlMessage.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(27, 241);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(182, 23);
            this.Back.TabIndex = 16;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(27, 147);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(182, 23);
            this.enter.TabIndex = 15;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // acadenicStaffNameText
            // 
            this.acadenicStaffNameText.Location = new System.Drawing.Point(27, 44);
            this.acadenicStaffNameText.Name = "acadenicStaffNameText";
            this.acadenicStaffNameText.Size = new System.Drawing.Size(182, 23);
            this.acadenicStaffNameText.TabIndex = 14;
            this.acadenicStaffNameText.Text = "Name";
            this.acadenicStaffNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Birth Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddAcademicStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlMessage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.acadenicStaffNameText);
            this.Name = "AddAcademicStaff";
            this.Text = "AddAcademicStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label controlMessage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox acadenicStaffNameText;
        private System.Windows.Forms.Label label1;
    }
}