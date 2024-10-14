using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_PhongKham.DTO
{
    public class TreatPlan
    {
        public string idPatient;
        public string idDentist;
        public string idAssistant;
        public string note;
        public string date;
        public string sDirectory;
        public string sTreat;
        public string sTooth;
        public TreatPlan(string idPatient, string idDentist, string idAssistant, 
            string note, string date, string sDirectory, string sTreat, string sTooth) 
        { 
            this.idPatient = idPatient;
            this.date = date;
            this.sDirectory = sDirectory;
            this.idDentist = idDentist;
            this.idAssistant = idAssistant;
            this.note = note;
            this.sTooth = sTooth;
            this.sTreat = sTreat;
        }

    }
}
