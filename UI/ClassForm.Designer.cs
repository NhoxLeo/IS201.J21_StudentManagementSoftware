namespace UI
{
    partial class ClassForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListClass = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btAddClass = new System.Windows.Forms.Button();
            this.btnAddStudentToClass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClass)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 58);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỚP HỌC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddStudentToClass);
            this.panel2.Controls.Add(this.dgvListClass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 302);
            this.panel2.TabIndex = 7;
            // 
            // dgvListClass
            // 
            this.dgvListClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClass.Location = new System.Drawing.Point(13, 37);
            this.dgvListClass.Name = "dgvListClass";
            this.dgvListClass.Size = new System.Drawing.Size(910, 262);
            this.dgvListClass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách lớp học:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btAddClass);
            this.panel3.Location = new System.Drawing.Point(1, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 87);
            this.panel3.TabIndex = 8;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = global::UI.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(577, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(174, 80);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::UI.Properties.Resources.back;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(769, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 80);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Trở về";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::UI.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(386, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 80);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá lớp học";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::UI.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(188, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(179, 80);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa thông tin lớp học";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btAddClass
            // 
            this.btAddClass.BackColor = System.Drawing.Color.Transparent;
            this.btAddClass.BackgroundImage = global::UI.Properties.Resources.plus;
            this.btAddClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddClass.ForeColor = System.Drawing.Color.Black;
            this.btAddClass.Location = new System.Drawing.Point(12, 4);
            this.btAddClass.Name = "btAddClass";
            this.btAddClass.Size = new System.Drawing.Size(153, 80);
            this.btAddClass.TabIndex = 0;
            this.btAddClass.Text = "Thêm lớp";
            this.btAddClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAddClass.UseVisualStyleBackColor = false;
            this.btAddClass.Click += new System.EventHandler(this.btAddClass_Click);
            // 
            // btnAddStudentToClass
            // 
            this.btnAddStudentToClass.Location = new System.Drawing.Point(839, 10);
            this.btnAddStudentToClass.Name = "btnAddStudentToClass";
            this.btnAddStudentToClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudentToClass.TabIndex = 5;
            this.btnAddStudentToClass.Text = "Thêm học viên vào lớp";
            this.btnAddStudentToClass.UseVisualStyleBackColor = true;
            this.btnAddStudentToClass.Click += new System.EventHandler(this.btnAddStudentToClass_Click);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.Shown += new System.EventHandler(this.ClassForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClass)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btAddClass;
        private System.Windows.Forms.Button btnAddStudentToClass;
    }
}