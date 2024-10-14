using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class HistoryMedicineAppDAO
    {
        public static HistoryMedicineAppDAO instance;
        public static HistoryMedicineAppDAO Instance
        {
            get { if (instance == null) instance = new HistoryMedicineAppDAO(); return instance; }
            private set { HistoryMedicineAppDAO.instance = value; }
        }
        private HistoryMedicineAppDAO() { }
        public DataTable LoadDateApp(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListDateApp '" + idPatient + "'");
        }
        public DataTable LoadListMedicineApp(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListMedicineApp '" + idPatient + "', '" + date + "'");
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
        public int AddMedicineApp(TreatMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec AddMedicineApp '" + s.idPatient
                + "', '" + s.date
                + "', '" + s.idMedicine
                + "', " + s.quantity.ToString());
        }
        public int UpdateMedicineApp(TreatMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec UpdateMedicineApp '" + s.idPatient
                + "', '" + s.date
                + "', '" + s.idMedicine
                + "', " + s.quantity.ToString());
        }
        public int DeleteMedicineApp(TreatMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteMedicineApp '" + s.idPatient
                + "', '" + s.date
                + "', '" + s.idMedicine + "'");
        }
        public int DeleteAllMedicineApp(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteAllMedicineApp '" + idPatient
                + "', '" + date + "'");
        }
        public string getUnit(string idMedicine)
        {
            return (string)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getUnitMedicine]( '" + idMedicine + "')");

        }
    }
}
