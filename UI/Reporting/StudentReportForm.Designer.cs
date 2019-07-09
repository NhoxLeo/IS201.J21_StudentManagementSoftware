namespace UI
{
    partial class StudentReportForm
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
            this.crystalReportViewerStudent = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.StudentInfoReport1 = new UI.StudentInfoReport();
            this.SuspendLayout();
            // 
            // crystalReportViewerStudent
            // 
            this.crystalReportViewerStudent.ActiveViewIndex = 0;
            this.crystalReportViewerStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerStudent.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerStudent.Name = "crystalReportViewerStudent";
            this.crystalReportViewerStudent.ReportSource = this.StudentInfoReport1;
            this.crystalReportViewerStudent.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerStudent.TabIndex = 0;
            // 
            // StudentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerStudent);
            this.Name = "StudentReportForm";
            this.Text = "StudentReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerStudent;
        private StudentInfoReport StudentInfoReport1;
    }
}