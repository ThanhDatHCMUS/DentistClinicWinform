using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class LoadDatePlanTreatDAO
    {
        public static LoadDatePlanTreatDAO instance;
        public static LoadDatePlanTreatDAO Instance
        {
            get { if (instance == null) instance = new LoadDatePlanTreatDAO(); return instance; }
            private set { LoadDatePlanTreatDAO.instance = value; }
        }
        private LoadDatePlanTreatDAO() { }
        public DataTable LoadDateTreat(string idPatient) 
        { 
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadDateTreat '" + idPatient + "'");
        }
    }
}
