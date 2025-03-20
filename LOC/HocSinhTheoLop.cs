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
    public partial class HocSinhTheoLop : Form
    {
        sql SQL = new sql();
        public HocSinhTheoLop()
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
        private void LoadReport(string maHocSinh, int maHocKi)
        {
            string connectionString = "Server=LAPTOPCUATRUONG;Database=QUANLYHOCSINH;Integrated Security=True;";
            string query = @"
        SELECT hs.MaHocSinh, hs.HoTenHocSinh, hs.
        FROM HoSoHocSinh hs
        
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
                rpt.Load(@"C:\Users\ADMIN\BaiTapLon_HSK\LOC\rptDiemTheoHocSinh.rpt");
                rpt.SetDataSource(dt);

                rptHocSinhTheoLop.ReportSource = rpt;
                rptHocSinhTheoLop.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }
    }
}
