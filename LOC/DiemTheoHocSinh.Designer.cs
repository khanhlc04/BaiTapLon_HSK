
namespace BTL.LOC
{
    partial class DiemTheoHocSinh
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
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHocSinh = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnXem = new System.Windows.Forms.Button();
            this.rptDiemTheoHocSinh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(92, 138);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 21);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học Sinh";
            // 
            // cboHocSinh
            // 
            this.cboHocSinh.FormattingEnabled = true;
            this.cboHocSinh.Location = new System.Drawing.Point(94, 169);
            this.cboHocSinh.Name = "cboHocSinh";
            this.cboHocSinh.Size = new System.Drawing.Size(121, 21);
            this.cboHocSinh.TabIndex = 1;
            this.cboHocSinh.SelectedIndexChanged += new System.EventHandler(this.cboHocSinh_SelectedIndexChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(72, 209);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // rptDiemTheoHocSinh
            // 
            this.rptDiemTheoHocSinh.ActiveViewIndex = -1;
            this.rptDiemTheoHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptDiemTheoHocSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptDiemTheoHocSinh.Location = new System.Drawing.Point(23, 12);
            this.rptDiemTheoHocSinh.Name = "rptDiemTheoHocSinh";
            this.rptDiemTheoHocSinh.Size = new System.Drawing.Size(1350, 559);
            this.rptDiemTheoHocSinh.TabIndex = 3;
            this.rptDiemTheoHocSinh.Load += new System.EventHandler(this.rptDiemTheoHocSinh_Load);
            // 
            // DiemTheoHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 608);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboHocSinh);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptDiemTheoHocSinh);
            this.Name = "DiemTheoHocSinh";
            this.Text = "DiemTheoHocSinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHocSinh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnXem;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptDiemTheoHocSinh;
    }
}