using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class HistoryMedicineDAO
    {
        public static HistoryMedicineDAO instance;
        public static HistoryMedicineDAO Instance
        {
            get { if (instance == null) instance = new HistoryMedicineDAO(); return instance; }
            private set { HistoryMedicineDAO.instance = value; }
        }
        private HistoryMedicineDAO() { }
        public DataTable LoadDateTreat(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListDateTreat '" + idPatient + "'");
        }
        public DataTable LoadListMedicineTreat(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListMedicineTreat '" + idPatient + "', '" + date + "'");
        }
        public DataTable LoadAddMedicine(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListMedicineAdd '" + idPatient + "', '" + date + "'");
        }
        public DataTable LoadUpdateMedicine(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListMedicineDelete '" + idPatient + "', '" + date + "'");
        }
        public int AddMedicineTreat(TreatMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec AddMedicineTreat '" + s.idPatient
                + "', '" + s.date
                + "', '" + s.idMedicine
                + "', " + s.quantity.ToString()
                + ", " + (this.getPriceMedicine(s.idMedicine)).ToString());
        }
        public int UpdateMedicineTreat(TreatMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec UpdateMedicineTreat '" + s.idPatient
                + "', '" + s.date
                + "', '" + s.idMedicine
                + "', " + s.quantity.ToString());
        }
        public int DeleteMedicineTreat(TreatMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteMedicineTreat '" + s.idPatient
                + "', '" + s.date
                + "', '" + s.idMedicine + "'");
        }
        public int DeleteAllMedicineTreat(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteAllMedicineTreat '" + idPatient
                + "', '" + date + "'");
        }
        public string getUnit(string idMedicine)
        {
            return (string)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getUnitMedicine]( '" + idMedicine + "')");

        }
        public int setTotalMedicine(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec setTotalMedicine '" + idPatient + "', '" + date + "'");
        }
        public int getPriceMedicine(string idMedicine)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getPriceCurrent]('" + idMedicine + "')");
        }
        public int existDayNotPay(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[existDayNotPay]('" + idPatient + "')");
        }
        public int paidPlanTreat(string idPatient, string date)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[paidPlanTreat]('" + idPatient + "', '" + date + "')");
        }
    }
}
