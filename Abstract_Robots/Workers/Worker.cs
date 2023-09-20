using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }
        public string GetName() { return fullName; }
        public string GetId() { return idNumber; }
        public DateTime GetBirthDate() { return birthDate; }
        public string GetPassword() { return password; }

        public void SetName(string FullName) { this.fullName = FullName; }
        public void SetId(string idnumber) { this.idNumber = idnumber; }
        public void SetPassword(string Password) { this.password = Password; }


        public abstract double Salary();

        public override string ToString()
        {
            string str = "";
            if (birthDate.Equals(DateTime.Today))
                str = " - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
