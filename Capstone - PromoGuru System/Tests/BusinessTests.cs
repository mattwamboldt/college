using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using PromoBusiness;

namespace Tests
{
    [TestFixture()]
    public class BusinessTests
    {
        BusinessLogic app;
        [SetUp()]
        public void Init()
        {
            app = new BusinessLogic("J:\\dev\\PromoGuruSystem\\PromoGuru\\PromoGuru.mdb");
        }

        [TearDown()]
        public void DeInit()
        {
        }

        //#1
        [Test()]
        public void ValidPhone()
        {
            Contact contact = new Contact(666999, "test", "555-555-5555", "n");
            try
            {
                contact.PhoneNumber = "900-789-0988";
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //#2
        [Test()]
        public void InValidPhone()
        {
            bool isinvalid = false;
            Contact contact = new Contact(666999, "test", "555-555-5555", "n");
            try
            {
                contact.PhoneNumber = "david";
            }
            catch (Exception)
            {
                isinvalid = true;
            }
            Assert.IsTrue(isinvalid, "valid phone");
        }

        //#3
        [Test()]
        public void CreateBusinessLayer()
        {
            try
            {
                BusinessLogic application = new BusinessLogic("\\dev\\PromoGuruSystem\\PromoGuru\\PromoGuru.mdb");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //#4
        [Test()]
        public void LoadSuppliers()
        {
            app.LoadBusinessData();
            Assert.IsNotEmpty(app.Suppliers, "Failed to load data");
        }

        //#5
        [Test()]
        public void LoadCustomers()
        {
            app.LoadBusinessData();
            Assert.IsNotEmpty(app.Customers, "Failed to load data");
        }
        //#6
        [Test()]
        public void LoadOrders()
        {
            app.LoadBusinessData();
            Assert.IsNotEmpty(app.Orders, "Failed to load data");
        }

        //#7
        [Test()]
        public void LoadProducts()
        {
            app.LoadBusinessData();
            Assert.IsNotEmpty(app.Products, "Failed to load data");
        }

        //#8
        [Test()]
        public void Save()
        {
            app.Suppliers.Add(new Supplier(app.Suppliers.Count, "test", "new", "test", "902-902-9090", "n"));
            try
            {
                app.SaveAll();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //#9
        [Test()]
        public void LineCalc()
        {
            app.LoadBusinessData();
            Assert.IsTrue(app.Orders[1].Items[0].CalculateLineTotal() == 66, "failed calculation, value returned was" + app.Orders[1].Items[1].CalculateLineTotal());
        }

        //#9
        [Test()]
        public void OrderCalc()
        {
            app.LoadBusinessData();
            Assert.IsTrue(app.Orders[1].CalculateTotal() == 176, "failed calculation, value returned was " + app.Orders[1].CalculateTotal());
        }

        //#10
        [Test()]
        public void TotalCalc()
        {
            app.LoadBusinessData();
            Assert.IsTrue(app.CalculateTotalSales() == 176, "failed calculation, value returned was " + app.CalculateTotalSales());
        }
    }
}
