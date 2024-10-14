using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DTO
{
    public class Medicine
    {
        public string idMedicine;
        public string nameMedicine;
        public string unit;
        public string CCD;
        public int price;
        public Medicine(string idMedicine, string nameMedicine, string unit, string CCD, int price)
        {
            this.idMedicine = idMedicine;
            this.nameMedicine = nameMedicine;
            this.unit = unit;
            this.CCD = CCD;
            this.price = price;
        }
    }
}
