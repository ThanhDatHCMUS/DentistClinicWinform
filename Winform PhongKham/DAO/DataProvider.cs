using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_PhongKham.DAO
{
    public class DataProvider
    {
        public static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string connectString = "Data Source=LAPTOP-2M43FPRT;Initial Catalog=PhongKham;Integrated Security=True;";
        
        public DataTable ExecuteQuery(string query)
        {
            //MessageBox.Show(query);

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(this.connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
            
        }
        public int ExecuteNonQuery(string query)
        {
            //MessageBox.Show(query);
            int res = 0;
            using (SqlConnection connection = new SqlConnection(this.connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                res = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return res;

        }
        public object ExecuteScalar(string query)
        {
            //MessageBox.Show(query);
            object res = 0;
            using (SqlConnection connection = new SqlConnection(this.connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                res = cmd.ExecuteScalar();
                connection.Close();
            }
            return res;

        }
    }
}
