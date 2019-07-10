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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnOfficialStudent = new System.Windows.Forms.Button();
            this.btnPotentialStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRUNG TÂM ANH NGỮ G & M";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 79);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UI.Properties.Resources.english_Calss;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnTest);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnPrograms);
            this.panel2.Controls.Add(this.btnClass);
            this.panel2.Controls.Add(this.btnOfficialStudent);
            this.panel2.Controls.Add(this.btnPotentialStudent);
            this.panel2.Location = new System.Drawing.Point(-1, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 342);
            this.panel2.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(3, 247);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(170, 85);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Kì thi";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::UI.Properties.Resources.back;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(748, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 79);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đăng Xuất";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(737, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(167, 82);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograms.Location = new System.Drawing.Point(546, 3);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(185, 85);
            this.btnPrograms.TabIndex = 3;
            this.btnPrograms.Text = "Chương trình học";
            this.btnPrograms.UseVisualStyleBackColor = true;
            this.btnPrograms.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // btnClass
            // 
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(370, 3);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(170, 85);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.buttonClass_Click);
            // 
            // btnOfficialStudent
            // 
            this.btnOfficialStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfficialStudent.Location = new System.Drawing.Point(196, 3);
            this.btnOfficialStudent.Name = "btnOfficialStudent";
            this.btnOfficialStudent.Size = new System.Drawing.Size(168, 85);
            this.btnOfficialStudent.TabIndex = 1;
            this.btnOfficialStudent.Text = "Học viên chính thức";
            this.btnOfficialStudent.UseVisualStyleBackColor = true;
            this.btnOfficialStudent.Click += new System.EventHandler(this.buttonOfficialStudent_Click);
            // 
            // btnPotentialStudent
            // 
            this.btnPotentialStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotentialStudent.Location = new System.Drawing.Point(3, 1);
            this.btnPotentialStudent.Name = "btnPotentialStudent";
            this.btnPotentialStudent.Size = new System.Drawing.Size(187, 85);
            this.btnPotentialStudent.TabIndex = 0;
            this.btnPotentialStudent.Text = "Học viên tiềm năng";
            this.btnPotentialStudent.UseVisualStyleBackColor = true;
            this.btnPotentialStudent.Click += new System.EventHandler(this.buttonPotentialStudent_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnOfficialStudent;
        private System.Windows.Forms.Button btnPotentialStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTest;
    }
}

