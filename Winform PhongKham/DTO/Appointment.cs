using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DTO
{
    public class Appointment
    {
        public string idPatient;
        public string date;
        public string idDentist;
        public string dateRecheck;
        public string orderNumber;
        public Appointment(string idPatient, string date, string idDentist, string dateRecheck, string orderNumber) 
        {
            this.idPatient = idPatient;
            this.date = date;
            this.dateRecheck = dateRecheck;
            this.idDentist = idDentist;
            this.orderNumber = orderNumber;
        }
    }
}
