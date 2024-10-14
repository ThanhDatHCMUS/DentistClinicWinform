using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class LoadMedicineDAO
    {
        public static LoadMedicineDAO instance;
        public static LoadMedicineDAO Instance
        {
            get { if (instance == null) instance = new LoadMedicineDAO(); return instance; }
            private set { LoadMedicineDAO.instance = value; }
        }
        private LoadMedicineDAO() { }
        public DataTable LoadListMedicine()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListMedicine");
        }
        public int InsertMedicine(Medicine m)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec InsertMedicine '" + m.idMedicine
                + "', N'" + m.nameMedicine
                + "', N'" + m.unit
                + "', N'" + m.CCD + "', "
                + m.price.ToString());
                
        }
        public int UpdateMedicine(Medicine m)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec UpdateMedicine '" + m.idMedicine
                + "', N'" + m.nameMedicine
                + "', N'" + m.unit
                + "', N'" + m.CCD + "', "
                + m.price.ToString());
        }
        public int DeleteMedicine(string idMedicine)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteMedicine '" + idMedicine + "'");
        }
        public int ExistMedicine(string idMedicine)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[ExistMedicine]('" + idMedicine + "')");
        }
        public int countMedicine()
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countMedicine]()");
        }
        public int countSearchMedicine(string text)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countSearchMedicine]('" + text + "')");
        }
        public DataTable searchMedicine(string name)
        {
            return DataProvider.Instance.ExecuteQuery("exec searchMedicine N'" + name + "'");
        }
    }
}
