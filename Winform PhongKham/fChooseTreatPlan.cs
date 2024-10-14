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
    public partial class fChooseTreatPlan : Form
    {
        public DataTable tb;
        public string idPatient;
        public fChooseTreatPlan(string idPatient)
        {
            this.idPatient = idPatient;
            InitializeComponent();
            setUp();
            
        }

        private void fChooseTreatPlan_Load(object sender, EventArgs e)
        {
            
        }
        void setUp()
        {
            tb = LoadDatePlanTreatDAO.Instance.LoadDateTreat(this.idPatient);
            

            int width = 175, height = 45;

            flowLayoutPanel1.BackColor = Color.AliceBlue;
            flowLayoutPanel1.AutoScroll = true;
            for(int i = 0; i < tb.Rows.Count; i++)
            {
                Button b = new Button()
                {
                    Width = width,
                    Height = height
                };
                if ((int)tb.Rows[i][1] == 1) b.BackColor = Color.Yellow;
                else
                {
                    if ((DateTime)tb.Rows[i][0] < DateTime.Now.Date) b.BackColor = Color.Green;
                    else 
                    {
                        b.BackColor = Color.Blue;
                        b.ForeColor = Color.White;
                    }
                }
                b.Click += Btn_Click;
                b.Text = ((DateTime)tb.Rows[i][0]).ToShortDateString();
                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            bool isCancel = false;
            if (b.BackColor == Color.Yellow) isCancel = true;
            fShowTreatPlan f = new fShowTreatPlan(this.idPatient, b.Text, isCancel);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
