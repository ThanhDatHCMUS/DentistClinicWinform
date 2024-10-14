using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;
using Winform_PhongKham.DTO;

namespace Winform_PhongKham
{
    public partial class fCreateTreat : Form
    {
        public string idPatient;
        public DataTable listChooseDirectory = new DataTable();
        public DataTable listChoosedDirectory = new DataTable();
        public DataTable listChooseTreat = new DataTable();
        public DataTable listChoosedTreat = new DataTable();
        public DataTable listChooseTooth = new DataTable();
        public Dictionary<string, List<object[]>> lTooth = new Dictionary<string, List<object[]>>();
        public fCreateTreat(string idPatient)
        {
            this.idPatient = idPatient;
            InitializeComponent();
            lbAnnounceChooseDate.Hide();
            this.listChoosedDirectory.Columns.Add("IDDanhMuc", typeof(string));
            this.listChoosedDirectory.Columns.Add("Tên danh mục", typeof(string));
        }
        private void fCreateTreat_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxNotChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNotChoose.Checked == true) comboChooseAssistant.Enabled = false;
            else comboChooseAssistant.Enabled = true;
        }

        private void dateTreat_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTreat_CloseUp(object sender, EventArgs e)
        {
            if (dateTreat.Value.Date < DateTime.Now.Date || 
                CreateTreatDAO.Instance.existsTreatPlan(this.idPatient, dateTreat.Value.ToShortDateString()) == 1)
            {
                lbAnnounceChooseDate.Show();
                enableAll(false);
            }
            else
            {
                enableAll(true);
                LoadDentistCanTreat(dateTreat.Value.ToShortDateString());
                lbAnnounceChooseDate.Hide();
            }   
        }
        void enableAll(bool b)
        {
            comboChooseDentist.Enabled = b;
            comboChooseAssistant.Enabled = b;
            comboChooseDirectory.Enabled = b;
            comboChoosedDirectory.Enabled = b;
            comboChoosedTreat.Enabled = b;
            comboChooseTreat.Enabled = b;
            btn1.Enabled = b;
            button2.Enabled = b;
            button3.Enabled = b;
            button4.Enabled = b;
            button5.Enabled = b;
            dtgvChooseTooth.Enabled = b;
        }
        void LoadDentistCanTreat(string date)
        {
            comboChooseDentist.ValueMember = "idNhaSi";
            comboChooseDentist.DisplayMember = "hoten";
            comboChooseDentist.DataSource = CreateTreatDAO.Instance.LoadDentistCanTreat(date);
        }

        void LoadDentistCanAssistant(string date, string idDentist)
        {
            comboChooseAssistant.ValueMember = "idNhaSi";
            comboChooseAssistant.DisplayMember = "hoten";
            comboChooseAssistant.DataSource = CreateTreatDAO.Instance.LoadDentistCanAssistant(date, idDentist);
        }
 

        private void comboChooseDentist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadDentistCanAssistant(dateTreat.Value.ToShortDateString(),
                comboChooseDentist.SelectedValue.ToString());

            comboChooseDirectory.ValueMember = "idDanhMuc";
            comboChooseDirectory.DisplayMember = "Tên danh mục";
            comboChoosedDirectory.ValueMember = "idDanhMuc";
            comboChoosedDirectory.DisplayMember = "Tên danh mục";

            if (this.listChoosedDirectory.Rows.Count > 0 ||
                this.listChooseDirectory.Rows.Count > 0) return;
            comboChooseDirectory.DataSource = CreateTreatDAO.Instance.LoadListDirectory();
            this.listChooseDirectory = (DataTable)comboChooseDirectory.DataSource;
        }

        private void comboChooseDirectory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChooseDirectory.SelectedIndex;
            this.listChoosedDirectory.ImportRow(this.listChooseDirectory.Rows[i]);
            this.listChooseDirectory.Rows.RemoveAt(i);

            comboChooseDirectory.DataSource = this.listChooseDirectory;
            comboChoosedDirectory.DataSource = this.listChoosedDirectory;
            dtgvChoosedDirectory.DataSource = this.listChoosedDirectory;
            dtgvChoosedDirectory.Columns["IDDanhMuc"].Visible = false;
        }

        private void comboChoosedDirectory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChoosedDirectory.SelectedIndex;
            this.listChooseDirectory.ImportRow(this.listChoosedDirectory.Rows[i]);
            this.listChoosedDirectory.Rows.RemoveAt(i);

            comboChooseDirectory.DataSource = this.listChooseDirectory;
            comboChoosedDirectory.DataSource = this.listChoosedDirectory;
            dtgvChoosedDirectory.DataSource = this.listChoosedDirectory;

        }

        private void comboChooseAssistant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        public bool move = true;
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = move;
            move = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listChoosedDirectory.Rows.Count == 0)
            {
                MessageBox.Show("Không có danh mục nào được chọn");
                return;
            }
            move = false;
            tabControl1.SelectTab(1);
            string query = "";
            foreach (DataRow row in this.listChoosedDirectory.Rows)
                query += query == "" ? row["IDDanhMuc"].ToString() : "," + row["IDDanhMuc"].ToString();
            

            comboChooseTreat.ValueMember = "IDDieuTri";
            comboChoosedTreat.DisplayMember = "Tên điều trị";
            comboChoosedTreat.ValueMember = "IDDieuTri";
            comboChooseTreat.DisplayMember = "Tên điều trị";

            listChoosedTreat = new DataTable();
            this.listChoosedTreat.Columns.Add("IDDieuTri", typeof(string));
            this.listChoosedTreat.Columns.Add("Tên điều trị", typeof(string));
            this.listChoosedTreat.Columns.Add("Đơn vị tính", typeof(string));
            comboChoosedTreat.DataSource = listChoosedTreat;

            dtgvChoosedTreat.DataSource = new DataTable();
            comboChooseTreat.DataSource = CreateTreatDAO.Instance.LoadListChooseTreat(query);
            this.listChooseTreat = (DataTable)comboChooseTreat.DataSource;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectTab(0);
        }

        private void comboChooseTreat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChooseTreat.SelectedIndex;
            this.listChoosedTreat.ImportRow(this.listChooseTreat.Rows[i]);
            this.listChooseTreat.Rows.RemoveAt(i);
            comboChooseTreat.DataSource = this.listChooseTreat;
            comboChoosedTreat.DataSource = this.listChoosedTreat;
            dtgvChoosedTreat.DataSource = this.listChoosedTreat;
            dtgvChoosedTreat.Columns["IDDieuTri"].Visible = false;
            dtgvChoosedTreat.Columns["Đơn vị tính"].Visible = false;
        }

        private void comboChoosedTreat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChoosedTreat.SelectedIndex;
            this.listChooseTreat.ImportRow(this.listChoosedTreat.Rows[i]);
            this.listChoosedTreat.Rows.RemoveAt(i);
            comboChooseTreat.DataSource = this.listChooseTreat;
            comboChoosedTreat.DataSource = this.listChoosedTreat;
            dtgvChoosedTreat.DataSource = this.listChoosedTreat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listChoosedTreat.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn điều trị");
                return;
            }


            listChooseTooth = new DataTable();
            this.listChooseTooth.Columns.Add("IDDieuTri", typeof(string));
            this.listChooseTooth.Columns.Add("Tên điều trị", typeof(string));
            this.listChooseTooth.Columns.Add("Đơn vị tính", typeof(string));


            for (int i = 0; i < listChoosedTreat.Rows.Count; i ++)
            {
                if (listChoosedTreat.Rows[i][2].ToString() == "lần") continue;
                listChooseTooth.ImportRow(listChoosedTreat.Rows[i]);
            }

            if(listChooseTooth.Rows.Count == 0)
            {
                MessageBox.Show("Chọn điều trị hoàn tất");
                InsertTreatPlan();
                this.Close();
            }

            move = false;
            tabControl1.SelectTab(2);

            dtgvChooseTooth.DataSource = listChooseTooth;
            dtgvChooseTooth.Columns["Đơn vị tính"].Visible = false;
            dtgvChooseTooth.Columns["IDDieuTri"].Visible = false;
            dtgvChooseTooth.AutoGenerateColumns = false;
            if (dtgvChooseTooth.Columns.Count == 4) return;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Chọn răng";
            btn.Name = "btn";
            btn.HeaderText = "Chọn răng";
            btn.UseColumnTextForButtonValue = true;
            dtgvChooseTooth.Columns.Add(btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectTab(1);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            List<string> lIdTreat = new List<string>();
            foreach (DataRow row in listChooseTooth.Rows)
            {
                string idTreat = row[0].ToString();
                if (!lTooth.ContainsKey(idTreat))
                    lIdTreat.Add(row[1].ToString());
                
            }
            
            if(lIdTreat.Count == 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn tạo kế hoạch điều trị?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    InsertTreatPlan();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(lIdTreat.Count.ToString() + " điều trị chưa được chọn răng: \n" + string.Join("\n", lIdTreat));
            }
        }

        private void dtgvChooseTooth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex, colId = e.ColumnIndex;
            if (colId == 1) return;
            if (rowId < 0) return;
            if (rowId > dtgvChooseTooth.RowCount - 2) return;
            DataGridViewRow row = dtgvChooseTooth.Rows[rowId];
            List<object[]> l = new List<object[]>();
            string idTreat = row.Cells[0].Value.ToString();
            
            if (lTooth.ContainsKey(idTreat)) l = lTooth[idTreat];
            fAddTooth f = new fAddTooth(idTreat, l, row.Cells[1].Value.ToString());
            f.mydata = new fAddTooth.GETDATA(GETVALUE);
            f.ShowDialog();
        }
        public void GETVALUE(string idTreat, List<object[]> l)
        {
            lTooth[idTreat] = l;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            
        }
        void InsertTreatPlan()
        {
            //insert dicectory
            string sDirectory = "";
            foreach(DataRow row in this.listChoosedDirectory.Rows)
            {
                if (sDirectory == "") sDirectory += row["idDanhMuc"].ToString();
                else sDirectory += "-" + row["IdDanhMuc"].ToString();
            }
            // insert treat and tooth
            string sTreat = "";
            string sTooth = "";
            foreach (DataRow row in this.listChoosedTreat.Rows)
            {
                string idTreat = row["idDieuTri"].ToString();
                if (sTreat == "") sTreat += idTreat;
                else sTreat += "-" + idTreat;

                if (!this.lTooth.ContainsKey(idTreat)) continue;
                for(int i = 0; i < lTooth[idTreat].Count; i++)
                {
                    string temp = "";
                    int add = 0;
                    if (sTooth != "") temp = "-" + idTreat;
                    else temp = idTreat;

                    if (lTooth[idTreat][i][0].ToString() == "Hàm trên trái") add = 50;
                    if (lTooth[idTreat][i][0].ToString() == "Hàm trên phải") add = 60;
                    if (lTooth[idTreat][i][0].ToString() == "Hàm dưới trái") add = 70;
                    if (lTooth[idTreat][i][0].ToString() == "Hàm dưới phải") add = 80;
                    add += int.Parse(lTooth[idTreat][i][1].ToString());
                    temp += ',' + add.ToString();
                    temp += ',' + lTooth[idTreat][i][2].ToString();
                    sTooth += temp;
                }
            }
            string idAssistant;
            if (checkBoxNotChoose.Checked == true || comboChooseAssistant.SelectedItem == null) 
                idAssistant = null;
            else idAssistant = comboChooseAssistant.SelectedValue.ToString();
            TreatPlan treatPlan = new TreatPlan
                (
                    idPatient, comboChooseDentist.SelectedValue.ToString(), idAssistant, txtNote.Text.ToString(),
                    dateTreat.Value.ToShortDateString(), sDirectory, sTreat, sTooth
                );
            int check = CreateTreatDAO.Instance.insertTreatPlanPatient(treatPlan);
            Const.Instance.show("Thêm kế hoạch điều trị", check);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboChooseDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
