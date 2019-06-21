namespace UI
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonPrograms = new System.Windows.Forms.Button();
            this.buttonClass = new System.Windows.Forms.Button();
            this.buttonOfficialStudent = new System.Windows.Forms.Button();
            this.buttonPotentialStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRUNG TÂM ANH NGỮ AZ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 121);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.buttonReport);
            this.panel2.Controls.Add(this.buttonPrograms);
            this.panel2.Controls.Add(this.buttonClass);
            this.panel2.Controls.Add(this.buttonOfficialStudent);
            this.panel2.Controls.Add(this.buttonPotentialStudent);
            this.panel2.Location = new System.Drawing.Point(-1, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 526);
            this.panel2.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::UI.Properties.Resources.back;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(1122, 399);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(230, 122);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Đăng Xuất";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.Location = new System.Drawing.Point(1106, 8);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(251, 126);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Báo cáo";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonPrograms
            // 
            this.buttonPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrograms.Location = new System.Drawing.Point(819, 5);
            this.buttonPrograms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrograms.Name = "buttonPrograms";
            this.buttonPrograms.Size = new System.Drawing.Size(278, 131);
            this.buttonPrograms.TabIndex = 3;
            this.buttonPrograms.Text = "Chương trình học";
            this.buttonPrograms.UseVisualStyleBackColor = true;
            this.buttonPrograms.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // buttonClass
            // 
            this.buttonClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClass.Location = new System.Drawing.Point(555, 5);
            this.buttonClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClass.Name = "buttonClass";
            this.buttonClass.Size = new System.Drawing.Size(255, 131);
            this.buttonClass.TabIndex = 2;
            this.buttonClass.Text = "Lớp học";
            this.buttonClass.UseVisualStyleBackColor = true;
            this.buttonClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // buttonOfficialStudent
            // 
            this.buttonOfficialStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfficialStudent.Location = new System.Drawing.Point(294, 5);
            this.buttonOfficialStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOfficialStudent.Name = "buttonOfficialStudent";
            this.buttonOfficialStudent.Size = new System.Drawing.Size(252, 131);
            this.buttonOfficialStudent.TabIndex = 1;
            this.buttonOfficialStudent.Text = "Học viên chính thức";
            this.buttonOfficialStudent.UseVisualStyleBackColor = true;
            this.buttonOfficialStudent.Click += new System.EventHandler(this.buttonOfficialStudent_Click);
            // 
            // buttonPotentialStudent
            // 
            this.buttonPotentialStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPotentialStudent.Location = new System.Drawing.Point(4, 1);
            this.buttonPotentialStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPotentialStudent.Name = "buttonPotentialStudent";
            this.buttonPotentialStudent.Size = new System.Drawing.Size(280, 131);
            this.buttonPotentialStudent.TabIndex = 0;
            this.buttonPotentialStudent.Text = "Học viên tiềm năng";
            this.buttonPotentialStudent.UseVisualStyleBackColor = true;
            this.buttonPotentialStudent.Click += new System.EventHandler(this.buttonPotentialStudent_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Trung Tâm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonPrograms;
        private System.Windows.Forms.Button buttonClass;
        private System.Windows.Forms.Button buttonOfficialStudent;
        private System.Windows.Forms.Button buttonPotentialStudent;
        private System.Windows.Forms.Button buttonClose;
    }
}

