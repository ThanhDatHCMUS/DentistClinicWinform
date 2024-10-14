using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DTO
{
    public class StockMedicine
    {
        public string idMedicine;
        public string date;
        public string unit;
        public int quantity;
        public StockMedicine(string idMedicine, string date, string unit, int quantity)
        {
            this.idMedicine = idMedicine;
            this.date = date;
            this.unit = unit;
            this.quantity = quantity;
        }
    }
}
