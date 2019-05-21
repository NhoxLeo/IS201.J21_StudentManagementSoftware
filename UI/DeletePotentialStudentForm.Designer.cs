namespace UI
{
    partial class DeletePotentialStudentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfim = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-41, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 68);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "XOÁ HỌC VIÊN TIỀM NĂNG";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbStudentID);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(172, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 53);
            this.panel4.TabIndex = 0;
            // 
            // tbStudentID
            // 
            this.tbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudentID.Location = new System.Drawing.Point(141, 15);
            this.tbStudentID.Multiline = true;
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(284, 25);
            this.tbStudentID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học viên:";
            // 
            // btConfim
            // 
            this.btConfim.BackColor = System.Drawing.Color.Transparent;
            this.btConfim.BackgroundImage = global::UI.Properties.Resources.confirm;
            this.btConfim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfim.ForeColor = System.Drawing.Color.Black;
            this.btConfim.Location = new System.Drawing.Point(337, 0);
            this.btConfim.Name = "btConfim";
            this.btConfim.Size = new System.Drawing.Size(153, 80);
            this.btConfim.TabIndex = 1;
            this.btConfim.Text = "Xác nhận";
            this.btConfim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConfim.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btConfim);
            this.panel3.Location = new System.Drawing.Point(5, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 86);
            this.panel3.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::UI.Properties.Resources.back;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(639, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 80);
            this.button3.TabIndex = 5;
            this.button3.Text = "Trở về";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(5, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 69);
            this.panel2.TabIndex = 7;
            // 
            // DeletePotentialStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 235);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "DeletePotentialStudentForm";
            this.Text = "DeletePotentialStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
    }
}