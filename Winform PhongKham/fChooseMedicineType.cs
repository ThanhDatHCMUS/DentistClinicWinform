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
    public partial class fChooseMedicineType : Form
    {
        string idPatient;
        public fChooseMedicineType(string idPatient)
        {
            this.idPatient = idPatient;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = LoadInfoPatientDAO.Instance.existDateTreat(idPatient);
            if(i == 0)
            {
                MessageBox.Show("Chưa có buổi điều trị");
                return;
            }
            fHistoryMedicine f = new fHistoryMedicine(idPatient);
            this.Close();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = LoadInfoPatientDAO.Instance.existAppointment(idPatient);
            if (i == 0)
            {
                MessageBox.Show("Chưa có buổi hẹn");
                return;
            }
            fHistoryMedicineApp f = new fHistoryMedicineApp(idPatient);
            this.Close();
            f.ShowDialog();
        }
    }
}
