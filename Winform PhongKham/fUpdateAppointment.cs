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
    public partial class fUpdateAppointment : Form
    {
        public string idPatient;
        public string date;
        public fUpdateAppointment(string idPatient, string date)
        {
            this.idPatient = idPatient;
            this.date = date;
            InitializeComponent();
            rdBtnFirstCheck.Checked = true;
            LoadHistoryAppointment();
            txtDate.Text = date;
            LoadBranch();
        }
        void LoadBranch()
        {
            comboBranch.DisplayMember = "DiaChi";
            comboBranch.ValueMember = "IDChiNhanh";
            comboBranch.DataSource = CreateAppointmentDAO.Instance.LoadListBranch();
        }
        private void fUpdateAppointment_Load(object sender, EventArgs e)
        {

        }
        void showDateNotFirstCheck(bool b)
        {
            comboDatePreCheck.Enabled = b;
            lbDateCheck.Enabled = b;
        }
        private void rdBtnNotFirstCheck_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdBtnNotFirstCheck.Checked == true)
            //{
            //    showDateNotFirstCheck(true);
            //}
            //else showDateNotFirstCheck(false);
        }

        private void rdBtnFirstCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnFirstCheck.Checked)
            {
                showDateNotFirstCheck(false);
            }
            else
            {
                showDateNotFirstCheck(true);
                LoadHistoryAppointment();
            }
        }

        private void fCreateAppointment_Load(object sender, EventArgs e)
        {

        }
        public bool move = true;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboDateCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadHistoryAppointment()
        {
            comboDatePreCheck.ValueMember = "NgayHen";
            comboDatePreCheck.DisplayMember = "NgayHen";
            comboDatePreCheck.DataSource = UpdateAppointmentDAO.Instance.LoadHistoryAppointment(this.idPatient);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = move;
            move = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (rdBtnNotFirstCheck.Checked == true && comboDatePreCheck.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn ngày tái khám");
                return;
            }
            move = false;
            tabControl1.SelectedIndex = 1;

            if (rdBtnNotFirstCheck.Checked == true)
            {

            }
            else
            {
                label4.Text = "**Thời gian gần nhất của nha sĩ mặc định: Không có";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {


            if (comboPartOfDay.SelectedItem == null || comboBranch.SelectedItem == null)
            {
                MessageBox.Show("Chọn lại thời gian, chi nhánh");
                return;
            }
            move = false;
            tabControl1.SelectedIndex = 2;

            comboDentist.DisplayMember = "Hoten";
            comboDentist.ValueMember = "IDNhaSi";
            //MessageBox.Show(txtDate.Text + ' ' + comboPartOfDay.SelectedIndex.ToString());
            comboDentist.DataSource = UpdateAppointmentDAO.Instance.LoadDentistCanCheck
                (txtDate.Text, (comboPartOfDay.SelectedIndex + 1).ToString(), comboBranch.SelectedValue.ToString());
            comboTime.DataSource = null;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectedIndex = 0;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectedIndex = 1;
        }


        private void comboDentist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboTime.DisplayMember = "ThoiGian";
            comboTime.ValueMember = "stt";
            comboTime.DataSource = UpdateAppointmentDAO.Instance.LoadTimeCanCheck
                ((comboPartOfDay.SelectedIndex + 1).ToString(), comboDentist.SelectedValue.ToString(),
                txtDate.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (comboTime.SelectedItem == null)
            {
                MessageBox.Show("Chọn lại thời gian");
                return;
            }
            string datePreCheck = null;
            if (!rdBtnFirstCheck.Checked && comboDatePreCheck.SelectedItem != null)
            {
                datePreCheck = comboDatePreCheck.SelectedValue.ToString();
            }
            Appointment a = new Appointment(idPatient, txtDate.Text,
                comboDentist.SelectedValue.ToString(), datePreCheck, comboTime.SelectedValue.ToString());
            int i = UpdateAppointmentDAO.Instance.updateAppoinment(a);
            Const.Instance.show("Thêm cuộc hẹn", i);
            if (i == 1) this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboPartOfDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

