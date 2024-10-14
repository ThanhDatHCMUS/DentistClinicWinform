using System;
using System.CodeDom;
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
    public partial class fCreatePay : Form
    {
        public int receiveMoney;
        public string idPatient;
        public string note;
        public int type;
        public string name;
        public fCreatePay(string idPatient)
        {
            this.idPatient = idPatient;
            InitializeComponent();
            LoadDateNotPay();
            setTotalPrice();
        }
        void setTotalPrice()
        {
            textBox1.Text = CreatePayDAO.Instance.getNeedPay(idPatient).ToString();
        }
        void LoadDateNotPay()
        {
            dtgvListNotPayDay.DataSource = CreatePayDAO.Instance.LoadNeedPayDay(idPatient);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fCreatePay_Load(object sender, EventArgs e)
        {

        }

        private void dtgvListNotPayDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListNotPayDay.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvListNotPayDay.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvListNotPayDay.Rows[rowId];
            dtgvMedicine.DataSource = CreatePayDAO.Instance.LoadNeedPayMedicine(idPatient, row.Cells[0].Value.ToString());
            dtgvTreat.DataSource = CreatePayDAO.Instance.LoadNeedPayTreat(idPatient, row.Cells[0].Value.ToString());
        }
        void GETVALUE(int money, string note, int type, string name)
        {
            this.receiveMoney = money;
            this.note = note;
            this.type = type;  
            this.name = name;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fReceiveMoney f = new fReceiveMoney();
            f.mydata = new fReceiveMoney.GETDATA(GETVALUE);
            f.ShowDialog();
            Payment p = new Payment(idPatient, note, type, name, 
                receiveMoney, int.Parse(textBox1.Text.ToString()));
            if (receiveMoney >= int.Parse(textBox1.Text))
            {
                int i = CreatePayDAO.Instance.insertPay(p);
                if (i > 0)
                {
                    MessageBox.Show("Thanh toán thành công");
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Thanh toán không thành công");
        }
    }
}
