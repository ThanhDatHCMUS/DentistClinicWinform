using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham.DAO
{
    public class LoadEmployeeDAO
    {
        public static LoadEmployeeDAO instance;
        public static LoadEmployeeDAO Instance
        {
            get { if (instance == null) instance = new LoadEmployeeDAO(); return instance; }
            private set { LoadEmployeeDAO.instance = value; }
        }
        private LoadEmployeeDAO() { }
        public DataTable LoadListEmployee()
        {
            return DataProvider.Instance.ExecuteQuery("exec LoadListEmployee");
        }
        public int InsertEmployee(string idEmployee, Human h)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec InsertEmployee '" + idEmployee
                + "', N'" + h.fullName
                + "', N'" + h.gender
                + "', '" + h.dateOfBirth
                + "', N'" + h.address
                + "', '" + h.email
                + "', '" + h.iD
                + "', '" + h.phoneNumber + "'");
        }
        public int countEmployee()
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[CountEmployee]()");
        }
        public int UpdateEmployee(string idEmployee, Human h)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec UpdateEmployee '" + idEmployee
                + "', N'" + h.fullName
                + "', N'" + h.gender
                + "', '" + h.dateOfBirth
                + "', N'" + h.address
                + "', '" + h.email
                + "', '" + h.iD
                + "', '" + h.phoneNumber + "'");
        }
        public int DeleteEmployee(string idEmployee)
        {
            return (int)DataProvider.Instance.ExecuteNonQuery
                ("exec DeleteEmployee '" + idEmployee + "'");
        }
        public DataTable searchEmployee(string name)
        {
            return DataProvider.Instance.ExecuteQuery("exec searchEmployee N'" + name + "'");
        }
        public int countSearchEmployee(string text)
        {
            return (int)DataProvider.Instance.ExecuteScalar
                ("select [dbo].[countsearchEmployee]('" + text + "')");
        }
    }
}
