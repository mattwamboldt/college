using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Database;
using PromoBusiness;

namespace Tests
{
    [TestFixture()]
    public class DatabaseTests
    {
        MSAccessDatabase database;
        [SetUp()]
        public void Init()
        {
            database = new MSAccessDatabase("\\dev\\PromoGuruSystem\\PromoGuru\\PromoGuru.mdb");
        }

        [TearDown()]
        public void Deinit()
        {
        }

        //#1
        [Test()]
        public void ConnectToDatabase()
        {
            Assert.IsTrue( database.LoadTableData("Supplier", "Product", "Customer", "CustomerOrder", "OrderItem"), "Data failed to load");
        }

        //#2
        [Test()]
        public void ReadSingleValue()
        {
            ConnectToDatabase();
            Assert.IsTrue( "new" == database.ReadSingleValue("Supplier", "sla", "1"), "Values don't match");
        }

        //#3
        [Test()]
        public void ReadRow()
        {
            ConnectToDatabase();
            Assert.IsNotNull(database.ReadRow("Supplier", "1"), "Failed to read row");
        }

        //#4
        [Test()]
        public void SaveChanges()
        {
            ConnectToDatabase();
            try
            {
                Assert.IsTrue(database.Save(), "Failed to save");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //#5
        [Test()]
        public void AddItem()
        {
            ConnectToDatabase();
            try
            {
                database.getDataSet().Tables["Supplier"].Rows.Add(
                    database.findUntakenIndex("Supplier"),
                    "Tomfool, Inc",
                    2,
                    "Bill",
                    "902-909-0909",
                    "y");
                Assert.IsTrue(database.Save(), "Item not Added");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //#6
        [Test()]
        public void RemoveItem()
        {
            ConnectToDatabase();
            try
            {
                database.getTable("Supplier").Rows[database.getTable("Supplier").Rows.Count - 1].Delete();
                database.Save();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //#7
        [Test()]
        public void EditItem()
        {
            ConnectToDatabase();
            try
            {
                database.getTable("Supplier").Rows[0]["company_name"] = "Mark";
                Assert.IsTrue(database.Save(), "Item not edited");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message + "\n" + ex.StackTrace);
            }
        }
        
    }
}
