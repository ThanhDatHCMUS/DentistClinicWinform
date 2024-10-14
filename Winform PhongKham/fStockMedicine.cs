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
    public partial class fStockMedicine : Form
    {
        public string idMedicine;
        public fStockMedicine(string idMedicine)
        {
            this.idMedicine = idMedicine;
            InitializeComponent();
            LoadInfoMedicine();
            LoadListStock();
            if (Const.Instance.type == 1)
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;  
            }
        }

        private void fStockMedicine_Load(object sender, EventArgs e)
        {

        }
        void LoadInfoMedicine()
        {
            DataTable dt = LoadInfoMedicineDAO.Instance.LoadInfoMedicine(this.idMedicine);
            DataRow row = dt.Rows[0];
            txtCCD.Text = row["ChongChiDinh"].ToString();
            txtMedicineName.Text = row["TenThuoc"].ToString();
            txtPrice.Text = row["Gia"].ToString();
            txtUnit.Text = row["DonViTinh"].ToString();
        }
        void LoadListStock()
        {
            dtgvStockMedicine.DataSource = LoadInfoMedicineDAO.Instance.LoadListStock(this.idMedicine);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockMedicine s = new StockMedicine
                (this.idMedicine, dateHSD.Text, txtStockUnit.Text, (int)numericStock.Value);
            int i = LoadInfoMedicineDAO.Instance.AddStockMedicine(s);
            Const.Instance.show("Thêm", i);
            if (i > 0) LoadListStock();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StockMedicine s = new StockMedicine
                (this.idMedicine, dateHSD.Text, txtStockUnit.Text, (int)numericStock.Value);
            int i = LoadInfoMedicineDAO.Instance.UpdateStockMedicine(s);
            Const.Instance.show("Cập nhật", i);
            if (i > 0) LoadListStock();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = LoadInfoMedicineDAO.Instance.DeleteStockMedicine(this.idMedicine, dateHSD.Text);
            Const.Instance.show("Xóa", i);
            if (i > 0) LoadListStock();
        }

        private void dtgvStockMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvStockMedicine.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvStockMedicine.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvStockMedicine.Rows[rowId];
            dateHSD.Text = row.Cells[0].Value.ToString();
            numericStock.Value = (int)row.Cells[1].Value;
            txtStockUnit.Text = row.Cells[2].Value.ToString();
        }
    }
}
