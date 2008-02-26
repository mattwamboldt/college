using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using Database;

namespace PromoBusiness
{
    public class Customer : Contact
    {
        private List<Order> myOrders;
        private DataTable myTable;

        public Customer(int id, string name, string phone, string active)
            : base(id, name, phone, active)
        {
            myOrders = new List<Order>();
            myTable = DatabaseAccess.getInstance().getTable("Customer");
        }

        public List<Order> Orders
        {
            get
            {
                return myOrders;
            }
        }

        public bool Save()
        {
            DataRow row = null;
            foreach (DataRow lRow in myTable.Rows)
            {
                if ((int)lRow["customer_id"] == ID)
                {
                    row = lRow;
                    break;
                }
            }

            if (row == null)
            {
                string active;
                if (Active)
                {
                    active = "y";
                }
                else
                {
                    active = "n";
                }
                myTable.Rows.Add(
                    ID, Name,
                    PhoneNumber,
                    active);
            }
            else
            {
                row["c_name"] = Name;
                row["phone_number"] = PhoneNumber;
                if (Active)
                {
                    row["active_in_system"] = "y";
                }
                else
                {
                    row["active_in_system"] = "n";
                }
            }
            return DatabaseAccess.getInstance().Save();
        }
    }
}
