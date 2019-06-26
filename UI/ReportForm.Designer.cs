namespace UI
{
    partial class ReportForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BaocaoTTHV = new System.Windows.Forms.GroupBox();
            this.groupBoxClassing = new System.Windows.Forms.GroupBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxListStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxListClassIDs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BaocaoTTHV.SuspendLayout();
            this.groupBoxClassing.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Báo cáo Thông tin Học viên",
            "Báo cáo Kế toán Lớp học"});
            this.comboBox1.Location = new System.Drawing.Point(442, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(538, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BaocaoTTHV
            // 
            this.BaocaoTTHV.Controls.Add(this.comboBoxListStudent);
            this.BaocaoTTHV.Controls.Add(this.label2);
            this.BaocaoTTHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaocaoTTHV.Location = new System.Drawing.Point(8, 110);
            this.BaocaoTTHV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BaocaoTTHV.Name = "BaocaoTTHV";
            this.BaocaoTTHV.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BaocaoTTHV.Size = new System.Drawing.Size(1214, 448);
            this.BaocaoTTHV.TabIndex = 1;
            this.BaocaoTTHV.TabStop = false;
            this.BaocaoTTHV.Text = "Báo cáo Thông tin Học viên";
            this.BaocaoTTHV.Visible = false;
            // 
            // groupBoxClassing
            // 
            this.groupBoxClassing.Controls.Add(this.comboBoxClass);
            this.groupBoxClassing.Controls.Add(this.label5);
            this.groupBoxClassing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClassing.Location = new System.Drawing.Point(8, 110);
            this.groupBoxClassing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxClassing.Name = "groupBoxClassing";
            this.groupBoxClassing.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxClassing.Size = new System.Drawing.Size(1214, 448);
            this.groupBoxClassing.TabIndex = 7;
            this.groupBoxClassing.TabStop = false;
            this.groupBoxClassing.Text = "Báo cáo kế toán Lớp";
            this.groupBoxClassing.Visible = false;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(511, 122);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(583, 45);
            this.comboBoxClass.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lớp *";
            // 
            // comboBoxListStudent
            // 
            this.comboBoxListStudent.FormattingEnabled = true;
            this.comboBoxListStudent.Location = new System.Drawing.Point(511, 122);
            this.comboBoxListStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxListStudent.Name = "comboBoxListStudent";
            this.comboBoxListStudent.Size = new System.Drawing.Size(583, 45);
            this.comboBoxListStudent.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học viên *";
            // 
            // comboBoxListClassIDs
            // 
            this.comboBoxListClassIDs.FormattingEnabled = true;
            this.comboBoxListClassIDs.Location = new System.Drawing.Point(480, 185);
            this.comboBoxListClassIDs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxListClassIDs.Name = "comboBoxListClassIDs";
            this.comboBoxListClassIDs.Size = new System.Drawing.Size(443, 28);
            this.comboBoxListClassIDs.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Lớp :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn loại báo cáo";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(442, 639);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 109);
            this.button2.TabIndex = 6;
            this.button2.Text = "Lập Báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 786);
            this.Controls.Add(this.groupBoxClassing);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BaocaoTTHV);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportForm";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.BaocaoTTHV.ResumeLayout(false);
            this.BaocaoTTHV.PerformLayout();
            this.groupBoxClassing.ResumeLayout(false);
            this.groupBoxClassing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox BaocaoTTHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxListClassIDs;
        private System.Windows.Forms.ComboBox comboBoxListStudent;
        private System.Windows.Forms.GroupBox groupBoxClassing;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label5;
    }
}
