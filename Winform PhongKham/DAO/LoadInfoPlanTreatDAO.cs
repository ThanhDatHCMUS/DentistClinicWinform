using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class LoadInfoPlanTreatDAO
    {
        public static LoadInfoPlanTreatDAO instance;
        public static LoadInfoPlanTreatDAO Instance
        {
            get { if (instance == null) instance = new LoadInfoPlanTreatDAO(); return instance; }
            private set { LoadInfoPlanTreatDAO.instance = value; }
        }
        private LoadInfoPlanTreatDAO() { }
        public DataTable showInfo(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec showInfoPlanTreat '" + idPatient + "', '" + date + "'");
        }
        public DataTable showDirectoryPatient(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec showDirectoryPatient '" + idPatient + "', '" + date + "'");
        }
        public DataTable showTreatPatient(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec showTreatPatient '" + idPatient + "', '" + date + "'");
        }
        public int cancelTreatPlan(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec cancelPlanTreat '" + idPatient + "', '" + date + "'");
        }
        public int isPayed(string idPatient, string date)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[isPayed]( '" + idPatient + "', '" + date + "')");
        }

    }
}
