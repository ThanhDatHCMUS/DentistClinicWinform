using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham
{
    public partial class fCreateAppointment : Form
    {
        public int part = -1;
        public string idPatient;
        public fCreateAppointment(string idPatient)
        {
            this.idPatient = idPatient;
            InitializeComponent();
            rdBtnFirstCheck.Checked = true;
            LoadHistoryAppointment();
            LoadBranch();
        }

        void showDateNotFirstCheck(bool b)
        {
            comboDatePreCheck.Enabled = b;
            lbDateCheck.Enabled = b;
        }
        void LoadBranch()
        {
            comboBranch.DisplayMember = "DiaChi";
            comboBranch.ValueMember = "IDChiNhanh";
            comboBranch.DataSource = CreateAppointmentDAO.Instance.LoadListBranch();
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
            comboDatePreCheck.DataSource = CreateAppointmentDAO.Instance.LoadHistoryAppointment(this.idPatient);
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
            lbAnnounceChooseDate.Hide();
            if (rdBtnNotFirstCheck.Checked == true && comboDatePreCheck.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn ngày tái khám");
                return;
            }
            move = false;
            tabControl1.SelectedIndex = 1;

            if(rdBtnNotFirstCheck.Checked == true)
            {
                label4.Text = ""; //"**Thời gian gần nhất của nha sĩ mặc định: " + CreateAppointmentDAO.Instance.getNearestTime(idPatient, comboDatePreCheck.ValueMember);
            }
            else
            {
                label4.Text = "";//"**Thời gian gần nhất của nha sĩ mặc định: Không có";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            

            if (comboPartOfDay.SelectedItem == null || dateTimePicker1.Value == null || comboBranch.SelectedItem == null)
            {
                MessageBox.Show("Chọn đầy đủ: ngày, thời gian, địa điểm");
                return;
            }
            if (dateTimePicker1.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Ngày hẹn không được là hôm nay");
                return;
            }
            move = false;
            tabControl1.SelectedIndex = 2;

            comboDentist.DisplayMember = "Hoten";
            comboDentist.ValueMember = "IDNhaSi";
            comboDentist.DataSource = CreateAppointmentDAO.Instance.LoadDentistCanCheck
                (dateTimePicker1.Value.ToShortDateString(), (comboPartOfDay.SelectedIndex + 1).ToString(), comboBranch.SelectedValue.ToString());
            comboTime.DataSource = null;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectedIndex = 0;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date <= DateTime.Now.Date ||
                CreateAppointmentDAO.Instance.existCheck(idPatient, dateTimePicker1.Value.ToShortDateString()) == 1)
            {
                lbAnnounceChooseDate.Show();
                enableAll(false);
                return;
            }
            enableAll(true);
            lbAnnounceChooseDate.Hide();
        }
        void enableAll(bool b)
        {
            comboDentist.Enabled = b;
            comboTime.Enabled = b;  
            btn3.Enabled = b;
        }

        private void comboPartOfDay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectedIndex = 1;
        }

        private void comboDentist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboDentist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboTime.DisplayMember = "ThoiGian";
            comboTime.ValueMember = "stt";
            comboTime.DataSource = CreateAppointmentDAO.Instance.LoadTimeCanCheck
                ((comboPartOfDay.SelectedIndex + 1).ToString(), comboDentist.SelectedValue.ToString(), 
                dateTimePicker1.Value.ToShortDateString());
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
            Appointment a = new Appointment(idPatient, dateTimePicker1.Value.ToShortDateString(),
                comboDentist.SelectedValue.ToString(), datePreCheck, comboTime.SelectedValue.ToString());
            int i = CreateAppointmentDAO.Instance.insertAppoinment(a);
            Const.Instance.show("Thêm cuộc hẹn", i);
            if (i == 1) this.Close();
        }
    }
}
