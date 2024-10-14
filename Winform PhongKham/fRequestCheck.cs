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

namespace Winform_PhongKham
{
    public partial class fRequestCheck : Form
    {
        int id = -1;
        public fRequestCheck()
        {
            InitializeComponent();
            dtgvRequestCheck.DataSource = RequestCheckDAO.Instance.LoadRequestCheck();
            dtgvRequestCheck.Columns[5].Visible = false;
        }

        private void RequestCheck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(id == -1)
            {
                MessageBox.Show("Chọn yêu cầu hẹn để xóa");
                return;
            }
            RequestCheckDAO.Instance.deleteRequestCheck(id);
            dtgvRequestCheck.DataSource = RequestCheckDAO.Instance.LoadRequestCheck();
        }

        private void dtgvRequestCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvRequestCheck.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvRequestCheck.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvRequestCheck.Rows[rowId];
            id = (int)row.Cells[5].Value;
        }

        private void dtgvRequestCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
