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
    public partial class fHistoryMedicineApp : Form
    {
        public string idPatient;
        public fHistoryMedicineApp(string idPatient)
        {
            InitializeComponent();
            this.idPatient = idPatient;
            LoadDateApp();
            LoadAddUnitMedicine();
            LoadUpdateUnitMedicine();
        }
        void LoadDateApp()
        {
            comboDateApp.ValueMember = "NgayHen";
            comboDateApp.DisplayMember = "NgayHen";
            comboDateApp.DataSource = HistoryMedicineAppDAO.Instance.LoadDateApp(this.idPatient);
        }
        void LoadInfoApp()
        {
            LoadMedicineApp();
            LoadAddMedicine();
            LoadUpdateMedicine();
        }
        void LoadMedicineApp()
        {
            dtgvMeidcine.DataSource = HistoryMedicineAppDAO.Instance.LoadListMedicineApp(this.idPatient, comboDateApp.Text);
            dtgvMeidcine.Columns["Mã thuốc"].Visible = false;
        }
        private void fHistoryMedicineApp_Load(object sender, EventArgs e)
        {

        }
        void LoadAddUnitMedicine()
        {
            object c = comboAddMedicine.SelectedValue;
            if (c != null)
            {
                txtAddUnit.Text = HistoryMedicineAppDAO.Instance.getUnit(c.ToString());
            }
            else txtAddUnit.Text = "";
        }
        void LoadUpdateUnitMedicine()
        {
            object c = comboUpdateMedicine.SelectedValue;
            if (c != null)
            {
                txtUnitUpdate.Text = HistoryMedicineAppDAO.Instance.getUnit(c.ToString());
            }
            else txtUnitUpdate.Text = "";
        }
        void LoadAddMedicine()
        {
            comboAddMedicine.ValueMember = "IDThuoc";
            comboAddMedicine.DisplayMember = "TenThuoc";
            comboAddMedicine.DataSource = HistoryMedicineAppDAO.Instance.LoadAddMedicine
                (this.idPatient, comboDateApp.Text);
        }
        void LoadUpdateMedicine()
        {
            comboUpdateMedicine.ValueMember = "Mã thuốc";
            comboUpdateMedicine.DisplayMember = "Tên thuốc";
            comboUpdateMedicine.DataSource = HistoryMedicineAppDAO.Instance.LoadListMedicineApp
                (this.idPatient, comboDateApp.Text);
        }

        private void comboDateApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInfoApp();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboAddMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            TreatMedicine t = new TreatMedicine
                (comboAddMedicine.SelectedValue.ToString(),
                comboDateApp.Text, this.idPatient,
                (int)numericAddMedicine.Value);
            int i = HistoryMedicineAppDAO.Instance.AddMedicineApp(t);
            Const.Instance.show("Thêm thuốc", i);
            if (i > 0)
            {
                LoadInfoApp();
                LoadAddUnitMedicine();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboUpdateMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            TreatMedicine t = new TreatMedicine
                (comboUpdateMedicine.SelectedValue.ToString(),
                comboDateApp.Text, this.idPatient,
                (int)numericUpdateMedicine.Value);
            int i = HistoryMedicineAppDAO.Instance.UpdateMedicineApp(t);
            Const.Instance.show("Cập nhật thuốc", i);
            if (i > 0)
            {
                LoadInfoApp();
                LoadUpdateUnitMedicine();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboUpdateMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            TreatMedicine t = new TreatMedicine
                (comboUpdateMedicine.SelectedValue.ToString(),
                comboDateApp.Text,
                this.idPatient);
            int i = HistoryMedicineAppDAO.Instance.DeleteMedicineApp(t);
            Const.Instance.show("Xóa thuốc", i);
            if (i > 0)
            {
                LoadInfoApp();
                LoadUpdateUnitMedicine();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (comboUpdateMedicine.SelectedValue == null)
            {
                MessageBox.Show("Không có thuốc");
                return;
            }
            int i = HistoryMedicineAppDAO.Instance.DeleteAllMedicineApp
                (this.idPatient, comboDateApp.Text);
            Const.Instance.show("Xóa thuốc", i);
            if (i > 0)
            {
                LoadInfoApp();
                LoadUpdateUnitMedicine();
            }
        }
    }
}
