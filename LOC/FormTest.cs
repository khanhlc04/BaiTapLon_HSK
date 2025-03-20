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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void LoadCrystalReport()
        {
            string connectionString = "Server=DESKTOP-V1JF8LF;Database=QUANLYHOCSINH;Integrated Security=True;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetGiaoVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ChuyenMon", txtTest.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ReportDocument rptDoc = new ReportDocument();
                    rptDoc.Load(@"D:\BaiTapLon_HSK\LOC\rptTest.rpt");
                    rptDoc.SetDataSource(dt);

                    crystalReportViewer1.ReportSource = rptDoc;
                    crystalReportViewer1.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCrystalReport();
        }
    }
}