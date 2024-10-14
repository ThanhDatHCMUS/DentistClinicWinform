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
    public partial class fAppointment : Form
    {
        public string idPatient = "";
        public DataTable curlistCheck = new DataTable();
        public int curPage = 1;
        public static int pageSize = 20;
        public int countCheck = LoadAppointmentDAO.Instance.countAppointment(DateTime.Now.Date.ToShortDateString());
        int countPage;
        public fAppointment()
        {
            InitializeComponent();
            countPage = countCheck % pageSize == 0 ? countCheck / pageSize : countCheck / pageSize + 1;
            LoadBranch();
            curlistCheck = LoadAppointmentDAO.Instance.LoadAppointment(date.Value.ToShortDateString());
            LoadCheck();
            if (Const.Instance.type == 2) btnDentist.Show();
            else btnDentist.Hide();
            if(Const.Instance.type == 3)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            dtgvCheck.Columns["IDKhachHang"].Visible = false;
            dtgvCheck.Columns["rowindex"].Visible = false;
        }
        void LoadBranch()
        {
            comboBranch.DisplayMember = "DiaChi";
            comboBranch.ValueMember = "IDCHiNhanh";
            comboBranch.DataSource = LoadAppointmentDAO.Instance.LoadListBranch();
        }
        public DataTable LoadPage()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Bệnh nhân");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Nha sĩ");
            dt.Columns.Add("Số phòng");
            dt.Columns.Add("Tình trạng");
            dt.Columns.Add("IDKhachHang");
            dt.Columns.Add("rowindex");
            foreach (DataRow row in curlistCheck.Rows)
            {
                if (int.Parse((row[6].ToString())) < (curPage - 1) * pageSize + 1 ||
                    int.Parse((row[6].ToString())) > pageSize * curPage) continue;
                dt.ImportRow(row);
            }
            return dt;
        }
        void LoadCheck()
        {
            dtgvCheck.DataSource = LoadPage();
        }
        private void fAppointment_Load(object sender, EventArgs e)
        {

        }

        private void date_CloseUp(object sender, EventArgs e)
        {
            curlistCheck = LoadAppointmentDAO.Instance.LoadAppointment(date.Value.ToShortDateString());
            countCheck = LoadAppointmentDAO.Instance.countAppointment(date.Value.ToShortDateString());
            countPage = countCheck % pageSize == 0 ? countCheck / pageSize : countCheck / pageSize + 1;
            curPage = 1;
            LoadCheck();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            curlistCheck = LoadAppointmentDAO.Instance.LoadAppointmentPatient(date.Value.ToShortDateString(), txtPatient.Text);
            countCheck = LoadAppointmentDAO.Instance.countAppoinmentPatient(date.Value.ToShortDateString(), txtPatient.Text);
            countPage = countCheck % pageSize == 0 ? countCheck / pageSize : countCheck / pageSize + 1;
            curPage = 1;
            LoadCheck();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            curlistCheck = LoadAppointmentDAO.Instance.LoadAppointmentBranch
                (date.Value.ToShortDateString(), comboBranch.SelectedValue.ToString());
            countCheck = LoadAppointmentDAO.Instance.countAppoinmentBranch
                (date.Value.ToShortDateString(), comboBranch.SelectedValue.ToString());
            countPage = countCheck % pageSize == 0 ? countCheck / pageSize : countCheck / pageSize + 1;
            curPage = 1;
            LoadCheck();
        }

        private void btnDentist_Click(object sender, EventArgs e)
        {
            curlistCheck = LoadAppointmentDAO.Instance.LoadAppointmentDentist
                (date.Value.ToShortDateString(), Const.Instance.idDentist);
            countCheck = LoadAppointmentDAO.Instance.countAppointmentDentist
                (date.Value.ToShortDateString(), Const.Instance.idDentist);
            countPage = countCheck % pageSize == 0 ? countCheck / pageSize : countCheck / pageSize + 1;
            curPage = 1;
            LoadCheck();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if((DateTime)date.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Cuộc hẹn đã kết thúc");
                return;
            }
            if (string.IsNullOrEmpty(idPatient))
            {
                MessageBox.Show("Chọn buổi hẹn để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa buổi hẹn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                int i = LoadAppointmentDAO.Instance.deleteAppointment
                    (idPatient, date.Value.ToShortDateString());
                Const.Instance.show("Xóa cuộc hẹn", i);
                if(i > 0)
                {
                    curlistCheck = LoadAppointmentDAO.Instance.LoadAppointment(date.Value.ToShortDateString());
                    countCheck = LoadAppointmentDAO.Instance.countAppointment(date.Value.ToShortDateString());
                    countPage = countCheck % pageSize == 0 ? countCheck / pageSize : countCheck / pageSize + 1;
                    curPage = 1;
                    LoadCheck();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((DateTime)date.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Cuộc hẹn đã kết thúc");
                return;
            }
            if (string.IsNullOrEmpty(idPatient))
            {
                MessageBox.Show("Chọn buổi hẹn để cập nhật");
                return;
            }
            fUpdateAppointment f = new fUpdateAppointment(idPatient, date.Value.ToShortDateString());
            this.Hide();
            f.ShowDialog();
            this.Show();
            dtgvCheck.DataSource = LoadAppointmentDAO.Instance.LoadAppointment(date.Value.ToShortDateString());
        }

        private void dtgvCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvCheck.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvCheck.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvCheck.Rows[rowId];
            idPatient = row.Cells[5].Value.ToString();
        }

        private void btnDecre_Click(object sender, EventArgs e)
        {
            if (curPage == 1) return;
            curPage--;
            LoadCheck();
        }

        private void btnIncre_Click(object sender, EventArgs e)
        {
            if (curPage == countPage) return;
            curPage++;
            LoadCheck();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
