using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class CreatePayDAO
    {
        public static CreatePayDAO instance;
        public static CreatePayDAO Instance
        {
            get { if (instance == null) instance = new CreatePayDAO(); return instance; }
            private set { CreatePayDAO.instance = value; }
        }
        private CreatePayDAO() { }
        public DataTable LoadNeedPayMedicine(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec NeedPayMedicine '" + idPatient + "', '" + date + "'");
        }
        public DataTable LoadNeedPayTreat(string idPatient, string date)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec NeedPayTreat '" + idPatient + "', '" + date + "'");
        }
        public DataTable LoadNeedPayDay(string idPatient)
        {
            return DataProvider.Instance.ExecuteQuery
                ("exec NeedPayDay '" + idPatient + "'");
        }
        public int getNeedPay(string idPatient)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[NeedPay]('" + idPatient + "')");
        }
        public int insertPay(Payment p)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery("exec InsertPay '" +
                p.idPateint + "', N'" +
                p.name + "', N'" + 
                p.note + "', " + 
                p.money.ToString() + "," + 
                p.type.ToString() + ", " + 
                p.total.ToString());
        }
    }
}
