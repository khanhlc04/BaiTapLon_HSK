
namespace BTL.LOC
{
    partial class HocSinhTheoLop
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
            this.rptHocSinhTheoLop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptHocSinhTheoLop
            // 
            this.rptHocSinhTheoLop.ActiveViewIndex = -1;
            this.rptHocSinhTheoLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptHocSinhTheoLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptHocSinhTheoLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHocSinhTheoLop.Location = new System.Drawing.Point(0, 0);
            this.rptHocSinhTheoLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rptHocSinhTheoLop.Name = "rptHocSinhTheoLop";
            this.rptHocSinhTheoLop.Size = new System.Drawing.Size(1200, 692);
            this.rptHocSinhTheoLop.TabIndex = 0;
            this.rptHocSinhTheoLop.ToolPanelWidth = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(96, 108);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(180, 28);
            this.cboLop.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(96, 188);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(112, 35);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // HocSinhTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptHocSinhTheoLop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HocSinhTheoLop";
            this.Text = "HocSinhTheoLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptHocSinhTheoLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnXem;
    }
}