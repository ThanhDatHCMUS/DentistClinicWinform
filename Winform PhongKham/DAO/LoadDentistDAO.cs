using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class LoadDentistDAO
    {
        public static LoadDentistDAO instance;
        public static LoadDentistDAO Instance
        {
            get { if (instance == null) instance = new LoadDentistDAO(); return instance; }
            private set { LoadDentistDAO.instance = value; }
        }
        private LoadDentistDAO() { }
        public DataTable LoadListDentist()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListDentist");
        }
        public int InsertDentist(Dentist h)
        {
            int type = h.type == "Khám bệnh" ? 0 : 1;
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec InsertDentist '" + h.idDentist
                + "', N'" + h.fullName
                + "', N'" + h.gender
                + "', '" + h.dateOfBirth
                + "', N'" + h.address
                + "', '" + h.email
                + "', '" + h.iD
                + "', '" + h.phoneNumber
                + "', '" + h.idBranch + "'," + type.ToString());
        }
        public int UpdateDentist(Dentist h)
        {
            int type = h.type == "Khám bệnh" ? 0 : 1;
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec UpdateDentist '" + h.idDentist
                + "', N'" + h.fullName
                + "', N'" + h.gender
                + "', '" + h.dateOfBirth
                + "', N'" + h.address
                + "', '" + h.email
                + "', '" + h.iD
                + "', '" + h.phoneNumber
                + "', '" + h.idBranch + "'," + type.ToString());
        }
        public int DeleteDentist(string idDentist)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteDentist '" + idDentist + "'");
        }
        public DataTable LoadListChiNhanh()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListChiNhanh");
        }
        public DataTable searchDentist(string name)
        {
            return DataProvider.Instance.ExecuteQuery("exec searchDentist N'" + name + "'");
        }
        public int existDentist(string idDentist)
        {
            return (int)DataProvider.Instance.ExecuteScalar("select [dbo].[existDentist]('" + idDentist + "')");
        }
        public int countDentist()
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countDentist]()");
        }
        public int countSearchDentist(string text)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countSearchDentist]('" + text + "')");
        }
    }
}
