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
    public partial class fDetailPay : Form
    {
        public string idPatient;
        public string orderNumber;
        public fDetailPay(string idPatient, string orderNumber)
        {
            this.idPatient = idPatient;
            this.orderNumber = orderNumber;
            InitializeComponent();
            LoadDayTreatPlan();
        }
        void LoadDayTreatPlan()
        {
            comboBox1.DisplayMember = "NgayDieuTri";
            comboBox1.ValueMember = "NgayDieuTri";
            comboBox1.DataSource = LoadDetailPayDAO.Instance.LoadDayPlanTreat(idPatient, orderNumber);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvTreat.DataSource = LoadDetailPayDAO.Instance.LoadNeedPayTreat(idPatient, comboBox1.SelectedValue.ToString());
            dtgvMedicine.DataSource = LoadDetailPayDAO.Instance.LoadNeedPayMedicine(idPatient, comboBox1.SelectedValue.ToString());
            txtDentist.Text = LoadDetailPayDAO.Instance.getDentistPlanTreat(idPatient, comboBox1.SelectedValue.ToString());
            txtNote.Text = LoadDetailPayDAO.Instance.getNotePlanTreat(idPatient, comboBox1.SelectedValue.ToString());
        }

        private void fDetailPay_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
