using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            if(Const.Instance.type == 1 || Const.Instance.type == 2)
            {
                btnCreateAppointment.Enabled = false;
                btnCreateTreat.Enabled = false;
            }else
            {
                btnCreateAppointment.Enabled = true;
                btnCreateTreat.Enabled = true;
            }
            
            if (Const.Instance.type == 2) btnRequestCheck.Enabled = false;
            else { btnRequestCheck.Enabled = true; }
        }

        private void fManager_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            fEmployee f = new fEmployee();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDentist_Click(object sender, EventArgs e)
        {
            fDentist f = new fDentist();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            fMedicine f = new fMedicine();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            fPatient  f = new fPatient();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            fChoosePatientType f = new fChoosePatientType();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCreateTreat_Click(object sender, EventArgs e)
        {
            fChoosePatient f = new fChoosePatient(Const.comeCreateTreat);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnListAppointment_Click(object sender, EventArgs e)
        {
            fAppointment f = new fAppointment();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            this.Hide();
            f.ShowDialog();
            this.Show();    
        }

        private void btnRequestCheck_Click(object sender, EventArgs e)
        {
            fRequestCheck f = new fRequestCheck();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
