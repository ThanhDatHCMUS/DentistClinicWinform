using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;

namespace Winform_PhongKham
{
    public partial class fShowTreatPlan : Form
    {
        public string idPatient;
        public string date;
        public fShowTreatPlan(string idPatient, string date, bool isCancel)
        {
            this.idPatient = idPatient;
            this.date = date;
            InitializeComponent();
            showInfo();
            if (DateTime.Parse(date) < DateTime.Now.Date || isCancel)
                btnCancel.Enabled = false;
            if (DateTime.Parse(date) < DateTime.Now.Date || 
                LoadInfoPlanTreatDAO.Instance.isPayed(idPatient, date) == 1)
                btnUpdate.Enabled = false;

        }
        void showInfo()
        {
            DataRow row = LoadInfoPlanTreatDAO.Instance.showInfo(idPatient, date).Rows[0];
            if (!string.IsNullOrEmpty(row["IDTroKham"].ToString()))
                txtAssistant.Text = row["TenTroKham"].ToString();
            txtDentist.Text = row["TenNhaSi"].ToString();
            txtNote.Text = row["GhiChu"].ToString();
            txtTreatDate.Text = ((DateTime)row["NgayDieuTri"]).ToShortDateString();


            dtgvDirectory.DataSource = LoadInfoPlanTreatDAO.Instance.showDirectoryPatient(idPatient, date);

            dtgvTreat.DataSource = LoadInfoPlanTreatDAO.Instance.showTreatPatient(idPatient, date);
            dtgvTreat.Columns["Giá"].Visible = false;

        }
        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowTreatPlan_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy kế hoạch điều trị?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i = LoadInfoPlanTreatDAO.Instance.cancelTreatPlan(idPatient, date);
                if (i == 0) MessageBox.Show("Hủy không thành công");
                else
                {
                    MessageBox.Show("Hủy thành công");
                    btnCancel.Enabled = false;
                }
            }
        }

        private void btnCancel_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fUpdateTreat f = new fUpdateTreat(this.idPatient, this.date);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
