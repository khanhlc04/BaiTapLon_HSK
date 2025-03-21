
namespace BTL.FORM_TIM_KIEM
{
    partial class TimKiemLop
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
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.clbTimKiem = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(523, 266);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 29);
            this.btnFind.TabIndex = 26;
            this.btnFind.Text = "Tìm Kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(523, 197);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(112, 26);
            this.txtMaLop.TabIndex = 25;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(523, 135);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(112, 26);
            this.txtTenLop.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên Lớp";
            // 
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(119, 285);
            this.btnComfirm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(128, 29);
            this.btnComfirm.TabIndex = 20;
            this.btnComfirm.Text = "Xác Nhận";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // clbTimKiem
            // 
            this.clbTimKiem.FormattingEnabled = true;
            this.clbTimKiem.Items.AddRange(new object[] {
            "Tên Lớp",
            "Mã Lớp"});
            this.clbTimKiem.Location = new System.Drawing.Point(21, 131);
            this.clbTimKiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clbTimKiem.Name = "clbTimKiem";
            this.clbTimKiem.Size = new System.Drawing.Size(241, 188);
            this.clbTimKiem.TabIndex = 19;
            // 
            // TimKiemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.clbTimKiem);
            this.Name = "TimKiemLop";
            this.Text = "TimKiemLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.CheckedListBox clbTimKiem;
    }
}