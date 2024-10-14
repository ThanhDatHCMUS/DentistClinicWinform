using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class LoadHistoryPayDAO
    {
        public static LoadHistoryPayDAO instance;
        public static LoadHistoryPayDAO Instance
        {
            get { if (instance == null) instance = new LoadHistoryPayDAO(); return instance; }
            private set { LoadHistoryPayDAO.instance = value; }
        }
        private LoadHistoryPayDAO() { }

        public DataTable LoadHistoryPay(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadHistoryPay '" + idPatient + "'");
        }
    }
}
