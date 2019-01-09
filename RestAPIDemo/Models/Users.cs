using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIDemo
{
    public class Users
    {
        String firstname;
        public String FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        String lastname;
        public String LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        String registrationNumber;
        public String RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
    }
}
