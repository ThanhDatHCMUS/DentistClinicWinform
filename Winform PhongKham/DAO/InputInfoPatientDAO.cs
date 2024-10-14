using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class InputInfoPatientDAO
    {
        public static InputInfoPatientDAO instance;
        public static InputInfoPatientDAO Instance
        {
            get { if (instance == null) instance = new InputInfoPatientDAO(); return instance; }
            private set { InputInfoPatientDAO.instance = value; }
        }
        private InputInfoPatientDAO() { }
        public int insertPatient(Human h)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec InsertPatient '" 
                + "', N'" + h.fullName
                + "', N'" + h.gender
                + "', '" + h.dateOfBirth
                + "', N'" + h.address
                + "', '" + h.email
                + "', '" + h.iD
                + "', '" + h.phoneNumber + "'");
        }
        public string getIDPatient(string id)
        {
            return DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getIDPatientFromID]('" + id + "')").ToString();
        }
    }
}
