using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class LoadDetailPayDAO
    {
        public static LoadDetailPayDAO instance;
        public static LoadDetailPayDAO Instance
        {
            get { if (instance == null) instance = new LoadDetailPayDAO(); return instance; }
            private set { LoadDetailPayDAO.instance = value; }
        }
        private LoadDetailPayDAO() { }
        public DataTable LoadNeedPayMedicine(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec NeedPayMedicine '" + idPatient + "', '" + date + "'");
        }
        public DataTable LoadNeedPayTreat(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec NeedPayTreat '" + idPatient + "', '" + date + "'");
        }

        public DataTable LoadDayPlanTreat(string idPatient, string orderNumber)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadDayPlanTreat '" + idPatient + "'," + orderNumber);
        }
        public string getDentistPlanTreat(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getDentistPlanTreat]('" + idPatient + "', '" + date + "')").ToString();
        }
        public string getNotePlanTreat(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getNotePlanTreat]('" + idPatient + "', '" + date + "')").ToString();
        }
    }
}
