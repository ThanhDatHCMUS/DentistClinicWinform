using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DTO
{
    public class TreatMedicine
    {
        public string idPatient;
        public string idMedicine;
        public string date;
        public int quantity;
        public TreatMedicine(string idMedicine, string date, string idPatient, int quantity)
        {
            this.idMedicine = idMedicine;
            this.date = date;
            this.idPatient = idPatient;
            this.quantity = quantity;
        }
        public TreatMedicine(string idMedicine, string date, string idPatient)
        {
            this.idMedicine = idMedicine;
            this.date = date;
            this.idPatient = idPatient;
        }
    }
}
