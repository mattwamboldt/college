using System;
using System.Collections.Generic;
using System.Text;
using Database;
using System.Data;

namespace PromoBusiness
{
    public class BusinessLogic
    {
        #region "private variables"
        private List<Customer> myCustomers;
        private List<Supplier> mySuppliers;
        private List<Product> myProducts;
        private List<Order> myOrders;
        private MSAccessDatabase myDatabase;
        #endregion

        public BusinessLogic(string databasePath)
        {
            DatabaseAccess.createInstance(databasePath, "Supplier", "Customer", "Product", "CustomerOrder", "OrderItem");
            myDatabase = DatabaseAccess.getInstance();
            myCustomers = new List<Customer>();
            mySuppliers = new List<Supplier>();
            myProducts = new List<Product>();
            myOrders = new List<Order>();
        }

        public decimal CalculateTotalSales()
        {
            decimal sales = 0.0M;
            foreach (Order order in myOrders)
            {
                if (order != null)
                {
                    sales += order.CalculateTotal();
                }
            }
            return sales;
        }

        #region "properties"

        public List<Customer> Customers
        {
            get
            {
                return myCustomers;
            }
        }

        public List<Supplier> Suppliers
        {
            get
            {
                return mySuppliers;
            }
        }

        public List<Product> Products
        {
            get
            {
                return myProducts;
            }
        }

        public List<Order> Orders
        {
            get
            {
                return myOrders;
            }
        }

        #endregion

        public void SaveAll()
        {
            foreach (Supplier supplier in mySuppliers)
            {
                if (supplier != null)
                {
                    supplier.Save();
                }
            }
            foreach (Customer customer in myCustomers)
            {
                if (customer != null)
                {
                    customer.Save();
                }
            }
            foreach (Product product in myProducts)
            {
                if (product != null)
                {
                    product.Save();
                }
            }

            foreach (Order order in myOrders)
            {
                if (order != null)
                {
                    order.Save();
                }
            }
        }

        //make private in final version
        public void LoadBusinessData()
        {
            //load the data for each table
            DataColumn primaryKeyColumn = myDatabase.getTable("Supplier").PrimaryKey[0];
            foreach (DataRow row in myDatabase.getTable("Supplier").Rows)
            {
                int key = (int)row[primaryKeyColumn];

                while( key >= mySuppliers.Count )
                {
                    mySuppliers.Add(null);
                }

                mySuppliers[key] = new Supplier(key, (string)row["company_name"],
                                                    (string)row["sla"],
                                                    (string)row["contact_name"],
                                                    (string)row["contact_phone"],
                                                    (string)row["active_in_system"]);
                
            }

            primaryKeyColumn = myDatabase.getTable("Product").PrimaryKey[0];
            foreach (DataRow row in myDatabase.getTable("Product").Rows)
            {
                int key = (int)row[primaryKeyColumn];

                while (key >= myProducts.Count)
                {
                    myProducts.Add(null);
                }

                myProducts[key] = new Product(key, mySuppliers[(int)row["supplier_id"]],
                                                    (string)row["description"],
                                                    (decimal)row["price"],
                                                    (string)row["image_location"],
                                                    (string)row["active_in_system"]);

                myProducts[key].Supplier.Products.Add(myProducts[key]);
            }

            primaryKeyColumn = myDatabase.getTable("Customer").PrimaryKey[0];
            foreach (DataRow row in myDatabase.getTable("Customer").Rows)
            {
                int key = (int)row[primaryKeyColumn];

                while (key >= myCustomers.Count)
                {
                    myCustomers.Add(null);
                }

                myCustomers[key] = new Customer(key, (string)row["c_name"],
                                                  (string)row["phone_number"],
                                                  (string)row["active_in_system"]);
            }

            primaryKeyColumn = myDatabase.getTable("CustomerOrder").PrimaryKey[0];
            foreach (DataRow row in myDatabase.getTable("CustomerOrder").Rows)
            {
                int key = (int)row[primaryKeyColumn];

                while (key >= myOrders.Count)
                {
                    myOrders.Add(null);
                }

                myOrders[key] = new Order(key, myCustomers[(int)row["customer_id"]],
                                            (DateTime)row["date_taken"],
                                            (DateTime)row["date_shipped"]);

                myOrders[key].Customer.Orders.Add(myOrders[key]);
            }

            foreach (DataRow row in myDatabase.getTable("OrderItem").Rows)
            {
                myOrders[(int)row["order_id"]].Items.Add(new OrderItem(myOrders[(int)row["order_id"]],
                                                                        myProducts[(int)row["product_id"]],
                                                                        (int)row["quantity"]));
            }
        }

        public string SerializeProducts()
        {
            string xml = "<Products>";
            foreach (Product product in myProducts)
            {
                if (product != null)
                {
                    xml += product.Serialize();
                }
            }
            xml += "</Products>";
            return xml;
        }

        public int NewCustomer()
        {
            for (int i = 1; i < myCustomers.Count; i++ )
            {
                if (myCustomers[i] == null)
                {
                    myCustomers[i] = new Customer(i, "default", "000-000-0000", "N");
                    return i;
                }
            }
            myCustomers.Add(new Customer(myCustomers.Count, "default", "000-000-0000", "N"));
            return myCustomers.Count - 1;
        }

        public int NewOrder(int customerID)
        {
            for (int i = 1; i < myOrders.Count; i++)
            {
                if (myOrders[i] == null)
                {
                    myOrders[i] = new Order(i, myCustomers[customerID], DateTime.Now, new DateTime(2001, 1, 1));
                    myCustomers[customerID].Orders.Add(myOrders[i]);
                    return i;
                }
            }
            myOrders.Add(new Order(myOrders.Count, myCustomers[customerID], DateTime.Now, new DateTime(2001, 1, 1)));
            myCustomers[customerID].Orders.Add(myOrders[myOrders.Count - 1]);
            return myOrders.Count - 1;
        }

        public int NewSupplier()
        {
            for (int i = 1; i < mySuppliers.Count; i++)
            {
                if (mySuppliers[i] == null)
                {
                    mySuppliers[i] = new Supplier(i, "default", "default", "default", "000-000-0000", "N");
                    return i;
                }
            }
            mySuppliers.Add(new Supplier(mySuppliers.Count, "default", "default", "default", "000-000-0000", "N"));
            return mySuppliers.Count - 1;
        }

        public int NewProduct(int supplierID)
        {
            for (int i = 1; i < myProducts.Count; i++)
            {
                if (myProducts[i] == null)
                {
                    myProducts[i] = new Product(i, mySuppliers[supplierID], "default", 0.0M, "default", "N");
                    mySuppliers[supplierID].Products.Add(myProducts[i]);
                    return i;
                }
            }
            myProducts.Add(new Product(myProducts.Count, mySuppliers[supplierID], "default", 0.0M, "default", "N"));
            mySuppliers[supplierID].Products.Add(myProducts[myProducts.Count - 1]);
            return myProducts.Count - 1;
        }
    }
}
