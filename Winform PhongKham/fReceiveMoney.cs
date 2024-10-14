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

namespace Winform_PhongKham
{
    public partial class fReceiveMoney : Form
    {
        public fReceiveMoney()
        {
            InitializeComponent();
            txtNote.MaxLength = 200;
            radioCash.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public delegate void GETDATA(int money, string note, int type, string name);
        public GETDATA mydata;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (radioCash.Checked == true) i = 1;
            try
            {
                mydata(int.Parse(txtReceiveMoney.Text.ToString()), 
                    txtNote.Text.ToString(), i, txtName.Text.ToString());
                this.Close();
            }
            catch
            {
                MessageBox.Show("Nhập không đúng");
            }
        }

        private void fReceiveMoney_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
