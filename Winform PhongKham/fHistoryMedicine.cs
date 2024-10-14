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
    public partial class fHistoryMedicine : Form
    {
        int paid = 0;
        public string idPatient;
        public fHistoryMedicine(string idPateint)
        {
            this.idPatient = idPateint;
            InitializeComponent();
            LoadDateTreat();
            
        }
        void LoadInfoTreat()
        {
            LoadMedicineTreat();
            LoadAddMedicine();
            LoadUpdateMedicine();
        }
        void LoadDateTreat()
        {
            comboDateTreat.ValueMember = "NgayDieuTri";
            comboDateTreat.DisplayMember = "NgayDieuTri";
            comboDateTreat.DataSource = HistoryMedicineDAO.Instance.LoadDateTreat(this.idPatient);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        void LoadMedicineTreat()
        {
            dtgvMeidcine.DataSource = HistoryMedicineDAO.Instance.LoadListMedicineTreat(this.idPatient, comboDateTreat.Text);
            dtgvMeidcine.Columns["Mã thuốc"].Visible = false;
        }
        void LoadAddUnitMedicine()
        {
            object c = comboAddMedicine.SelectedValue;
            if (c != null)
            {
                txtAddUnit.Text = HistoryMedicineDAO.Instance.getUnit(c.ToString());
            }
            else txtAddUnit.Text = "";
        }
        void LoadUpdateUnitMedicine()
        {
            object c = comboUpdateMedicine.SelectedValue;
            if (c != null)
            {
                txtUnitUpdate.Text = HistoryMedicineDAO.Instance.getUnit(c.ToString());
            } else txtUnitUpdate.Text = "";
        }
        private void fHistoryMedicine_Load(object sender, EventArgs e)
        {

        }

        private void comboDateTreat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInfoTreat();
            this.paid = HistoryMedicineDAO.Instance.paidPlanTreat
                (this.idPatient, comboDateTreat.SelectedValue.ToString());
        }
        void LoadAddMedicine()
        {
            comboAddMedicine.ValueMember = "IDThuoc";
            comboAddMedicine.DisplayMember = "TenThuoc";
            comboAddMedicine.DataSource = HistoryMedicineDAO.Instance.LoadAddMedicine
                (this.idPatient, comboDateTreat.Text);
        }
        void LoadUpdateMedicine()
        {
            comboUpdateMedicine.ValueMember = "Mã thuốc";
            comboUpdateMedicine.DisplayMember = "Tên thuốc";
            comboUpdateMedicine.DataSource = HistoryMedicineDAO.Instance.LoadListMedicineTreat
                (this.idPatient, comboDateTreat.Text);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.paid == 1)
            {
                MessageBox.Show("Đơn thuốc đã được thanh toán");
                return;
            }
            if (comboAddMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            TreatMedicine t = new TreatMedicine
                (comboAddMedicine.SelectedValue.ToString(), 
                comboDateTreat.Text, this.idPatient,
                (int)numericAddMedicine.Value);
            int i = HistoryMedicineDAO.Instance.AddMedicineTreat(t);
            Const.Instance.show("Thêm thuốc", i);
            if (i > 0)
            {
                LoadInfoTreat();
                LoadAddUnitMedicine();
                HistoryMedicineDAO.Instance.setTotalMedicine(idPatient, comboDateTreat.Text);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.paid == 1)
            {
                MessageBox.Show("Đơn thuốc đã được thanh toán");
                return;
            }
            if (comboUpdateMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            TreatMedicine t = new TreatMedicine
                (comboUpdateMedicine.SelectedValue.ToString(), 
                comboDateTreat.Text, this.idPatient,
                (int)numericUpdateMedicine.Value);
            int i = HistoryMedicineDAO.Instance.UpdateMedicineTreat(t);
            Const.Instance.show("Cập nhật thuốc", i);
            if (i > 0)
            {
                LoadInfoTreat();
                LoadUpdateUnitMedicine();
                HistoryMedicineDAO.Instance.setTotalMedicine(idPatient, comboDateTreat.Text);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.paid == 1)
            {
                MessageBox.Show("Đơn thuốc đã được thanh toán");
                return;
            }
            if (comboUpdateMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            TreatMedicine t = new TreatMedicine
                (comboUpdateMedicine.SelectedValue.ToString(), 
                comboDateTreat.Text, 
                this.idPatient);
            int i = HistoryMedicineDAO.Instance.DeleteMedicineTreat(t);
            Const.Instance.show("Xóa thuốc", i);
            if (i > 0)
            {
                LoadInfoTreat();
                LoadUpdateUnitMedicine();
            }
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (this.paid == 1)
            {
                MessageBox.Show("Đơn thuốc đã được thanh toán");
                return;
            }
            if (comboUpdateMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            int i = HistoryMedicineDAO.Instance.DeleteAllMedicineTreat
                (this.idPatient, comboDateTreat.Text);
            Const.Instance.show("Xóa thuốc", i);
            if (i > 0)
            {
                LoadInfoTreat();
                LoadUpdateUnitMedicine();
                HistoryMedicineDAO.Instance.setTotalMedicine(idPatient, comboDateTreat.Text);
            }
        }

        private void comboAddMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAddUnitMedicine();
        }

        private void comboUpdateMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUpdateUnitMedicine();
        }

        private void dtgvMeidcine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
