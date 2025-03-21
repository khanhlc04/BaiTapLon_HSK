namespace BTL
{
    partial class FormDiem
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
            this.dgvDiemHocSinh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbHocSinh = new System.Windows.Forms.ComboBox();
            this.cbbHocKi = new System.Windows.Forms.ComboBox();
            this.cbbGiaoVien = new System.Windows.Forms.ComboBox();
            this.numDiemGiuaKi = new System.Windows.Forms.NumericUpDown();
            this.numDiemCuoiKi = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemGiuaKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemCuoiKi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiemHocSinh
            // 
            this.dgvDiemHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemHocSinh.Location = new System.Drawing.Point(387, 23);
            this.dgvDiemHocSinh.Name = "dgvDiemHocSinh";
            this.dgvDiemHocSinh.RowHeadersWidth = 62;
            this.dgvDiemHocSinh.RowTemplate.Height = 28;
            this.dgvDiemHocSinh.Size = new System.Drawing.Size(1518, 598);
            this.dgvDiemHocSinh.TabIndex = 1;
            this.dgvDiemHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemHocSinh_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học Kì";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giáo Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Điểm Giữa Kì";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Điểm Cuối Kì";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(158, 43);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(185, 28);
            this.cbbMonHoc.TabIndex = 3;
            // 
            // cbbHocSinh
            // 
            this.cbbHocSinh.FormattingEnabled = true;
            this.cbbHocSinh.Location = new System.Drawing.Point(158, 97);
            this.cbbHocSinh.Name = "cbbHocSinh";
            this.cbbHocSinh.Size = new System.Drawing.Size(185, 28);
            this.cbbHocSinh.TabIndex = 4;
            // 
            // cbbHocKi
            // 
            this.cbbHocKi.FormattingEnabled = true;
            this.cbbHocKi.Location = new System.Drawing.Point(158, 156);
            this.cbbHocKi.Name = "cbbHocKi";
            this.cbbHocKi.Size = new System.Drawing.Size(185, 28);
            this.cbbHocKi.TabIndex = 5;
            // 
            // cbbGiaoVien
            // 
            this.cbbGiaoVien.FormattingEnabled = true;
            this.cbbGiaoVien.Location = new System.Drawing.Point(158, 208);
            this.cbbGiaoVien.Name = "cbbGiaoVien";
            this.cbbGiaoVien.Size = new System.Drawing.Size(185, 28);
            this.cbbGiaoVien.TabIndex = 6;
            // 
            // numDiemGiuaKi
            // 
            this.numDiemGiuaKi.DecimalPlaces = 2;
            this.numDiemGiuaKi.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numDiemGiuaKi.Location = new System.Drawing.Point(158, 335);
            this.numDiemGiuaKi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiemGiuaKi.Name = "numDiemGiuaKi";
            this.numDiemGiuaKi.Size = new System.Drawing.Size(120, 26);
            this.numDiemGiuaKi.TabIndex = 7;
            // 
            // numDiemCuoiKi
            // 
            this.numDiemCuoiKi.DecimalPlaces = 2;
            this.numDiemCuoiKi.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numDiemCuoiKi.Location = new System.Drawing.Point(158, 387);
            this.numDiemCuoiKi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDiemCuoiKi.Name = "numDiemCuoiKi";
            this.numDiemCuoiKi.Size = new System.Drawing.Size(120, 26);
            this.numDiemCuoiKi.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(193, 466);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 31);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(46, 546);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 546);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lớp";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(158, 272);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(185, 28);
            this.cbbLop.TabIndex = 6;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2181, 985);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numDiemCuoiKi);
            this.Controls.Add(this.numDiemGiuaKi);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.cbbGiaoVien);
            this.Controls.Add(this.cbbHocKi);
            this.Controls.Add(this.cbbHocSinh);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiemHocSinh);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDiem";
            this.Text = "Quản Lý Điểm Học Sinh";
            this.Load += new System.EventHandler(this.FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemGiuaKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemCuoiKi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiemHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.ComboBox cbbHocSinh;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.ComboBox cbbGiaoVien;
        private System.Windows.Forms.NumericUpDown numDiemGiuaKi;
        private System.Windows.Forms.NumericUpDown numDiemCuoiKi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLop;
    }
}