using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Database;

namespace PromoBusiness
{
    public class Product
    {
        private int myId;
        private Supplier mySupplier;
        private string myImageLocation;
        private string myDescription;
        private decimal myPrice;
        private bool isActive;
        private DataTable myTable;

        public Product()
        { }

        public Product(int id, Supplier supplier, string description, decimal price, string imageLocation, string active)
        {
            myId = id;
            mySupplier = supplier;
            myDescription = description;
            myPrice = price;
            myImageLocation = imageLocation;
            if (active[0] == 'y')
            {
                isActive = true;
            }
            else
            {
                isActive = false;
            }
            myTable = DatabaseAccess.getInstance().getTable("Product");
        }

        public int Id
        {
            get
            {
                return myId;
            }
        }

        public Supplier Supplier
        {
            get
            {
                return mySupplier;
            }
            set
            {
                mySupplier = value;
            }
        }

        public string ImageLocation
        {
            get
            {
                return myImageLocation;
            }
            set
            {
                myImageLocation = value;
            }
        }

        public string Description
        {
            get
            {
                return myDescription;
            }
            set
            {
                myDescription = value;
            }
        }

        public decimal Price
        {
            get
            {
                return myPrice;
            }
            set
            {
                myPrice = value;
            }
        }

        public bool Active
        {
            get
            {
                return isActive;
            }
            set
            {
                Active = value;
            }
        }

        public bool Save()
        {
            DataRow row = null;
            foreach (DataRow lRow in myTable.Rows)
            {
                if ((int)lRow["product_id"] == myId)
                {
                    row = lRow;
                    break;
                }
            }

            string active;
            if (isActive)
            {
                active = "y";
            }
            else
            {
                active = "n";
            }

            if (row == null)
            {
                myTable.Rows.Add(
                    myId, mySupplier.ID,
                    myDescription, myPrice,
                    myImageLocation,
                    active);
            }
            else
            {
                row["description"] = myDescription;
                row["price"] = myPrice;
                row["image_location"] = myImageLocation;
                row["active_in_system"] = active;
            }
            return DatabaseAccess.getInstance().Save();
        }

        public string Serialize()
        {
            if (isActive)
            {
                string xml = "<Product>";
                xml += "<id>" + myId + "</id>";
                xml += "<description>" + myDescription + "</description>";
                xml += "<imageLocation>" + myImageLocation + "</imageLocation>";
                xml += "<price>" + myPrice + "</price>";
                xml += "</Product>";
                return xml;
            }
            else
            {
                return "";
            }
        }
    }
}
