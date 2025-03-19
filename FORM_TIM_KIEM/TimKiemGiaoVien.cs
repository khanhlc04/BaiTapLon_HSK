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
    public partial class TimKiemGiaoVien : Form
    {
        sql SQL = new sql();
        public TimKiemGiaoVien()
        {
            InitializeComponent();
            ReLoad();
        }

        private void ReLoad()
        {
            txtMaGV.Enabled = false;
            txtHoTen.Enabled = false;
            btnFind.Enabled = false;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            var checkedItems = clbTimKiem.CheckedItems.Cast<string>().ToList();

            // Kích hoạt các input dựa vào checkbox đã chọn
            txtMaGV.Enabled = checkedItems.Contains("Mã Giáo Viên");
            txtHoTen.Enabled = checkedItems.Contains("Tên Giáo Viên");
            

            // Bật nút tìm kiếm nếu có ít nhất một lựa chọn
            btnFind.Enabled = checkedItems.Count > 0;
        }
        public string[] x = new string[2];

        private void btnFind_Click(object sender, EventArgs e)
        {
            x[0] = txtMaGV.Enabled ? $" MaGiaoVien = '{txtMaGV.Text.Trim()}' " : "";
            x[1] = txtHoTen.Enabled ? $" TenGiaoVien LIKE N'%{txtHoTen.Text.Trim()}%' " : "";
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void clbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
