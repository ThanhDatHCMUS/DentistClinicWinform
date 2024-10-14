using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class RequestCheckDAO
    {
        public static RequestCheckDAO instance;
        public static RequestCheckDAO Instance
        {
            get { if (instance == null) instance = new RequestCheckDAO(); return instance; }
            private set { RequestCheckDAO.instance = value; }
        }
        private RequestCheckDAO() { }
        public DataTable LoadRequestCheck()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadRequestCheck");
        }
        public int deleteRequestCheck(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec deleteRequestCheck " + id.ToString());
        }
    }
}
