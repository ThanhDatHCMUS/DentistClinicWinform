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
    public partial class fChoosePatient : Form
    {
        public DataTable curlistPatient = new DataTable();
        public int curPage = 1;
        public static int pageSize = 10;
        public int countPatient = LoadPatientDAO.Instance.countPatient();
        int countPage;
        public int comeFrom;
        public string idPatient;
        public fChoosePatient(int i)
        {
            comeFrom = i;
            InitializeComponent();
            curlistPatient = LoadPatientDAO.Instance.LoadListPatient();
            LoadListPatient();
            countPage = countPage = countPatient % pageSize == 0 ? countPatient / pageSize : countPatient / pageSize + 1;
            dtgvListPatient.Columns["rowindex"].Visible = false;
        }

        private void fChoosePatient_Load(object sender, EventArgs e)
        {

        }

        private void dtgvListPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadListPatient()
        {
            dtgvListPatient.DataSource = LoadPage();
            if (dtgvListPatient.Rows.Count < 2) return;
            this.idPatient = dtgvListPatient.Rows[0].Cells[0].Value.ToString();
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
        private void dtgvListPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListPatient.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvListPatient.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvListPatient.Rows[rowId];
            this.idPatient = row.Cells[0].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            curlistPatient = LoadPatientDAO.Instance.searchPatient(txtFind.Text);
            countPatient = LoadPatientDAO.Instance.countSearch(txtFind.Text);
            countPage = countPatient % pageSize == 0 ? countPatient / pageSize : countPatient / pageSize + 1;
            curPage = 1;
            dtgvListPatient.DataSource = LoadPage();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.idPatient);
            if(comeFrom == Const.comeCreateAppointment)
            {
                fCreateAppointment f = new fCreateAppointment(this.idPatient);
                this.Hide();
                this.Close();
                f.ShowDialog();
            }
            else
            {
                fCreateTreat f = new fCreateTreat(this.idPatient);
                this.Hide();
                this.Close();
                f.ShowDialog();
            }
        }

        private void btnDecre_Click(object sender, EventArgs e)
        {
            if (curPage == 1) return;
            curPage--;
            LoadListPatient();
        }

        private void btnIncre_Click(object sender, EventArgs e)
        {
            if (curPage == countPage) return;
            curPage++;
            LoadListPatient();
        }
    }
}
