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
    public partial class fDentist : Form
    {
        public DataTable curlistDentist = new DataTable();
        public int curPage = 1;
        public static int pageSize = 10;
        public int countDentist = LoadDentistDAO.Instance.countDentist();
        int countPage;
        public fDentist()
        {
            InitializeComponent();
            LoadGender();
            LoadListChiNhanh();
            curlistDentist = LoadDentistDAO.Instance.LoadListDentist();
            LoadListDentist();
            countPage = countDentist % pageSize == 0 ? countDentist / pageSize : countDentist / pageSize + 1;
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
            dtgvListDentist.Columns["rowindex"].Visible = false;
            //dtgvListDentist.Columns["ChiNhanh"].Visible = false;
        }
        void LoadListDentist()
        {
            dtgvListDentist.DataSource = LoadPage();
        }
        void updateCur()
        {
            curlistDentist = LoadDentistDAO.Instance.LoadListDentist();
            countDentist = LoadDentistDAO.Instance.countDentist();
            countPage = countDentist % pageSize == 0 ? countDentist / pageSize : countDentist / pageSize + 1;
            curPage = 1;
            dtgvListDentist.DataSource = LoadPage();
        }
        public DataTable LoadPage()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nha sĩ");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Email");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Chi Nhánh");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("rowindex");
            foreach (DataRow row in curlistDentist.Rows)
            {
                if (int.Parse((row[11].ToString())) < (curPage - 1) * pageSize + 1 ||
                    int.Parse((row[11].ToString())) > pageSize * curPage) continue;
                dt.ImportRow(row);
            }
            return dt;
        }
        void LoadGender()
        {
            comboGender.Items.Add("Nam");
            comboGender.Items.Add("Nữ");
        }
        void LoadListChiNhanh()
        {
            DataTable dt = LoadDentistDAO.Instance.LoadListChiNhanh();
            comboBranch.DisplayMember = "DiaChi";
            comboBranch.ValueMember = "IDChiNhanh";
            comboBranch.DataSource = dt;
        }
        private void fDentist_Load(object sender, EventArgs e)
        {

        }
        private void dtgvListDentist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListDentist.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvListDentist.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvListDentist.Rows[rowId];
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtIDDentist.Text = row.Cells[0].Value.ToString();
            txtAddress.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
            txtID.Text = row.Cells[6].Value.ToString();
            txtPhoneNumber.Text = row.Cells[7].Value.ToString();
            comboGender.Text = row.Cells[2].Value.ToString();
            dateDateOfBirth.Text = row.Cells[3].Value.ToString();
            comboBranch.Text = row.Cells[8].Value.ToString();
            comboType.Text = row.Cells[9].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dateDateOfBirth.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không phù hợp");
                return;
            }
            Dentist h = new Dentist
                (txtFullName.Text, txtID.Text, comboGender.Text, txtAddress.Text,
                txtPhoneNumber.Text, dateDateOfBirth.Text, txtEmail.Text,
                txtIDDentist.Text, comboType.Text.ToString() ,comboBranch.SelectedValue.ToString());
            try
            {
                int i = LoadDentistDAO.Instance.InsertDentist(h);
                Const.Instance.show("Thêm nha sĩ", i);
                if (i > 0)
                {
                    updateCur();
                    LoadListDentist();
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
            Dentist h = new Dentist
                (txtFullName.Text, txtID.Text, comboGender.Text, txtAddress.Text,
                txtPhoneNumber.Text, dateDateOfBirth.Text, txtEmail.Text,
                txtIDDentist.Text, comboType.Text.ToString(), comboBranch.SelectedValue.ToString());
            try
            {
                int i = LoadDentistDAO.Instance.UpdateDentist(h);
                Const.Instance.show("Cập nhật nha sĩ", i);
                if (i > 0)
                {
                    updateCur();
                    LoadListDentist();
                }
            }
            catch
            {
                MessageBox.Show("Số điện thoại hoặc CCCD hoặc Email không phù hợp!!!");
            }
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    int i = LoadDentistDAO.Instance.DeleteDentist(txtIDDentist.Text);
        //    Const.Instance.show("Xóa nha sĩ", i);
        //    if (i > 0) LoadListDentist();
        //}

        private void btnFind_Click(object sender, EventArgs e)
        {
            curlistDentist = LoadDentistDAO.Instance.searchDentist(txtFind.Text);
            countDentist = LoadDentistDAO.Instance.countSearchDentist(txtFind.Text);
            countPage = countDentist % pageSize == 0 ? countDentist / pageSize : countDentist / pageSize + 1;
            curPage = 1;
            dtgvListDentist.DataSource = LoadPage();
        }
        private void btnWorkSchdule_Click(object sender, EventArgs e)
        {
            if (LoadDentistDAO.Instance.existDentist(txtIDDentist.Text) == 0)
            {
                MessageBox.Show("Không có nha sĩ");
                return;
            }
            fUpdateWorkSchedule f = new fUpdateWorkSchedule(txtIDDentist.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDecre_Click(object sender, EventArgs e)
        {
            if (curPage == 1) return;
            curPage--;
            LoadListDentist();
        }

        private void btnIncre_Click(object sender, EventArgs e)
        {
            if (curPage == countPage) return;
            curPage++;
            LoadListDentist();
        }
    }
}
