using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_PhongKham.DAO
{
    public class ReportDAO
    {
        public static ReportDAO instance;
        public static ReportDAO Instance
        {
            get { if (instance == null) instance = new ReportDAO(); return instance; }
            private set { ReportDAO.instance = value; }
        }
        private ReportDAO() { }
        public int getTypeDentist(string idDentist)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getTypeDentist]('" + idDentist + "')");
        }
        public DataTable showReportCheck(string idDentist, string dateFrom, string dateTo)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec reportCheck '" + idDentist + "', '" + dateFrom + "', '" + dateTo + "'");
        }
        public DataTable showReportTreat(string idDentist, string dateFrom, string dateTo)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec reportTreat '" + idDentist + "', '" + dateFrom + "', '" + dateTo + "'");
        }
        public DataTable LoadDentist()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadDentist");
        }
    }
}
