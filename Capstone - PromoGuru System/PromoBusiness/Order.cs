using System;
using System.Collections.Generic;
using System.Text;
using Database;
using System.Data;

namespace PromoBusiness
{
    public class Order
    {
        private int myId;
        private Customer myCustomer;
        private DateTime myDateTaken;
        private DateTime myDateShipped;
        private List<OrderItem> myItems;
        private DataTable myTable;

        public Order(int orderId, Customer customer, DateTime dateTaken, DateTime dateShipped)
        {
            myItems = new List<OrderItem>();
            myTable = DatabaseAccess.getInstance().getTable("CustomerOrder");
            myCustomer = customer;
            myId = orderId;
            myDateTaken = dateTaken;
            myDateShipped = dateShipped;
        }

        public int Id
        {
            get
            {
                return myId;
            }
        }

        public Customer Customer
        {
            get
            {
                return myCustomer;
            }
        }

        public DateTime DateTaken
        {
            get
            {
                return myDateTaken;
            }
            set
            {
                myDateTaken = value;
            }
        }

        public DateTime DateShipped
        {
            get
            {
                return myDateShipped;
            }
            set
            {
                myDateShipped = value;
            }
        }

        public List<OrderItem> Items
        {
            get
            {
                return myItems;
            }
        }

        public decimal CalculateTotal()
        {
            decimal sale = 0.0M;
            foreach (OrderItem item in myItems)
            {
                sale += item.CalculateLineTotal();
            }
            return sale;
        }

        public bool Save()
        {
            DataRow row = null;
            foreach (DataRow lRow in myTable.Rows)
            {
                if ((int)lRow["order_id"] == myId)
                {
                    row = lRow;
                    break;
                }
            }

            if (row == null)
            {
                myTable.Rows.Add(myId, myCustomer.ID, myDateTaken, myDateTaken);
            }
            else
            {
                row["date_taken"] = myDateTaken;
                row["date_shipped"] = myDateShipped;
            }

            foreach (OrderItem item in myItems)
            {
                DataRow iRow = null;
                foreach (DataRow lRow in DatabaseAccess.getInstance().getTable("OrderItem").Rows)
                {
                    if ((int)lRow["order_id"] == myId && (int)lRow["product_id"] == item.Product.Id)
                    {
                        iRow = lRow;
                        break;
                    }
                }

                if (iRow == null)
                {
                    DatabaseAccess.getInstance().getTable("OrderItem").Rows.Add(myId, item.Product.Id, item.Quantity);
                }
                else
                {
                    iRow["quantity"] = item.Quantity;
                }

            }
            return DatabaseAccess.getInstance().Save();
        }
    }
}
