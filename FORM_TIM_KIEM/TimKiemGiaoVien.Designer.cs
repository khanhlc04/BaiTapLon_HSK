
namespace BTL.FORM_TIM_KIEM
{
    partial class TimKiemGiaoVien
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.clbTimKiem = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(384, 116);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 19);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Tìm Kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(373, 71);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(76, 20);
            this.txtHoTen.TabIndex = 16;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(373, 31);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(76, 20);
            this.txtMaGV.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(103, 128);
            this.btnComfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(85, 19);
            this.btnComfirm.TabIndex = 11;
            this.btnComfirm.Text = "Xác Nhận";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // clbTimKiem
            // 
            this.clbTimKiem.FormattingEnabled = true;
            this.clbTimKiem.Items.AddRange(new object[] {
            "Mã Giáo Viên",
            "Tên Giáo Viên"});
            this.clbTimKiem.Location = new System.Drawing.Point(38, 28);
            this.clbTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clbTimKiem.Name = "clbTimKiem";
            this.clbTimKiem.Size = new System.Drawing.Size(162, 124);
            this.clbTimKiem.TabIndex = 10;
            this.clbTimKiem.SelectedIndexChanged += new System.EventHandler(this.clbTimKiem_SelectedIndexChanged);
            // 
            // TimKiemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.clbTimKiem);
            this.Name = "TimKiemGiaoVien";
            this.Text = "TimKiemGiaoVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.CheckedListBox clbTimKiem;
    }
}