
namespace BTL.LOC
{
    partial class DiemTheoLop
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
            this.rptDiemTheoLop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cachedKHOANG_DIEM_MON1 = new BTL.LOC.CachedKHOANG_DIEM_MON();
            this.cboHocKi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptDiemTheoLop
            // 
            this.rptDiemTheoLop.ActiveViewIndex = -1;
            this.rptDiemTheoLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptDiemTheoLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptDiemTheoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptDiemTheoLop.Location = new System.Drawing.Point(0, 0);
            this.rptDiemTheoLop.Name = "rptDiemTheoLop";
            this.rptDiemTheoLop.Size = new System.Drawing.Size(800, 450);
            this.rptDiemTheoLop.TabIndex = 0;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(59, 86);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 21);
            this.cboLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lớp";
            // 
            // cboHocKi
            // 
            this.cboHocKi.FormattingEnabled = true;
            this.cboHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboHocKi.Location = new System.Drawing.Point(59, 113);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(121, 21);
            this.cboHocKi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học Kì";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(59, 158);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // DiemTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboHocKi);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.rptDiemTheoLop);
            this.Name = "DiemTheoLop";
            this.Text = "DiemTheoLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptDiemTheoLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label1;
        private CachedKHOANG_DIEM_MON cachedKHOANG_DIEM_MON1;
        private System.Windows.Forms.ComboBox cboHocKi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXem;
    }
}