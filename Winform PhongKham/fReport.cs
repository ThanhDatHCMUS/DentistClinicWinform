using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
            comboBox1.ValueMember = "IDNhaSi";
            comboBox1.DisplayMember = "Hoten";
            comboBox1.DataSource = ReportDAO.Instance.LoadDentist();
        }
        void showReport()
        {
            string idDentist = comboBox1.SelectedValue.ToString();
            int type = ReportDAO.Instance.getTypeDentist(idDentist);
            //if ((DateTime)dateTimePicker1.Value > (DateTime)dateTimePicker2.Value)
            //{
            //    MessageBox.Show("Ngày bắt đầu và kết thúc không phù hợp");
            //    return;
            //}
            if (type == 1) dataGridView1.DataSource = ReportDAO.Instance.showReportTreat
                    (idDentist, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            else dataGridView1.DataSource = ReportDAO.Instance.showReportCheck
                    (idDentist, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
        }
        private void fReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
