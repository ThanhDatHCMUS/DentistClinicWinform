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
    public partial class fUpdateTreat : Form
    {
        public string idPatient;
        public string date;
        public DataTable listChooseDirectory = new DataTable();
        public DataTable listChoosedDirectory = new DataTable();
        public DataTable listChooseTreat = new DataTable();
        public DataTable listChoosedTreat = new DataTable();
        public DataTable listChooseTooth = new DataTable();
        public Dictionary<string, List<object[]>> lTooth = new Dictionary<string, List<object[]>>();
        public fUpdateTreat(string idPatient, string date)
        {
            this.idPatient = idPatient;
            this.date = date;
            InitializeComponent();
            txtDate.Text = date;
            setDentist();
            setDirectory();
            setTooth();
        }
        string location(int l)
        {
            if (l == 5) return "Hàm trên trái";
            if (l == 6) return "Hàm trên phải";
            if (l == 7) return "Hàm dưới trái";
            return "Hàm dưới phải";
        }
        void setTooth()
        {
            DataTable temp = UpdateTreatDAO.Instance.LoadToothPatient(idPatient, date);
            foreach (DataRow row in temp.Rows)
            {
                if (!lTooth.ContainsKey(row[0].ToString()))
                    lTooth[row[0].ToString()] = new List<object[]>();
                lTooth[row[0].ToString()].Add(new object[] { location((int)row[1]), (int)row[2], row[3].ToString() });
            }
        }
        void setDentist()
        {
            comboChooseDentist.DisplayMember = "Hoten";
            comboChooseDentist.ValueMember = "IDNhaSi";
            comboChooseDentist.DataSource = UpdateTreatDAO.Instance.LoadDentistCanTreat(date);
            comboChooseDentist.Text = UpdateTreatDAO.Instance.getNameDentist(idPatient, date);
            //MessageBox.Show(UpdateTreatDAO.Instance.getNameDentist(idPatient, date));
            comboChooseAssistant.DisplayMember = "Hoten";
            comboChooseAssistant.ValueMember = "IDNhaSi";
            comboChooseAssistant.DataSource = UpdateTreatDAO.Instance.LoadDentistCanAssistant
                (date, comboChooseDentist.SelectedValue.ToString());
            string assistant = UpdateTreatDAO.Instance.getNameAssistant(idPatient, date);
            if(!string.IsNullOrEmpty(assistant)) comboChooseAssistant.Text = assistant;

        }
        void setDirectory()
        {
            listChooseDirectory = UpdateTreatDAO.Instance.LoadDirectoryExcept(idPatient, date);
            comboChooseDirectory.DisplayMember = "Tên danh mục";
            comboChooseDirectory.ValueMember = "IDDanhMuc";
            comboChooseDirectory.DataSource = listChooseDirectory;


            listChoosedDirectory = UpdateTreatDAO.Instance.LoadDirectoryPatient(idPatient, date);
            comboChoosedDirectory.DisplayMember = "Tên danh mục";
            comboChoosedDirectory.ValueMember = "IDDanhMuc";
            comboChoosedDirectory.DataSource = listChoosedDirectory;


            dtgvChoosedDirectory.DataSource = listChoosedDirectory;
            dtgvChoosedDirectory.Columns["IDDanhMuc"].Visible = false;
        }
        private void fUpdateTreat_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxNotChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNotChoose.Checked) comboChooseAssistant.Enabled = false;
            else comboChooseAssistant.Enabled = true;
        }

        private void comboChooseDirectory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChooseDirectory.SelectedIndex;
            this.listChoosedDirectory.ImportRow(listChooseDirectory.Rows[i]);
            this.listChooseDirectory.Rows.RemoveAt(i);

            comboChooseDirectory.DataSource = listChooseDirectory;
            comboChoosedDirectory.DataSource = listChoosedDirectory;
            dtgvChoosedDirectory.DataSource = listChoosedDirectory;
        }

        private void comboChooseDentist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboChooseAssistant.DataSource = UpdateTreatDAO.Instance.LoadDentistCanAssistant
                (date, comboChooseDentist.SelectedValue.ToString());
        }
        public bool move = true;
        private void comboChoosedDirectory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChoosedDirectory.SelectedIndex;
            this.listChooseDirectory.ImportRow(listChoosedDirectory.Rows[i]);
            this.listChoosedDirectory.Rows.RemoveAt(i);

            comboChooseDirectory.DataSource = listChooseDirectory;
            comboChoosedDirectory.DataSource = listChoosedDirectory;
            dtgvChoosedDirectory.DataSource = listChoosedDirectory;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = move;
            move = true;
        }

        private void btn1_Click(object sender, EventArgs e)
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

            this.listChooseTreat = CreateTreatDAO.Instance.LoadListChooseTreat(query);
            comboChooseTreat.DataSource = listChooseTreat;

            //dtgvChoosedTreat.DataSource = listChoosedTreat;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectedIndex = 0;
        }

        private void comboChooseTreat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChooseTreat.SelectedIndex;
            listChoosedTreat.ImportRow(listChooseTreat.Rows[i]);
            listChooseTreat.Rows.RemoveAt(i);

            comboChoosedTreat.DataSource = listChoosedTreat;
            comboChooseTreat.DataSource = listChooseTreat;
            dtgvChoosedTreat.DataSource = listChoosedTreat;

            dtgvChoosedTreat.Columns["Đơn vị tính"].Visible = false;
            dtgvChoosedTreat.Columns["IDDieuTri"].Visible = false;
        }

        private void comboChoosedTreat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = comboChoosedTreat.SelectedIndex;
            listChooseTreat.ImportRow(listChoosedTreat.Rows[i]);
            listChoosedTreat.Rows.RemoveAt(i);

            comboChoosedTreat.DataSource = listChoosedTreat;
            comboChooseTreat.DataSource = listChooseTreat;
            dtgvChoosedTreat.DataSource = listChoosedTreat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listChoosedTreat.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn điều trị");
                return;
            }


            listChooseTooth = new DataTable();
            this.listChooseTooth.Columns.Add("IDDieuTri", typeof(string));
            this.listChooseTooth.Columns.Add("Tên điều trị", typeof(string));
            this.listChooseTooth.Columns.Add("Đơn vị tính", typeof(string));


            for (int i = 0; i < listChoosedTreat.Rows.Count; i++)
            {
                if (listChoosedTreat.Rows[i][2].ToString() == "lần") continue;
                listChooseTooth.ImportRow(listChoosedTreat.Rows[i]);
            }

            if (listChooseTooth.Rows.Count == 0)
            {
                MessageBox.Show("Chọn điều trị hoàn tất");
                updateTreatPlan();
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

        void updateTreatPlan()
        {
            string sDirectory = "";
            foreach (DataRow row in this.listChoosedDirectory.Rows)
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
                for (int i = 0; i < lTooth[idTreat].Count; i++)
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
                    date, sDirectory, sTreat, sTooth
                );
            int check = CreateTreatDAO.Instance.updateTreatPlanPatient(treatPlan);
            Const.Instance.show("Cập nhật kế hoạch điều trị", check);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move = false;
            tabControl1.SelectedIndex = 1;
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

            if (lIdTreat.Count == 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn cập nhật kế hoạch điều trị?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    updateTreatPlan();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(lIdTreat.Count.ToString() + " điều trị chưa được chọn răng: \n" + string.Join("\n", lIdTreat));
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
