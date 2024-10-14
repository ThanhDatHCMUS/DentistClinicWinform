using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_PhongKham
{
    public partial class fAddTooth : Form
    {
        public List<object[]> lTooth;
        public string idTreat;
        public delegate void GETDATA(string idTreat, List<object[]> l);
        public GETDATA mydata;
        public fAddTooth(string idTreat, List<object[]> l, string name)
        {
            lTooth = l;
            this.idTreat = idTreat;
            InitializeComponent();
            ptbNumberTooth.ImageLocation = "https://th.bing.com/th/id/OIP.1Ju4Z4y2p408EOkoHr4tDgHaFf?w=264&h=195&c=7&r=0&o=5&dpr=1.3&pid=1.7";
            ptbNumberTooth.SizeMode = PictureBoxSizeMode.AutoSize;
            addItemLocationTooth();
            setListTooth();
            addItemSurface();
            label4.Text += name;
        }

        void addItemLocationTooth()
        {
            comboLocationTooth.Items.Add("Hàm trên trái");
            comboLocationTooth.Items.Add("Hàm trên phải");
            comboLocationTooth.Items.Add("Hàm dưới trái");
            comboLocationTooth.Items.Add("Hàm dưới phải");
        }
        void addItemSurface()
        {
            comboSurface.Items.Add("All - A");
            comboSurface.Items.Add("Lingual - L");
            comboSurface.Items.Add("Facial - F");
            comboSurface.Items.Add("Distal - D");
            comboSurface.Items.Add("Mesial - M");
            comboSurface.Items.Add("Top - T");
            comboSurface.Items.Add("Root - R");
        }
        void setListTooth()
        {
            dtgvListTooth.Columns.Add("ViTriRang", "Vị trí răng");
            dtgvListTooth.Columns.Add("RangSo", "Răng Số");
            dtgvListTooth.Columns.Add("BeMat", "Bề mặt");
            for (int i = 0; i < lTooth.Count; i++)
            {
                dtgvListTooth.Rows.Add(
                    lTooth[i][0].ToString(),
                    lTooth[i][1].ToString(),
                    lTooth[i][2].ToString());
            }
            
        }
        private void fAddTooth_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdBtnFirstCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnNotFirstCheck_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dtgvListTooth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvListTooth.RowCount <= 1) return;
            int rowId = e.RowIndex;
            if (rowId < 0) rowId = 0;
            if (rowId > dtgvListTooth.RowCount - 2) rowId = rowId - 1;
            DataGridViewRow row = dtgvListTooth.Rows[rowId];
            comboLocationTooth.Text = row.Cells[0].Value.ToString();
            numericTooth.Value = int.Parse(row.Cells[1].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgvListTooth.RowCount - 1; i++)
            {
                if (isInDtgvListTooth(i))
                {
                    MessageBox.Show("Răng đã được thêm");
                    return;
                }
            }
            string s = comboSurface.Text.ToString();
            if (string.IsNullOrEmpty(comboLocationTooth.Text.ToString()) ||
                string.IsNullOrEmpty(s)) return;
            dtgvListTooth.Rows.Add
                (comboLocationTooth.Text.ToString(),
                numericTooth.Value.ToString(),
                s[s.Length - 1]);

            MessageBox.Show("Thêm răng thành công");

            lTooth.Add(new object[3]{
                comboLocationTooth.Text.ToString(),
                numericTooth.Value.ToString(),
                s[s.Length - 1] });

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool b = false;
            for (int i = 0; i < dtgvListTooth.RowCount - 1; i++)
            {
                if (isInDtgvListTooth(i))
                {
                    dtgvListTooth.Rows.RemoveAt(i);
                    lTooth.RemoveAt(i);
                    b = true;
                }
            }
            if (b == false) MessageBox.Show("Không có răng để xóa");
            else MessageBox.Show("Xóa răng thành công");
        }
        bool isInDtgvListTooth(int i)
        {
            if (dtgvListTooth.Rows[i].Cells[1].Value.ToString() == numericTooth.Value.ToString()
                    && dtgvListTooth.Rows[i].Cells[0].Value.ToString() ==
                    comboLocationTooth.Text.ToString()) return true;
            return false;
        }
        private void btnAddSurface_Click(object sender, EventArgs e)
        {
            bool b = false;
            for (int i = 0; i < dtgvListTooth.RowCount - 1; i++)
            {
                if (!isInDtgvListTooth(i)) continue;
                
                string s = comboSurface.Text.ToString();
                char c = s[s.Length - 1];
                if (dtgvListTooth.Rows[i].Cells[2].Value.ToString().Contains(c)) break;
                if (dtgvListTooth.Rows[i].Cells[2].Value.ToString() == "A") break;
                b = true;
                if (c == 'A')
                {
                    dtgvListTooth.Rows[i].Cells[2].Value = "A";
                    lTooth[i][2] = "A";
                    break;
                }
                else
                {
                    dtgvListTooth.Rows[i].Cells[2].Value += c.ToString();
                    lTooth[i][2] += c.ToString();
                }
                
            }
            if (b) MessageBox.Show("Thêm bề mặt thành công");
            else MessageBox.Show("Thêm bề mặt không thành công");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lTooth.Count; i++)
            {
                if (lTooth[i][2].ToString().Length == 0)
                {
                    MessageBox.Show("Răng chưa được thêm bề mặt");
                    return;
                }
            }
            if (this.lTooth.Count == 0) MessageBox.Show("Răng chưa được thêm");
            else
            {
                MessageBox.Show("Thêm răng thành công");
                mydata(idTreat, lTooth);
                this.Close();
            }
        }

        private void btnDeleteSurface_Click(object sender, EventArgs e)
        {
            bool b = false;
            for (int i = 0; i < dtgvListTooth.RowCount - 1; i++)
            {
                if (!isInDtgvListTooth(i)) continue;
                string s = comboSurface.Text.ToString();
                char c = s[s.Length - 1];
                if (dtgvListTooth.Rows[i].Cells[2].Value.ToString().Contains(c))
                {
                    b = true;
                    dtgvListTooth.Rows[i].Cells[2].Value =
                        dtgvListTooth.Rows[i].Cells[2].Value.ToString().Replace(c.ToString(), "");
                    lTooth[i][2] = lTooth[i][2].ToString().Replace(c.ToString(), "");
                }

            }
            if (b) MessageBox.Show("Xóa bề mặt thành công");
            else MessageBox.Show("Xóa bề mặt không thành công");
        }
    }
}
