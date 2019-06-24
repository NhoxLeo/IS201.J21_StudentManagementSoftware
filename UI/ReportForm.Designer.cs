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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BaocaoKTLH = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BaocaoKQHT = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.BaocaoTTHV.SuspendLayout();
            this.BaocaoKTLH.SuspendLayout();
            this.BaocaoKQHT.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Báo cáo Thông tin Học viên",
            "Báo cáo Kế toán Lớp học",
            "Báo cáo kết quả học tập"});
            this.comboBox1.Location = new System.Drawing.Point(393, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(479, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BaocaoTTHV
            // 
            this.BaocaoTTHV.Controls.Add(this.radioButton2);
            this.BaocaoTTHV.Controls.Add(this.radioButton1);
            this.BaocaoTTHV.Controls.Add(this.textBox2);
            this.BaocaoTTHV.Controls.Add(this.label2);
            this.BaocaoTTHV.Controls.Add(this.label1);
            this.BaocaoTTHV.Controls.Add(this.textBox1);
            this.BaocaoTTHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaocaoTTHV.Location = new System.Drawing.Point(6, 88);
            this.BaocaoTTHV.Name = "BaocaoTTHV";
            this.BaocaoTTHV.Size = new System.Drawing.Size(1079, 358);
            this.BaocaoTTHV.TabIndex = 1;
            this.BaocaoTTHV.TabStop = false;
            this.BaocaoTTHV.Text = "Báo cáo Thông tin Học viên";
            this.BaocaoTTHV.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(554, 251);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(240, 36);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Báo cáo kế toán";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(200, 251);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(255, 36);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bác cáo ghi danh";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(489, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(500, 38);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Học viên *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên Học viên *";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 38);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn loại báo cáo";
            // 
            // BaocaoKTLH
            // 
            this.BaocaoKTLH.Controls.Add(this.textBox3);
            this.BaocaoKTLH.Controls.Add(this.label4);
            this.BaocaoKTLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaocaoKTLH.Location = new System.Drawing.Point(6, 88);
            this.BaocaoKTLH.Name = "BaocaoKTLH";
            this.BaocaoKTLH.Size = new System.Drawing.Size(1079, 371);
            this.BaocaoKTLH.TabIndex = 4;
            this.BaocaoKTLH.TabStop = false;
            this.BaocaoKTLH.Text = "Báo cáo Kế toán Lớp học (Tổng tiền lớp)";
            this.BaocaoKTLH.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 38);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Lớp :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BaocaoKQHT
            // 
            this.BaocaoKQHT.Controls.Add(this.textBox4);
            this.BaocaoKQHT.Controls.Add(this.label5);
            this.BaocaoKQHT.Controls.Add(this.label6);
            this.BaocaoKQHT.Controls.Add(this.textBox5);
            this.BaocaoKQHT.Controls.Add(this.radioButton4);
            this.BaocaoKQHT.Controls.Add(this.radioButton3);
            this.BaocaoKQHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaocaoKQHT.Location = new System.Drawing.Point(6, 88);
            this.BaocaoKQHT.Name = "BaocaoKQHT";
            this.BaocaoKQHT.Size = new System.Drawing.Size(1079, 389);
            this.BaocaoKQHT.TabIndex = 5;
            this.BaocaoKQHT.TabStop = false;
            this.BaocaoKQHT.Text = "Báo cáo Kết quả học tập";
            this.BaocaoKQHT.Visible = false;
            this.BaocaoKQHT.Enter += new System.EventHandler(this.BaocaoKQHT_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(489, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(500, 38);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(189, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Học viên *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(189, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ và tên Học viên *";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(489, 207);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(500, 38);
            this.textBox5.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(364, 135);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(143, 36);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Cá nhân";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(364, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(231, 36);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tất cả Học viên";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(393, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 87);
            this.button2.TabIndex = 6;
            this.button2.Text = "Lập Báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 629);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BaocaoKQHT);
            this.Controls.Add(this.BaocaoKTLH);
            this.Controls.Add(this.BaocaoTTHV);
            this.Name = "ReportForm";
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.BaocaoTTHV.ResumeLayout(false);
            this.BaocaoTTHV.PerformLayout();
            this.BaocaoKTLH.ResumeLayout(false);
            this.BaocaoKTLH.PerformLayout();
            this.BaocaoKQHT.ResumeLayout(false);
            this.BaocaoKQHT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox BaocaoTTHV;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox BaocaoKTLH;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox BaocaoKQHT;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
    }
}