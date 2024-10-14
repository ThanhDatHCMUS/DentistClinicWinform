using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;

namespace Winform_PhongKham
{
    public partial class fHistoryPay : Form
    {
        public string idPatient;
        public int orderNumber = -1;
        public fHistoryPay(string idPatient)
        {
            this.idPatient = idPatient;
            InitializeComponent();
            LoadHistoryPay();
        }

        void LoadHistoryPay()
        {
            dtgvHistory.DataSource =  LoadHistoryPayDAO.Instance.LoadHistoryPay(idPatient);
            dtgvHistory.Columns["Ghi chú"].Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fHistoryPay_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHistory.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvHistory.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvHistory.Rows[rowId];
            txtDatePay.Text = ((DateTime)row.Cells[1].Value).ToShortDateString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtTotal.Text = row.Cells[3].Value.ToString();
            txtPay.Text = row.Cells[4].Value.ToString();
            txtReturn.Text = row.Cells[5].Value.ToString();
            txtType.Text = row.Cells[6].Value.ToString();
            txtNote.Text = row.Cells[7].Value.ToString();
            this.orderNumber = (int)row.Cells[0].Value;
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            if(this.orderNumber == -1)
            {
                MessageBox.Show("Chưa chọn thanh toán");
                return;
            }
            fDetailPay f = new fDetailPay(this.idPatient, this.orderNumber.ToString());
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
