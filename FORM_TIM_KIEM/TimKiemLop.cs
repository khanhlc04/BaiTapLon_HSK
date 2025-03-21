using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.FORM_TIM_KIEM
{
    public partial class TimKiemLop : Form
    {
        sql SQL = new sql();
        public TimKiemLop()
        {
            InitializeComponent();
            reload();
        }

        private void reload()
        {
            // Tắt tất cả các input ban đầu
            txtTenLop.Enabled = false;
            txtMaLop.Enabled = false;

            btnFind.Enabled = false;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            var checkedItems = clbTimKiem.CheckedItems.Cast<string>().ToList();

            // Kích hoạt các input dựa vào checkbox đã chọn
            txtMaLop.Enabled = checkedItems.Contains("Mã Lớp");
            txtTenLop.Enabled = checkedItems.Contains("Tên Lớp");


            // Bật nút tìm kiếm nếu có ít nhất một lựa chọn
            btnFind.Enabled = checkedItems.Count > 0;
        }
        public string[] x = new string[2];
        private void btnFind_Click(object sender, EventArgs e)
        {
            x[0] = txtMaLop.Enabled ? $" MaLop = '{txtMaLop.Text.Trim()}' " : "";
            x[1] = txtTenLop.Enabled ? $" TenLop LIKE N'%{txtTenLop.Text.Trim()}%' " : "";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
