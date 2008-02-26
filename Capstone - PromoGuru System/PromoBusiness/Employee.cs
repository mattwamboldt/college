using System;
using System.Collections.Generic;
using System.Text;

namespace PromoBusiness
{
    public class Employee : Contact
    {
        private string myUsername;
        private string myPassword;

        public Employee(int id, string name, string phone, string active)
            : base(id, name, phone, active)
        {
        }

        public string Username
        {
            get
            {
                return myUsername;
            }
            set
            {
                myUsername = value;
            }
        }

        public string Password
        {
            get
            {
                return myPassword;
            }
            set
            {
                myPassword = value;
            }
        }

        public bool logIn()
        {
            return true;
        }

        public void logOut()
        {
        }
    }
}
