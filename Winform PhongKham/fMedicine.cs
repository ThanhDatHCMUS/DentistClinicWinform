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
    public partial class fMedicine : Form
    {
        public DataTable curlistMedicine = new DataTable();
        public int curPage = 1;
        public static int pageSize = 20;
        public int countMedicine = LoadMedicineDAO.Instance.countMedicine();
        int countPage;
        public fMedicine()
        {
            InitializeComponent();
            curlistMedicine = LoadMedicineDAO.Instance.LoadListMedicine();
            LoadListMedicine();
            countPage = countMedicine % pageSize == 0 ? countMedicine / pageSize : countMedicine / pageSize + 1;
            if (Const.Instance.type == 1)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
            }
            dtgvListMedicine.Columns["rowindex"].Visible = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            int i = LoadMedicineDAO.Instance.ExistMedicine(txtIDMedicine.Text);
            if(i == 0)
            {
                MessageBox.Show("Chưa chọn thuốc");
                return;
            }
            fStockMedicine f = new fStockMedicine(txtIDMedicine.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fMedicine_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public DataTable LoadPage()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID thuốc");
            dt.Columns.Add("Tên thuốc");
            dt.Columns.Add("Đơn vị");
            dt.Columns.Add("Chống chỉ định");
            dt.Columns.Add("Giá");
            dt.Columns.Add("rowindex");
            foreach (DataRow row in curlistMedicine.Rows)
            {
                if (int.Parse((row[5].ToString())) < (curPage - 1) * pageSize + 1 ||
                    int.Parse((row[5].ToString())) > pageSize * curPage) continue;
                dt.ImportRow(row);
            }
            return dt;
        }

        private void LoadListMedicine()
        {
            dtgvListMedicine.DataSource = LoadPage();
        }
        private void dtgvListMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListMedicine.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvListMedicine.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvListMedicine.Rows[rowId];
            txtIDMedicine.Text = row.Cells[0].Value.ToString();
            txtMedicineName.Text = row.Cells[1].Value.ToString();
            txtUnit.Text = row.Cells[2].Value.ToString();
            txtCCD.Text = row.Cells[3].Value.ToString();
          
            numericPrice.Value = int.Parse(row.Cells[4].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Medicine h = new Medicine
                (txtIDMedicine.Text, txtMedicineName.Text, txtUnit.Text, txtCCD.Text, (int)numericPrice.Value);
            int i = LoadMedicineDAO.Instance.InsertMedicine(h);
            Const.Instance.show("Thêm thuốc", i);
            if (i > 0)
            {
                updateCur();
                LoadListMedicine();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Medicine h = new Medicine
                (txtIDMedicine.Text, txtMedicineName.Text, txtUnit.Text, txtCCD.Text, (int)numericPrice.Value);
            int i = LoadMedicineDAO.Instance.UpdateMedicine(h);
            Const.Instance.show("Cập nhật thuốc", i);
            if (i > 0)
            {
                updateCur();
                LoadListMedicine();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = LoadMedicineDAO.Instance.DeleteMedicine(txtIDMedicine.Text);
            Const.Instance.show("Xóa thuốc", i);
            if (i > 0) 
            {
                updateCur();
                LoadListMedicine();
            }
        }
        void updateCur()
        {
            curlistMedicine = LoadMedicineDAO.Instance.LoadListMedicine();
            countMedicine = LoadMedicineDAO.Instance.countMedicine();
            countPage = countMedicine % pageSize == 0 ? countMedicine / pageSize : countMedicine / pageSize + 1;
            curPage = 1;
            dtgvListMedicine.DataSource = LoadPage();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            curlistMedicine = LoadMedicineDAO.Instance.searchMedicine(txtFind.Text);
            countMedicine = LoadMedicineDAO.Instance.countSearchMedicine(txtFind.Text);
            countPage = countMedicine % pageSize == 0 ? countMedicine / pageSize : countMedicine / pageSize + 1;
            curPage = 1;
            dtgvListMedicine.DataSource = LoadPage();
        }

        private void btnDecre_Click(object sender, EventArgs e)
        {
            if (curPage == 1) return;
            curPage--;
            LoadListMedicine();
        }

        private void btnIncre_Click(object sender, EventArgs e)
        {
            if (curPage == countPage) return;
            curPage++;
            LoadListMedicine();
        }

        private void dtgvListMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
