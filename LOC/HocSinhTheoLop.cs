using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
            DataTable dtLop = sql.GetData("SELECT * FROM Lop Where deleted = 0");
            SQL.FillComboBox(cboLop, dtLop, "TenLop", "MaLop");
            cboLop.SelectedIndex = -1;
        }
        private void LoadReport(string maLop)
        {
            string connectionString = "Server=DESKTOP-V1JF8LF;Database=QUANLYHOCSINH;Integrated Security=True;";
            string query = @"
                SELECT *
                FROM HoSoHocSinh
                WHERE MaLop = @MaLop";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", maLop);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"D:\BaiTapLon_HSK\LOC\rptHocSinhTheoLop.rpt");

                ConnectionInfo connInfo = new ConnectionInfo();
                connInfo.ServerName = "DESKTOP-V1JF8LF"; // Ví dụ: "localhost"
                connInfo.DatabaseName = "QUANLYHOCSINH"; // Ví dụ: "QLSV"

                // Áp dụng thông tin kết nối cho từng bảng trong báo cáo
                Tables tables = rpt.Database.Tables;
                foreach (Table table in tables)
                {
                    TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                    tableLogOnInfo.ConnectionInfo = connInfo;
                    table.ApplyLogOnInfo(tableLogOnInfo);
                }

                rpt.SetDataSource(dt);

                rptHocSinhTheoLop.ReportSource = rpt;
                rptHocSinhTheoLop.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp trước khi xem báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = cboLop.SelectedValue.ToString();
            MessageBox.Show("Mã lớp đang chọn: " + maLop);

            LoadReport(maLop);
        }
    }
}
