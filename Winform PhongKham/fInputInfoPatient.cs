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
    public partial class fInputInfoPatient : Form
    {
        public fInputInfoPatient()
        {
            InitializeComponent();
        }

        private void fInputInfoPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không phù hợp");
                return;
            }
            Human h = new Human(txtFullName.Text.ToString(), txtID.Text.ToString(), comboBox1.Text.ToString(),
                txtAddress.Text.ToString(), txtPhoneNumber.Text.ToString(),
                dateTimePicker1.Value.ToShortDateString(), txtEmail.Text.ToString());
            try
            {
                int i = InputInfoPatientDAO.Instance.insertPatient(h);
                if(i == 0)
                {
                    MessageBox.Show("Tạo hồ sơ không thành công");
                    return;
                }
                string idPatient = InputInfoPatientDAO.Instance.getIDPatient(txtID.Text.ToString());
                fCreateAppointment f = new fCreateAppointment(idPatient);
                this.Close();
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Email hoặc Số điện thoại hoặc CCCD không phù hợp");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
