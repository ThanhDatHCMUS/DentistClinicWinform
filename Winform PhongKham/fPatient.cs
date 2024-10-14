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
    public partial class fPatient : Form
    {
        public DataTable curlistPatient = new DataTable();
        public int curPage = 1;
        public static int pageSize = 20;
        public int countPatient = LoadPatientDAO.Instance.countPatient();
        int countPage;
        public fPatient()
        {
            InitializeComponent();
            curlistPatient = LoadPatientDAO.Instance.LoadListPatient();
            LoadListPatient();
            countPage = countPage = countPatient % pageSize == 0 ? countPatient / pageSize : countPatient / pageSize + 1;
            LoadGender();
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
            dtgvListPatient.Columns["rowindex"].Visible = false;
        }
        void LoadGender()
        {
            comboGender.Items.Add("Nam");
            comboGender.Items.Add("Nữ");
        }
        private void btnInfoPatient_Click(object sender, EventArgs e)
        {
            if (LoadPatientDAO.Instance.isPatient(txtIDPatient.Text) == 0)
            {
                MessageBox.Show("Nhập ID khách hàng!!!");
                return;
            }
            fInfoPatient f = new fInfoPatient(txtIDPatient.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void fPatient_Load(object sender, EventArgs e)
        {

        }
        private void LoadListPatient()
        {
            dtgvListPatient.DataSource = LoadPage();
        }
        private void dtgvListPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListPatient.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvListPatient.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvListPatient.Rows[rowId];
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtIDPatient.Text = row.Cells[0].Value.ToString();
            txtAddress.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
            txtID.Text = row.Cells[6].Value.ToString();
            txtPhoneNumber.Text = row.Cells[7].Value.ToString();
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
            Human h = new Human
                (txtFullName.Text, txtID.Text, comboGender.Text, txtAddress.Text,
                txtPhoneNumber.Text, dateDateOfBirth.Text, txtEmail.Text);
            try
            {

                int i = LoadPatientDAO.Instance.InsertPatient(txtIDPatient.Text, h);
                Const.Instance.show("Thêm khách hàng", i);
                if (i > 0)
                {
                    countPatient++;
                    this.countPage = countPatient % pageSize == 0 ? countPatient / pageSize : countPatient / pageSize + 1;
                    LoadListPatient();
                }
            }
            catch
            {
                MessageBox.Show("Số điện thoại hoặc CCCD hoặc Email không phù hợp!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
                int i = LoadPatientDAO.Instance.UpdatePatient(txtIDPatient.Text, h);
                Const.Instance.show("Cập nhật khách hàng", i);
                if (i > 0)
                {
                    updateCur();
                    LoadListPatient();
                }
            }
            catch
            {
                MessageBox.Show("Số điện thoại hoặc CCCD hoặc Email không phù hợp!!!");
            }
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    int i = LoadPatientDAO.Instance.DeletePatient(txtIDPatient.Text);
        //    Const.Instance.show("Xóa khách hàng", i);
        //    if (i > 0) LoadListPatient();
        //}

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            curlistPatient = LoadPatientDAO.Instance.searchPatient(txtFind.Text);
            countPatient = LoadPatientDAO.Instance.countSearch(txtFind.Text);
            countPage = countPatient % pageSize == 0 ? countPatient / pageSize : countPatient / pageSize + 1;
            curPage = 1;
            dtgvListPatient.DataSource = LoadPage();
        }
        void updateCur()
        {
            curlistPatient = LoadPatientDAO.Instance.LoadListPatient();
            countPatient = LoadPatientDAO.Instance.countPatient();
            countPage = countPatient % pageSize == 0 ? countPatient / pageSize : countPatient / pageSize + 1;
            curPage = 1;
            dtgvListPatient.DataSource = LoadPage();
        }
        private void btnIncre_Click(object sender, EventArgs e)
        {
            if (curPage == countPage) return;
            curPage++;
            LoadListPatient();
        }
        public DataTable LoadPage()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("SDT");
            dt.Columns.Add("rowindex");
            foreach (DataRow row in curlistPatient.Rows)
            {
                if (int.Parse((row[8].ToString())) < (curPage - 1) * pageSize + 1 ||
                    int.Parse((row[8].ToString())) > pageSize * curPage) continue;
                dt.ImportRow(row);
            }
            return dt;
        }
        private void btnDecre_Click(object sender, EventArgs e)
        {
            if (curPage == 1) return;
            curPage--;
            LoadListPatient();
        }

        private void txtIDPatient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

