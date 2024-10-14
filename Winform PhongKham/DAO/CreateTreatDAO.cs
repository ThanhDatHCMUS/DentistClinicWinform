using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class CreateTreatDAO
    {
        public static CreateTreatDAO instance;
        public static CreateTreatDAO Instance
        {
            get { if (instance == null) instance = new CreateTreatDAO(); return instance; }
            private set { CreateTreatDAO.instance = value; }
        }
        private CreateTreatDAO() { }

        public DataTable LoadDentistCanTreat(string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadDentistCanTreat '" + date + "'");
        }
        public DataTable LoadDentistCanAssistant(string date, string idDentist)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadDentistCanAssistant '" + date + "', '" + idDentist + "'");
        }
        public DataTable LoadListDirectory()
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListDirectory");
        }
        public DataTable LoadListChoosedDirectory(string directory) 
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadListDirectoryExcept '" + directory + "'");
        }
        public DataTable LoadListChooseTreat(string directory)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadTreatFromDirectory '" + directory + "'");
        }
        public int insertTreatPlanPatient(TreatPlan t)
        {
            if (!string.IsNullOrEmpty(t.idAssistant))
                return DataProvider.Instance.ExecuteNonQuery
                    ("exec insertTreatPlanPatient '" +
                    t.idPatient + "','" +
                    t.date + "','" +
                    t.idDentist + "','" +
                    t.idAssistant + "', N'" +
                    t.note + "','" +
                    t.sDirectory + "','" +
                    t.sTreat + "','" +
                    t.sTooth + "'");
            return DataProvider.Instance.ExecuteNonQuery
                    ("exec insertTreatPlanPatient '" +
                    t.idPatient + "','" +
                    t.date + "','" +
                    t.idDentist + "', NULL, N'" +
                    t.note + "','" +
                    t.sDirectory + "','" +
                    t.sTreat + "','" +
                    t.sTooth + "'");
        }
        public int existsTreatPlan(string idPatient, string date)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[ExistTreatPlan]('" + idPatient + "', '" + date + "')");
        }





        // Update
        public DataTable LoadDirectoryPatient(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadDirectoryPatient '" + idPatient + "', '" + date);
        }
        public DataTable LoadTreatPatient(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadTreatPatient '" + idPatient + "', '" + date);
        }
        public DataTable LoadToothPatient(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec LoadToothPateint '" + idPatient + "', '" + date);
        }
        public int updateTreatPlanPatient(TreatPlan t)
        {
            if (!string.IsNullOrEmpty(t.idAssistant))
                return DataProvider.Instance.ExecuteNonQuery
                    ("exec updateTreatPlanPatient '" +
                    t.idPatient + "','" +
                    t.date + "','" +
                    t.idDentist + "','" +
                    t.idAssistant + "', N'" +
                    t.note + "','" +
                    t.sDirectory + "','" +
                    t.sTreat + "','" +
                    t.sTooth + "'");
            return DataProvider.Instance.ExecuteNonQuery
                    ("exec updateTreatPlanPatient '" +
                    t.idPatient + "','" +
                    t.date + "','" +
                    t.idDentist + "', NULL, N'" +
                    t.note + "','" +
                    t.sDirectory + "','" +
                    t.sTreat + "','" +
                    t.sTooth + "'");
        }
    }
}
