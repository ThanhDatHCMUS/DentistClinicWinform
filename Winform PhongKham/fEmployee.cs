using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham
{
    public partial class fEmployee : Form
    {
        public DataTable curlistEmployee = new DataTable();
        public int curPage = 1;
        public static int pageSize = 20;
        public int countEmployee = LoadEmployeeDAO.Instance.countEmployee();
        public int countPage;
        public fEmployee()
        {
            InitializeComponent();
            curlistEmployee = LoadEmployeeDAO.Instance.LoadListEmployee();
            LoadListEmployee();
            LoadGender();
            countPage = countEmployee % pageSize == 0 ? countEmployee / pageSize : countEmployee / pageSize + 1;

            if (Const.Instance.type == 1)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
            }
            dtgvListEmployee.Columns["rowindex"].Visible = false;
        }
        void LoadGender()
        {
            comboGender.Items.Add("Nam");
            comboGender.Items.Add("Nữ");
        }
        void LoadListEmployee()
        {
            dtgvListEmployee.DataSource = LoadPage();
        }
        public DataTable LoadPage()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("SDT");
            dt.Columns.Add("rowindex");
            foreach (DataRow row in curlistEmployee.Rows)
            {
                if (int.Parse((row[8].ToString())) < (curPage - 1) * pageSize + 1 ||
                    int.Parse((row[8].ToString())) > pageSize * curPage) continue;
                dt.ImportRow(row);
            }
            return dt;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        void updateCur()
        {
            curlistEmployee = LoadEmployeeDAO.Instance.LoadListEmployee();
            countEmployee = LoadEmployeeDAO.Instance.countEmployee();
            countPage = countEmployee % pageSize == 0 ? countEmployee / pageSize : countEmployee / pageSize + 1;
            curPage = 1;
            dtgvListEmployee.DataSource = LoadPage();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fEmployee_Load(object sender, EventArgs e)
        {

        }

        private void dtgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListEmployee.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvListEmployee.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvListEmployee.Rows[rowId];
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtIDEmployee.Text = row.Cells[0].Value.ToString(); 
            txtAddress.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
            txtID.Text = row.Cells[6].Value.ToString();
            txtPhoneNumber.Text  = row.Cells[7].Value.ToString();
            comboGender.Text = row.Cells[2].Value.ToString();
            dateDateOfBirth.Text = row.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dateDateOfBirth.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không phù hợp");
                return;
            }
            if (dateDateOfBirth.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không phù hợp");
                return;
            }
            Human h = new Human
                (txtFullName.Text, txtID.Text, comboGender.Text, txtAddress.Text,
                txtPhoneNumber.Text, dateDateOfBirth.Text, txtEmail.Text);
            try
            {
                int i = LoadEmployeeDAO.Instance.InsertEmployee(txtIDEmployee.Text, h);
                Const.Instance.show("Thêm nhân viên", i);
                if (i > 0)
                {
                    updateCur();
                    LoadListEmployee();
                }
            }
            catch
            {
                MessageBox.Show("Số điện thoại hoặc CCCD hoặc Email đã tồn tại!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dateDateOfBirth.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không phù hợp");
                return;
            }
            if (dateDateOfBirth.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không phù hợp");
                return;
            }
            Human h = new Human
                (txtFullName.Text, txtID.Text, comboGender.Text, txtAddress.Text,
                txtPhoneNumber.Text, dateDateOfBirth.Text, txtEmail.Text);
            try
            {
                int i = LoadEmployeeDAO.Instance.UpdateEmployee(txtIDEmployee.Text, h);
                Const.Instance.show("Cập nhật nhân viên", i);
                if (i > 0)
                {
                    updateCur();
                    LoadListEmployee();
                }
            }
            catch
            {
                MessageBox.Show("Số điện thoại hoặc CCCD hoặc Email đã tồn tại!!!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = LoadEmployeeDAO.Instance.DeleteEmployee(txtIDEmployee.Text);
            Const.Instance.show("Xóa nhân viên", i);
            if (i > 0) LoadListEmployee();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            curlistEmployee = LoadEmployeeDAO.Instance.searchEmployee(txtFind.Text);
            countEmployee = LoadEmployeeDAO.Instance.countSearchEmployee(txtFind.Text);
            countPage = countEmployee % pageSize == 0 ? countEmployee / pageSize : countEmployee / pageSize + 1;
            curPage = 1;
            dtgvListEmployee.DataSource = LoadPage();
        }

        private void btnDecre_Click(object sender, EventArgs e)
        {
            if (curPage == 1) return;
            curPage--;
            LoadListEmployee();
        }

        private void btnIncre_Click(object sender, EventArgs e)
        {
            if (curPage == countPage) return;
            curPage++;
            LoadListEmployee();
        }
    }
}
