using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_PhongKham.DAO;

namespace Winform_PhongKham.DTO
{
    public class Const
    {
        public static Const instance;
        public static int btnWidthUpdateSchedule = 72;
        public static int btnHeightUpdateSchedule = 30;
        public static int heightUpdateSchedule = 10;
        public static int widthUpdateSchedule = 10;
        public static Color btnColor = Color.Aqua;
        public static int comeCreateAppointment = 0;
        public static int comeCreateTreat = 1;
        public int type;
        public string idDentist;
        public static Const Instance
        {
            get { if (instance == null) instance = new Const(); return instance; }
            private set { Const.instance = value; }
        }
        private Const() { }
        public void show(string text, int i)
        {
            if (i > 0) MessageBox.Show(text + " thành công!!!");
            else MessageBox.Show(text + " không thành công!!!");
        }
    }
}
