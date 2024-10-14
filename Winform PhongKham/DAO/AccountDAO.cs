using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DAO
{
    public class AccountDAO
    {
        public static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }
        public int isAdmin(string userName, string password) 
        {
            return (int)DataProvider.Instance.ExecuteScalar("select [dbo].[IsAAdmin]('" + userName + "', '" + password + "')");
        }
        public int isDentist(string userName, string password)
        {
            return (int)DataProvider.Instance.ExecuteScalar("select [dbo].[IsDentist]('" + userName + "', '" + password + "')");
        }
        public int isEmployee(string userName, string password)
        {
            return (int)DataProvider.Instance.ExecuteScalar("select [dbo].[IsEmployee]('" + userName + "', '" + password + "')");
        }
        public string getIDDentistFromUsername(string userName)
        {
            return DataProvider.Instance.ExecuteScalar
                ("select [dbo].[getIDDentistFromUsername]('" + userName + "')").ToString();
        }
    }
}
