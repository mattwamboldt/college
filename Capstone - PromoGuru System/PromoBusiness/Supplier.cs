using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using Database;

namespace PromoBusiness
{
    public class Supplier : Contact
    {
        private string myCompanyName;
        private string mySla;
        private List<Product> myProducts;
        private DataTable myTable;

        public Supplier(int id, string companyName, string sla, string name, string phone, string active)
            : base(id, name, phone, active)
        {
            myProducts = new List<Product>();
            myTable = DatabaseAccess.getInstance().getTable("Supplier");
            myCompanyName = name;
            mySla = sla;
        }

        public bool Save()
        {
            DataRow row = null;
            foreach (DataRow lRow in myTable.Rows)
            {
                if ((int)lRow["supplier_id"] == ID)
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
                    ID, myCompanyName,
                    mySla, Name,
                    PhoneNumber,
                    active);
            }
            else
            {
                row["company_name"] = myCompanyName;
                row["sla"] = mySla;
                row["contact_name"] = Name;
                row["contact_phone"] = PhoneNumber;
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

        public string CompanyName
        {
            get
            {
                return myCompanyName;
            }
            set
            {
                myCompanyName = value;
            }
        }

        public string Sla
        {
            get
            {
                return mySla;
            }
            set
            {
                mySla = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return myProducts;
            }
        }
    }
}
