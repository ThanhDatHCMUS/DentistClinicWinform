using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DTO
{
    public class Dentist: Human
    {
        public string idDentist;
        public string idBranch;
        public string type;

        public Dentist(string fullName, string iD, string gender, string address,
            string phoneNumber, string dateOfBirth, string email, string idDentist, string type, string idBranch) : 
            base(fullName, iD, gender, address, phoneNumber, dateOfBirth, email)
        {
            this.idDentist = idDentist;
            this.email = email;
            this.idBranch = idBranch;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.fullName = fullName;
            this.type = type;
            this.iD = iD;
        }
    }
}
