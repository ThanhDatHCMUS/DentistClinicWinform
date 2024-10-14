using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class LoadPatientDAO
    {
        public static LoadPatientDAO instance;
        public static LoadPatientDAO Instance
        {
            get { if (instance == null) instance = new LoadPatientDAO(); return instance; }
            private set { LoadPatientDAO.instance = value; }
        }
        private LoadPatientDAO() { }
        public DataTable LoadListPatient()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListPatient");
        }
        public int InsertPatient(string idPatient, Human h)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec InsertPatient '" + idPatient
                + "', N'" + h.fullName
                + "', N'" + h.gender
                + "', '" + h.dateOfBirth
                + "', N'" + h.address
                + "', '" + h.email
                + "', '" + h.iD
                + "', '" + h.phoneNumber + "'");
        }
        public int UpdatePatient(string idPatient, Human h)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec UpdatePatient '" + idPatient
                + "', N'" + h.fullName
                + "', N'" + h.gender
                + "', '" + h.dateOfBirth
                + "', N'" + h.address
                + "', '" + h.email
                + "', '" + h.iD
                + "', '" + h.phoneNumber + "'");
        }
        public int DeletePatient(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec DeletePatient '" + idPatient + "'");
        }
        public int isPatient(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[existPatient]('" + idPatient + "')");
        }
        public DataTable searchPatient(string name)
        {
            return DataProvider.Instance.ExecuteQuery("exec searchPatient N'" + name + "'");
        }
        public int countPatient()
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countPatient]()");
        }
        public int countSearch(string text)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countSearchPatient]('" + text + "')");
        }
        public int countMedicine()
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countMedicine]()");
        }
        
    }
}
