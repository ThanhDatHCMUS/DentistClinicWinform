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
    public partial class fChoosePatientType : Form
    {
        public fChoosePatientType()
        {
            InitializeComponent();
        }

        private void btnOldPatient_Click(object sender, EventArgs e)
        {
            fChoosePatient f = new fChoosePatient(Const.comeCreateAppointment);
            this.Close();
            f.ShowDialog();
        }

        private void fChoosePatientType_Load(object sender, EventArgs e)
        {

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            fInputInfoPatient f = new fInputInfoPatient();
            this.Close();
            f.ShowDialog();
        }
    }
}
