using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham
{
    public partial class fUpdateWorkSchedule : Form
    { 
        public string idDentist;
        public DataTable table;
        private List<List<Button>> matrix = new List<List<Button>>();
        public List<Tuple<int, int>> schedule = new List<Tuple<int, int>>();
        public List<Tuple<int, int>> newSchedule;
        public fUpdateWorkSchedule(string idDentist)
        {
            this.idDentist = idDentist;
            InitializeComponent();
            LWorkSchedule();
            setSchedule();
            setMatrixButton();
            if (Const.Instance.type == 1) btnUpdate.Enabled = true;
            else btnUpdate.Enabled = false;
        }
        void setMatrixButton()
        {
            Button oldBtn = new Button()
            {
                Width = Const.btnWidthUpdateSchedule,
                Height = Const.btnHeightUpdateSchedule,
                Location = new Point(-Const.btnWidthUpdateSchedule - Const.widthUpdateSchedule, 0)
            };
            for (int i = 0; i < 7; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Const.btnWidthUpdateSchedule,
                        Height = Const.btnHeightUpdateSchedule,
                        Location = new Point
                        (oldBtn.Location.X + oldBtn.Width + Const.widthUpdateSchedule, 
                        oldBtn.Location.Y),
                    };
                    btn.Click += Btn_Click;
                    
                    if (schedule != null && schedule.Contains(Tuple.Create(i, j))) btn.BackColor = Const.btnColor;
                    
                    pnlBtn.Controls.Add(btn);
                    
                    oldBtn.Location = btn.Location;
                    matrix[i].Add(btn);
                }
                oldBtn.Location = new Point
                    (-Const.btnWidthUpdateSchedule - Const.widthUpdateSchedule, 
                    oldBtn.Location.Y + oldBtn.Height + Const.heightUpdateSchedule);
            }
        }
        void LWorkSchedule()
        {
            table = UpdateWorkScheduleDAO.Instance.LoadListWorkSchedule(this.idDentist);
            dtgvWorkSchedule.DataSource = table;
            dtgvWorkSchedule.Columns["NgayTrongTuan"].Visible = false;
            dtgvWorkSchedule.Columns["ca"].Visible = false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (Const.Instance.type != 1) return;
            Button btn = sender as Button;
            btn.BackColor = btn.BackColor == Const.btnColor ? Color.White : Const.btnColor;
        }
        private void getSchedule()
        {
            UpdateWorkScheduleDAO.Instance.DeleteWorkSchedule(this.idDentist);
            for(int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j].BackColor == Const.btnColor)
                    UpdateWorkScheduleDAO.Instance.InsertWorkSchedule(idDentist,
                        (matrix[i][j].Location.Y / (Const.btnHeightUpdateSchedule + Const.heightUpdateSchedule) + 2).ToString(),
                        (matrix[i][j].Location.X / (Const.btnWidthUpdateSchedule + Const.widthUpdateSchedule) + 1).ToString());
                }
            }
        }
        private void setSchedule()
        {
            foreach (DataRow row in table.Rows)
            {
                foreach (string s in row["ca"].ToString().Split(','))
                {
                    schedule.Add(Tuple.Create((int)row["NgayTrongTuan"] - 2, int.Parse(s) - 1));
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fWorkSchedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getSchedule();
            LWorkSchedule();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
