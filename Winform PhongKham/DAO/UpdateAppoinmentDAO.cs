using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class UpdateAppointmentDAO
    {
        public static UpdateAppointmentDAO instance;
        public static UpdateAppointmentDAO Instance
        {
            get { if (instance == null) instance = new UpdateAppointmentDAO(); return instance; }
            private set { UpdateAppointmentDAO.instance = value; }
        }
        private UpdateAppointmentDAO() { }
        public DataTable LoadHistoryAppointment(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadHistoryAppointment '" + idPatient + "'");
        }
        public string getNearestTime(string idDentist)
        {
            return DataProvider.Instance.ExecuteScalar
                ("select [dbo].[nearestTime](" + idDentist + "')").ToString();
        }
        public DataTable LoadDentistCanCheck(string date, string time, string idBranch)
        {
            return DataProvider.Instance.ExecuteQuery("exec DentistCanCheck '" + date + "', " + time + ", '" + idBranch + "'");
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
        public int updateAppoinment(Appointment a)
        {
            if (string.IsNullOrEmpty(a.dateRecheck))
            {
                return (int)DataProvider.Instance.ExecuteNonQuery("exec UpdateAppointment '" +
                    a.idPatient + "', '" + a.date + "', '" + a.idDentist +
                    "', NULL, " + a.orderNumber);
            }
            return (int)DataProvider.Instance.ExecuteNonQuery("exec UpdateAppointment '" +
                    a.idPatient + "', '" + a.date + "', '" + a.idDentist +
                    "', '" + a.dateRecheck + "', " + a.orderNumber);
        }
    }
}
