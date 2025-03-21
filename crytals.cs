using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BTL
{
    internal class crytals
    {
        
        ReportDocument cryRpt; 
       
        public ReportDocument Load_crytal()
        {
            cryRpt = new ReportDocument();
            // Đường dẫn đến file Crystal Report (.rpt)
            string reportPath = $"{@"D:\BaiTapLon_HSK\LOC\KHOANG_DIEM_MON.rpt"}";
            cryRpt.Load(reportPath);

            // Tạo đối tượng kết nối CSDL
            ConnectionInfo connInfo = new ConnectionInfo();
            connInfo.ServerName = "DESKTOP-V1JF8LF"; // Ví dụ: "localhost"
            connInfo.DatabaseName = "QUANLYHOCSINH"; // Ví dụ: "QLSV"
            

            // Duyệt tất cả Table trong báo cáo và thiết lập kết nối cho mỗi bảng
            Tables tables = cryRpt.Database.Tables;
            foreach (Table table in tables)
            {
                TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                tableLogOnInfo.ConnectionInfo = connInfo;
                table.ApplyLogOnInfo(tableLogOnInfo);
            }

            return cryRpt;
        }
        public void addCondition(string condition)
        {
            cryRpt.RecordSelectionFormula = condition;
        }
        
    }
}