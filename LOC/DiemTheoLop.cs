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
    public partial class DiemTheoLop : Form
    {
        sql SQL = new sql();
        public DiemTheoLop()
        {
            InitializeComponent();
            LoadLop();
        }
        private void LoadLop()
        {
            SQL.Connect();
            DataTable dtLop = sql.GetData("SELECT * FROM Lop");
            SQL.FillComboBox(cboLop, dtLop, "TenLop", "MaLop");
            cboLop.SelectedIndex = -1;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboHocKi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp, học sinh và học kỳ trước khi xem báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = cboLop.SelectedValue.ToString();
            int maHocKi = Convert.ToInt32(cboHocKi.SelectedItem);
            LoadReport(maLop, maHocKi);
        }
        private void LoadReport(string maLop, int maHocKi)
        {
            string connectionString = "Server=LAPTOPCUATRUONG;Database=QUANLYHOCSINH;Integrated Security=True;";
            string query = @"
        SELECT dm.MaMonHoc, hs.MaHocSinh, hs.HoTenHocSinh, mh.TenMonHoc, dm.DiemGiuaKi, dm.DiemCuoiKi, dm.MaHocKi
        FROM DiemMonHoc dm
        JOIN HoSoHocSinh hs ON dm.MaHocSinh = hs.MaHocSinh
        JOIN MonHoc mh ON dm.MaMonHoc = mh.MaMonHoc
        JOIN Lop l ON hs.MaLop = l.MaLop
        WHERE l.MaLop = @MaLop AND dm.MaHocKi = @MaHocKi
    ";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        cmd.Parameters.AddWithValue("@MaHocKi", maHocKi);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"E:\Lập trình hướng sự kiện\BTL_LTHSK\BaiTapLon_HSK\LOC\rptDiemTheoLop.rpt");
                rpt.SetDataSource(dt);

                rptDiemTheoLop.ReportSource = rpt;
                rptDiemTheoLop.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }
    }
}
