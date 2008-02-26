using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PromoBusiness
{
    public class Contact
    {
        private int myId;
        private string myName;
        private string myPhoneNumber;
        private bool amActive;

        public Contact(int id, string name, string phone, string active)
        {
            myId = id;
            myName = name;
            myPhoneNumber = phone;
            if (active[0] == 'y')
            {
                amActive = true;
            }
            else
            {
                amActive = false;
            }
        }

        public int ID
        {
            get
            {
                return myId;
            }
        }

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return myPhoneNumber;
            }
            set
            {
                Regex validPhoneNumber = new Regex(@"^\d{3}-\d{3}-\d{4}$");
                if(validPhoneNumber.IsMatch(value))
                {
                    myPhoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Phone Number");
                }
            }
        }

        public bool Active
        {
            get
            {
                return amActive;
            }
            set
            {
                amActive = value;
            }
        }
    }
}
