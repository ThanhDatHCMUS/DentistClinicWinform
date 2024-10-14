using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class LoadInfoMedicineDAO
    {
        public static LoadInfoMedicineDAO instance;
        public static LoadInfoMedicineDAO Instance
        {
            get { if (instance == null) instance = new LoadInfoMedicineDAO(); return instance; }
            private set { LoadInfoMedicineDAO.instance = value; }
        }
        private LoadInfoMedicineDAO() { }
        public DataTable LoadInfoMedicine(string idMedicine)
        {
            return DataProvider.Instance.ExecuteQuery("exec InfoMedicine '" + idMedicine + "'");
        }
        public DataTable LoadListStock(string idMedicine)
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListHSD '" + idMedicine + "'");
        } 
        public int AddStockMedicine(StockMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec AddHSD '" + s.idMedicine +
                "', '" + s.date + "', " + 
                s.quantity + ", N'" + s.unit + "'");
        }
        public int UpdateStockMedicine(StockMedicine s)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec UpdateHSD '" + s.idMedicine +
                "', '" + s.date + "', " +
                s.quantity + ", N'" + s.unit + "'");
        }
        public int DeleteStockMedicine(string idMedicine, string date)
        {
            return DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteHSD '" + idMedicine +
                "', '" + date + "'");
        }
        
    }
}
