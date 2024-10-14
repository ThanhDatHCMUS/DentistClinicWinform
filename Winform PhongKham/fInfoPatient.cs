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
    public partial class fInfoPatient : Form
    {
        public string idPatient;
        public fInfoPatient(string idPatient)
        {
            this.idPatient = idPatient;
            InitializeComponent();
            LoadInfoPatient();
            LoadListCCD();
            if(Const.Instance.type == 2)
            {
                txtAllergy.Enabled = true;
                txtAllergy.ReadOnly = false;
                txtHealth.Enabled = true;
                txtHealth.ReadOnly = false;
                btnHistoryPay.Enabled = true;
                btnUpdateAllergy.Enabled = true;
                btnUpdateHealth.Enabled = true;
            }
            else
            {
                btnUpdateAllergy.Enabled=false;
                btnUpdateHealth.Enabled=false;
                txtAllergy.Enabled = false;
                txtAllergy.ReadOnly = true;
                txtHealth.Enabled = false;
                txtHealth.ReadOnly = true;
                btnHistoryPay.Enabled = false;
            }
            if(Const.Instance.type == 1)
            {
                btnTreatPlan.Enabled = false;
            }
            else
            {
                btnTreatPlan.Enabled= true;
            }
            if(Const.Instance.type == 3) 
            {
                btnAddPay.Enabled = true;
                btnAddTreat.Enabled = true;
                btnCreateAppoiment.Enabled = true;
            }
            else
            {
                btnAddPay.Enabled= false;
                btnAddTreat.Enabled = false;
                btnCreateAppoiment.Enabled = false;
            }
            
        }

        private void fInfoPatient_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadListCCD()
        {
            DataTable dt  = LoadInfoPatientDAO.Instance.LoadListCCD(this.idPatient);
            DataTable add = LoadInfoPatientDAO.Instance.LoadListAddCCD(this.idPatient);
            dtgvCCD.DataSource = dt;
            dtgvCCD.Columns["Mã thuốc"].Visible = false;
            comboAdd.ValueMember = "IDThuoc";
            comboAdd.DisplayMember = "TenThuoc";
            comboAdd.DataSource = add;
            comboDelete.ValueMember = "Mã thuốc";
            comboDelete.DisplayMember = "Tên thuốc";
            comboDelete.DataSource = dt;
            
        }
        public void LoadInfoPatient()
        {
            DataTable dt = LoadInfoPatientDAO.Instance.LoadInfoPatient(this.idPatient);
            int price = LoadInfoPatientDAO.Instance.getTotalPrice(this.idPatient);
            int pay = LoadInfoPatientDAO.Instance.getTotalPay(this.idPatient);
            DataRow row = dt.Rows[0];
            txtAddress.Text = row["diaChi"].ToString();
            txtAllergy.Text = row["diung"].ToString();
            txtEmail.Text = row["email"].ToString();
            txtFullName.Text = row["hoten"].ToString();
            txtHealth.Text = row["SucKhoeRang"].ToString();
            txtGender.Text = row["Gioitinh"].ToString();
            txtPhoneNumber.Text = row["SDT"].ToString();
            txtDateOfBirth.Text = ((DateTime)row["NgaySInh"]).ToShortDateString();
            txtTotalPrice.Text = price.ToString();
            txtTotalPay.Text = pay.ToString();
            txtID.Text = row["ID"].ToString();
        }

        private void btnUpdateHealth_Click(object sender, EventArgs e)
        {
            int i = LoadInfoPatientDAO.instance.updateHealthCondition(this.idPatient, txtHealth.Text);
            Const.Instance.show("Cập nhật sức khỏe răng", i);
        }

        private void btnUpdateAllergy_Click(object sender, EventArgs e)
        {
            int i = LoadInfoPatientDAO.instance.updateAllergy(this.idPatient, txtAllergy.Text);
            Const.Instance.show("Cập nhật dị ứng", i);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = LoadInfoPatientDAO.Instance.addCCD(this.idPatient, comboAdd.SelectedValue.ToString());
            Const.Instance.show("Thêm thuốc", i);
            if (i > 0) LoadListCCD();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = LoadInfoPatientDAO.Instance.deleteCCD(this.idPatient, comboDelete.SelectedValue.ToString());
            Const.Instance.show("Xóa thuốc", i);
            if (i > 0) LoadListCCD();
        }

        private void btnHistoryPrescription_Click(object sender, EventArgs e)
        {
            fChooseMedicineType f = new fChooseMedicineType(this.idPatient);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTreatPlan_Click(object sender, EventArgs e)
        {
            if(LoadInfoPatientDAO.Instance.existDateTreat(idPatient) == 1)
            {
                fChooseTreatPlan f = new fChooseTreatPlan(this.idPatient);
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Không có ngày điều trị");
            }
        }

        private void btnAddTreat_Click(object sender, EventArgs e)
        {
            fCreateTreat f = new fCreateTreat(this.idPatient);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHistoryPay_Click(object sender, EventArgs e)
        {
            fHistoryPay f = new fHistoryPay(this.idPatient);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAddPay_Click(object sender, EventArgs e)
        {
            if (HistoryMedicineDAO.Instance.existDayNotPay(idPatient) == 1)
            {
                fCreatePay f = new fCreatePay(this.idPatient);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không có buổi điều trị chưa thanh toán");
            }
        }

        private void btnCreateAppoiment_Click(object sender, EventArgs e)
        {
            fCreateAppointment f = new fCreateAppointment(this.idPatient);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
