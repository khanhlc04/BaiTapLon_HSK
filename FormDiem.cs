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
    public partial class FormDiem : Form
    {
        sql SQL = new sql();
        public FormDiem()
        {
            InitializeComponent();
        }

        private void reloadDTHS()
        {
            SQL.Connect();
            dgvDiemHocSinh.DataSource = SQL.datatable("SELECT * FROM DiemMonHoc");
            numDiemGiuaKi.Value = 0;
            numDiemCuoiKi.Value = 0;
            SQL.Close();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void loadDropList()
        {
            SQL.Connect();
            DataTable monhoc = SQL.datatable("SELECT * FROM MonHoc");
            SQL.FillComboBox(cbbMonHoc, monhoc, "TenMonHoc", "MaMonHoc");

            DataTable hocsinh = SQL.datatable("SELECT * FROM HoSoHocSinh");
            SQL.FillComboBox(cbbHocSinh, hocsinh, "HoTenHocSinh", "MaHocSinh");

            DataTable giaovien = SQL.datatable("SELECT * FROM GiaoVien");
            SQL.FillComboBox(cbbGiaoVien, giaovien, "TenGiaoVien", "MaGiaoVien");

            DataTable hocSinh = SQL.datatable("SELECT * FROM Lop");
            SQL.FillComboBox(cbbLop, hocSinh, "TenLop", "MaLop");

            cbbHocKi.Items.Add("1");
            cbbHocKi.Items.Add("2");
            cbbHocKi.SelectedIndex = 0;
            SQL.Close();
        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            reloadDTHS();
            loadDropList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQL.Connect();

            // Lấy giá trị từ các ComboBox
            string maHocSinh = cbbHocSinh.SelectedValue?.ToString() ?? "";
            string maMonHoc = cbbMonHoc.SelectedValue?.ToString() ?? "";
            string maGiaoVien = cbbGiaoVien.SelectedValue?.ToString() ?? "";
            string hocKi = cbbHocKi.SelectedItem?.ToString() ?? "1";
            string maLop = cbbLop.SelectedValue?.ToString() ?? "";

            // Lấy điểm từ NumericUpDown
            float diemGiuaKi = (float)numDiemGiuaKi.Value;
            float diemCuoiKi = (float)numDiemCuoiKi.Value;

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(maHocSinh) || string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(maGiaoVien) || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            // Kiểm tra trùng khóa chính
            if (!SQL.CheckPK("DiemMonHoc", new string[] { $"MaHocSinh = '{maHocSinh}'", $"MaMonHoc = '{maMonHoc}'", $"MaHocKi = '{hocKi}'", $"MaLop = '{maLop}'" }))
            {
                MessageBox.Show("Trùng khóa chính! Học sinh này đã có điểm cho môn học này trong học kỳ này.");
                return;
            }

            // Câu lệnh SQL thêm điểm vào bảng DiemMonHoc
            string query = $@"
                INSERT INTO DiemMonHoc (MaHocSinh, MaLop, MaMonHoc, MaGiaoVien, MaHocKi, DiemGiuaKi, DiemCuoiKi, HeSoDiemGiuaKi, HeSoDiemCuoiKi)
                VALUES ('{maHocSinh}', '{maLop}', '{maMonHoc}', '{maGiaoVien}', '{hocKi}', {diemGiuaKi}, {diemCuoiKi}, {0.4}, {0.6})
            ";

            SQL.Insert(query);
            SQL.Close();

            // Refresh DataGridView
            reloadDTHS();

            MessageBox.Show("Thêm điểm thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQL.Connect();

            // Lấy giá trị từ các ComboBox
            string maHocSinh = cbbHocSinh.SelectedValue?.ToString() ?? "";
            string maMonHoc = cbbMonHoc.SelectedValue?.ToString() ?? "";
            string maGiaoVien = cbbGiaoVien.SelectedValue?.ToString() ?? "";
            string hocKi = cbbHocKi.SelectedItem?.ToString() ?? "1";
            string maLop = cbbLop.SelectedValue?.ToString() ?? "";

            // Lấy điểm từ NumericUpDown
            float diemGiuaKi = (float)numDiemGiuaKi.Value;
            float diemCuoiKi = (float)numDiemCuoiKi.Value;

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(maHocSinh) || string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(maGiaoVien) || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            // Kiểm tra xem dữ liệu có tồn tại không
            if (SQL.CheckPK("DiemMonHoc", new string[] { $"MaHocSinh = '{maHocSinh}'", $"MaMonHoc = '{maMonHoc}'", $"MaHocKi = '{hocKi}'", $"MaLop = '{maLop}'" }))
            {
                MessageBox.Show("Không tìm thấy điểm cần sửa!");
                return;
            }

            // Tạo danh sách cập nhật
            List<string> updates = new List<string>();
            updates.Add($"DiemGiuaKi = {diemGiuaKi}");
            updates.Add($"DiemCuoiKi = {diemCuoiKi}");
            updates.Add($"MaGiaoVien = '{maGiaoVien}'"); // Có thể thay đổi giáo viên nếu cần

            // Kiểm tra nếu không có gì để cập nhật
            if (updates.Count == 0)
            {
                MessageBox.Show("Không có thông tin nào để cập nhật!");
                return;
            }

            // Tạo câu lệnh UPDATE
            string query = $@"
                UPDATE DiemMonHoc 
                SET {string.Join(", ", updates)}
                WHERE MaHocSinh = '{maHocSinh}' AND MaMonHoc = '{maMonHoc}' AND MaHocKi = '{hocKi}' AND MaLop = '{maLop}'
            ";

            try
            {
                int result = SQL.updateD(query);
                MessageBox.Show($"Cập nhật điểm thành công!");
                reloadDTHS(); // Cập nhật lại bảng điểm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }

            SQL.Close();
        }

        private void dgvDiemHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng bấm vào hàng tiêu đề hoặc ngoài phạm vi dữ liệu
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDiemHocSinh.Rows[e.RowIndex];

            // Lấy dữ liệu từ DataGridView và hiển thị lên form
            cbbHocSinh.SelectedValue = row.Cells["MaHocSinh"].Value?.ToString().Trim() ?? "";
            cbbLop.SelectedValue = row.Cells["MaLop"].Value?.ToString().Trim() ?? "";
            cbbMonHoc.SelectedValue = row.Cells["MaMonHoc"].Value?.ToString().Trim() ?? "";
            cbbGiaoVien.SelectedValue = row.Cells["MaGiaoVien"].Value?.ToString().Trim() ?? "";
            cbbHocKi.SelectedItem = row.Cells["MaHocKi"].Value?.ToString().Trim() ?? "1";

            numDiemGiuaKi.Value = float.TryParse(row.Cells["DiemGiuaKi"].Value?.ToString(), out float diemGK) ? (decimal)diemGK : 0;
            numDiemCuoiKi.Value = float.TryParse(row.Cells["DiemCuoiKi"].Value?.ToString(), out float diemCK) ? (decimal)diemCK : 0;

            // Bật nút sửa và xóa
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maHocSinh = cbbHocSinh.SelectedValue?.ToString() ?? "";
            string maMonHoc = cbbMonHoc.SelectedValue?.ToString() ?? "";
            string hocKi = cbbHocKi.SelectedItem?.ToString() ?? "1";
            string maLop = cbbLop.SelectedValue?.ToString() ?? "";

            // Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrEmpty(maHocSinh) || string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin cần xóa!");
                return;
            }

            // Hỏi lại trước khi xóa
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa điểm của học sinh này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            SQL.Connect();

            try
            {
                // Kiểm tra xem điểm có tồn tại hay không trước khi xóa
                if (SQL.CheckPK("DiemMonHoc", new string[] { $"MaHocSinh = '{maHocSinh}'", $"MaMonHoc = '{maMonHoc}'", $"MaHocKi = '{hocKi}'", $"MaLop = '{maLop}'" }))
                {
                    MessageBox.Show("Không tìm thấy điểm cần xóa!");
                    return;
                }

                // Xóa dữ liệu
                string deleteQuery = $@"
                    DELETE FROM DiemMonHoc 
                    WHERE MaHocSinh = '{maHocSinh}' 
                    AND MaMonHoc = '{maMonHoc}' 
                    AND MaHocKi = '{hocKi}' 
                    AND MaLop = '{maLop}'
                ";

                int result = SQL.DeleteD(deleteQuery);

                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    reloadDTHS(); // Refresh bảng điểm
                }
                else
                {
                    MessageBox.Show("Lỗi: Không xóa được dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }

            SQL.Close();
        }

    }
}