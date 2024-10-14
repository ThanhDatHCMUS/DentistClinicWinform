using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_PhongKham.DTO
{
    public class Human
    {
        public string fullName;
        public string iD;
        public string gender;
        public string address;
        public string phoneNumber;
        public string dateOfBirth;
        public string email;


        public Human(string fullName, string iD, string gender, string address, string phoneNumber, string dateOfBirth, string email)
        {
            this.fullName = fullName;
            this.iD = iD;
            this.gender = gender;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
        }
    }
}
