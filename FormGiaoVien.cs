using BTL.FORM_TIM_KIEM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormGiaoVien : Form
    {
        sql SQL = new sql();
        public FormGiaoVien()
        {
            InitializeComponent();
            ReLoadDTGV();

        }
        public void ReLoadDTGV()
        {
            SQL.Connect();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvGiaoVien.DataSource = SQL.datatable("Select * from GiaoVien");
            SQL.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = txtMaGV.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Không được để trống mã Giáo Viên!");
                return;
            }

            
            if (!SQL.CheckPK("GiaoVien", new string[] { $"MaGiaoVien = '{ma}'" }))
            {
                MessageBox.Show("Trùng khóa chính!");
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string ngaySinh = dtNgaySinh.Value.ToString("yyyy-MM-dd");              
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string chuyenMon = txtChuyenMon.Text.Trim();
            string query = $@"
                INSERT INTO GiaoVien(MaGiaoVien, TenGiaoVien, NgaySinh, DiaChi, SoDienThoai, ChuyenMon)
                VALUES ('{ma}', N'{hoTen}', N'{ngaySinh}', '{diaChi}', '{soDienThoai}', '{chuyenMon}')
            ";

            SQL.Connect();
            SQL.Insert(query);
            SQL.Close();
            ReLoadDTGV();
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtChuyenMon.Clear();
            dtNgaySinh.Value = dtNgaySinh.MaxDate; 
            txtMaGV.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maGiaoVien = txtMaGV.Text.Trim();
            if (string.IsNullOrEmpty(maGiaoVien))
            {
                MessageBox.Show("Mã giáo viên không được để trống!");
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string ngaySinh = dtNgaySinh.Value.ToString("yyyy-MM-dd");
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string chuyenMon = txtChuyenMon.Text.Trim();

            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(hoTen)) updates.Add($"TenGiaoVien = N'{hoTen}'");
            if (!string.IsNullOrEmpty(diaChi)) updates.Add($"DiaChi = N'{diaChi}'");
           
            
            if (!string.IsNullOrEmpty(soDienThoai)) updates.Add($"SoDienThoai = '{soDienThoai}'");
            if (!string.IsNullOrEmpty(chuyenMon)) updates.Add($"ChuyenMon = '{chuyenMon}'");

            if (updates.Count == 0)
            {
                MessageBox.Show("Không có thông tin nào để cập nhật!");
                return;
            }

            string query = $"UPDATE GiaoVien SET {string.Join(", ", updates)} WHERE MaGiaoVien = '{maGiaoVien}'";

            SQL.Connect();

            try
            {
                int result = SQL.updateD(query);
                MessageBox.Show($"Cập Nhật Thành Công.");
                ReLoadDTGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }

            SQL.Close();
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maGiaoVien = txtMaGV.Text.Trim();
            if (string.IsNullOrEmpty(maGiaoVien))
            {
                MessageBox.Show("Vui lòng chọn mã giáo viên cần xóa!");
                return;
            }

            SQL.Connect();

            try
            {
                string query = $"DELETE FROM GiaoVien WHERE MaGiaoVien = '{maGiaoVien}'";
                int result = SQL.DeleteD(query);

                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    ReLoadDTGV();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Giáo Viên cần xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }

            SQL.Close();
            ResetForm();
        }

        
        

        private void btnFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM GiaoVien";
            TimKiemGiaoVien fgv = new TimKiemGiaoVien();

            if (fgv.ShowDialog() == DialogResult.OK) // Chỉ chạy khi người dùng nhập và đóng form
            {
                string[] result = fgv.x;
                List<string> filters = result.Where(r => !string.IsNullOrEmpty(r)).ToList(); // Lọc giá trị rỗng

                if (filters.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", filters); // Ghép điều kiện SQL
                }
            }

            MessageBox.Show(query);
            dgvGiaoVien.DataSource = SQL.datatable(query);
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            if (e.RowIndex < 0) return; // Đảm bảo không click vào tiêu đề

            DataGridViewRow row = dgvGiaoVien.Rows[e.RowIndex];

            // Lấy dữ liệu từ DataGridView
            string id = row.Cells["MaGiaoVien"].Value?.ToString();
            string name = row.Cells["TenGiaoVien"].Value?.ToString();
            string dt = row.Cells["DiaChi"].Value?.ToString();
            DateTime timeOld = Convert.ToDateTime(row.Cells["NgaySinh"].Value);       
            string SDT = row.Cells["SoDienThoai"].Value?.ToString();
            string ChuyenMon = row.Cells["ChuyenMon"].Value?.ToString();

            // Gán giá trị vào các control
            txtMaGV.Text = id;
            txtHoTen.Text = name;
            txtDiaChi.Text = dt;
            dtNgaySinh.Value = timeOld;     
            txtSoDienThoai.Text = SDT;
            txtChuyenMon.Text = ChuyenMon;
        }
    }
}
