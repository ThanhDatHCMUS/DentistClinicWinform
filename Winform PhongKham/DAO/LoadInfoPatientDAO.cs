using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class LoadInfoPatientDAO
    {
        public static LoadInfoPatientDAO instance;
        public static LoadInfoPatientDAO Instance
        {
            get { if (instance == null) instance = new LoadInfoPatientDAO(); return instance; }
            private set { LoadInfoPatientDAO.instance = value; }
        }
        private LoadInfoPatientDAO() { }
        public DataTable LoadInfoPatient(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery("exec showInfoPatient '" + idPatient + "'");
        }
        public int getTotalPrice(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[TotalPrice]('" + idPatient + "')");
        }
        public int getTotalPay(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[TotalPay]('" + idPatient + "')");
        }
        public int updateHealthCondition(string idPatient, string health)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec updateInfoHealth '" + idPatient + "', N'" + health + "'");
        }
        public int updateAllergy(string idPatient, string allergy)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec updateAllergy '" + idPatient + "', N'" + allergy + "'");
        }
        public DataTable LoadListCCD(string idPatient) 
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListCCD '" + idPatient + "'");
        }
        public DataTable LoadListAddCCD(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery("exec ListAddCCD '" + idPatient + "'");
        }
        public int addCCD(string idPatient, string idMedicine)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec AddCCD '" + idPatient + "', '" + idMedicine + "'");
        }
        public int deleteCCD(string idPatient, string idMedicine)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteCCD '" + idPatient + "', '" + idMedicine + "'");
        }
        public int existDateTreat(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[ExistDateTreat]('" + idPatient + "')");
        }
        public int existAppointment(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[existAppointment]('" + idPatient + "')");
        }
    }
}
