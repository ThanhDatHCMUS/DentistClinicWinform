using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class CreateAppointmentDAO
    {
        public static CreateAppointmentDAO instance;
        public static CreateAppointmentDAO Instance
        {
            get { if (instance == null) instance = new CreateAppointmentDAO(); return instance; }
            private set { CreateAppointmentDAO.instance = value; }
        }
        private CreateAppointmentDAO() { }
        public DataTable LoadHistoryAppointment(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadHistoryAppointment '" + idPatient + "'");
        } 
        public string getNearestTime(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteScalar
                ("select [dbo].[nearestTime](" + idPatient + "', '"+ date + "')").ToString();
        }
        public DataTable LoadDentistCanCheck(string date, string time, string idBranch)
        {
            //MessageBox.Show("exec DentistCanCheck '" + date + "', '" + time + "', '" + idBranch + "'");
            return DataProvider.Instance.ExecuteQuery("exec DentistCanCheck '" + date + "', '" + time + "', '" + idBranch + "'");
        }
        public DataTable LoadTimeCanCheck(string part, string idDentist, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadTimeCanCheck '" + idDentist + "', '" + date + "', " + part);
        }
        public int existCheck(string idPatient, string date)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[existCheck]('" + idPatient + "', '" + date + "')");
        }
        public int insertAppoinment(Appointment a)
        {
            if(string.IsNullOrEmpty(a.dateRecheck))
            { 
                return (int)DataProvider.Instance.ExecuteNonQuery("exec insertAppointment '" +
                    a.idPatient + "', '" + a.date + "', '" + a.idDentist +
                    "', NULL, " + a.orderNumber);
            }
            return (int)DataProvider.Instance.ExecuteNonQuery("exec insertAppointment '" +
                    a.idPatient + "', '" + a.date + "', '" + a.idDentist +
                    "', '"+ a.dateRecheck + "', " + a.orderNumber);
        }
        public DataTable LoadListBranch()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListChiNhanh ");
        }
    }
}
