using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class LoadAppointmentDAO
    {
        public static LoadAppointmentDAO instance;
        public static LoadAppointmentDAO Instance
        {
            get { if (instance == null) instance = new LoadAppointmentDAO(); return instance; }
            private set { LoadAppointmentDAO.instance = value; }
        }
        private LoadAppointmentDAO() { }
        public DataTable LoadListBranch()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListChiNhanh");
        }
        public DataTable LoadAppointmentDentist(string date, string idDentist)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadAppointmentDentist '" + date + "', '" + idDentist + "'");
        }
        public DataTable LoadAppointmentBranch(string date, string idBranch)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadAppointmentBranch '" + date + "', '" + idBranch + "'");
        }
        public DataTable LoadAppointmentPatient(string date, string name)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadAppointmentPatient '" + date + "', N'" + name + "'");
        }
        public DataTable LoadAppointment(string date) 
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListAppointment '" + date + "'");
        }
        public int deleteAppointment(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec deleteAppointment '" + idPatient + "', '" + date + "'");
        }
        public int countAppointment(string date)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countAppointment]('" + date + "')");
        }
        public int countAppointmentDentist(string date, string idDentist)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countAppointmentDentist]('" + date + "', '" + idDentist + "')");
        }
        public int countAppoinmentPatient(string date, string text)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countAppointmentPatient]('" + date + "','" + text + "')");
        }
        public int countAppoinmentBranch(string date, string idBranch)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countAppointmentBranch]('" + date + "','" + idBranch + "')");
        }
    }
}
