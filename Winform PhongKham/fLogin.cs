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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Const.Instance.type = 0;
            int isDentist = AccountDAO.Instance.isDentist(txtUserName.Text, txtPassword.Text);
            int isEmployee = AccountDAO.Instance.isEmployee(txtUserName.Text, txtPassword.Text);
            int isAdmin = AccountDAO.Instance.isAdmin(txtUserName.Text, txtPassword.Text);
            if (isDentist == 1) Const.Instance.type = 2;
            if (isAdmin == 1) Const.Instance.type = 1;
            if (isEmployee == 1) Const.Instance.type = 3;
            if (Const.Instance.type == 2) Const.Instance.idDentist = AccountDAO.Instance.getIDDentistFromUsername(txtUserName.Text);
            if(Const.Instance.type == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!!");
                return;
            }
            fManager f = new fManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn đóng chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
