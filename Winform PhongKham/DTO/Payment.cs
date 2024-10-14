using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DTO
{
    public class Payment
    {
        public string idPateint;
        public string note;
        public int type;
        public string name;
        public int money;
        public int total;
        public Payment(string idPateint, string note, int type, string name, int money, int total)
        {
            this.idPateint = idPateint;
            this.note = note;
            this.type = type;
            this.name = name;
            this.money = money;
            this.total = total;
        }
    }
}
