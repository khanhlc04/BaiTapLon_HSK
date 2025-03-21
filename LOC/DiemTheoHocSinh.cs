using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.LOC
{
    public partial class DiemTheoHocSinh : Form
    {
        sql SQL = new sql();
        public DiemTheoHocSinh()
        {
            InitializeComponent();
            LoadLop();
        }
        private void LoadLop()
        {
            SQL.Connect();
            DataTable dtLop = sql.GetData("SELECT * FROM Lop Where deleted = 0");
            SQL.FillComboBox(cboLop, dtLop, "TenLop", "MaLop");
            cboLop.SelectedIndex = -1;
        }
        private void LoadHocSinh(string maLop)
        {
            SQL.Connect();
            DataTable dt = sql.GetData($"SELECT MaHocSinh, HoTenHocSinh FROM HoSoHocSinh WHERE deleted = 0 AND MaLop = '{maLop}'");
            SQL.FillComboBox(cboHocSinh, dt, "HoTenHocSinh", "MaHocSinh");
            cboHocSinh.SelectedIndex = -1;
        }


        private void rptDiemTheoHocSinh_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboHocSinh.SelectedValue == null || cboHocKi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp, học sinh và học kỳ trước khi xem báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHocSinh = cboHocSinh.SelectedValue.ToString();
            int maHocKi = Convert.ToInt32(cboHocKi.SelectedItem);
            LoadReport(maHocSinh, maHocKi);
        }


        private void LoadReport(string maHocSinh, int maHocKi)
        {
            string connectionString = "Server=DESKTOP-V1JF8LF;Database=QUANLYHOCSINH;Integrated Security=True;";
            string query = @"
                SELECT dm.MaMonHoc, hs.MaHocSinh, hs.HoTenHocSinh, mh.TenMonHoc, dm.DiemGiuaKi, dm.DiemCuoiKi, dm.MaHocKi
                FROM DiemMonHoc dm
                JOIN HoSoHocSinh hs ON dm.MaHocSinh = hs.MaHocSinh
                JOIN MonHoc mh ON dm.MaMonHoc = mh.MaMonHoc
                JOIN Lop l ON hs.MaLop = l.MaLop
                WHERE hs.MaHocSinh = @MaHocSinh AND dm.MaHocKi = @MaHocKi
            ";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHocSinh", maHocSinh);
                        cmd.Parameters.AddWithValue("@MaHocKi", maHocKi);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"D:\BaiTapLon_HSK\LOC\rptDiemTheoHocSinh.rpt");
                rpt.SetDataSource(dt);

                rptDiemTheoHocSinh.ReportSource = rpt;
                rptDiemTheoHocSinh.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue != null)
            {
                string maLop = cboLop.SelectedValue.ToString();
                LoadHocSinh(maLop);
            }
        }

        private void cboHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
