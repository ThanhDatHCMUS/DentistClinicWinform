using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class UpdateWorkScheduleDAO
    {
        public static UpdateWorkScheduleDAO instance;
        public static UpdateWorkScheduleDAO Instance
        {
            get { if (instance == null) instance = new UpdateWorkScheduleDAO(); return instance; }
            private set { UpdateWorkScheduleDAO.instance = value; }
        }
        private UpdateWorkScheduleDAO() { }
        public DataTable LoadListWorkSchedule(string idDentist)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadWorkSchedule '" + idDentist + "'");
        }
        public int DeleteWorkSchedule(string idDentist)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteWorkSchedule '" + idDentist + "'");
        }
        public int InsertWorkSchedule(string idDentist, string dateOfWeek, string session)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec InsertWorkSchedule '" + idDentist + "', " + dateOfWeek + "," + session);
        }

    }
}
