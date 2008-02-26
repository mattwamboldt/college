using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Database;
using PromoBusiness;

namespace PromoGuru
{
    public partial class MdiForm : Form
    {
        private SupplierForm mySupplierForm;
        private OrderForm myOrderForm;
        private ProductForm myProductForm;
        private CustomerForm myCustomerForm;
        private ReportForm myReportForm;
        private BusinessLogic myLogic;

        public MdiForm()
        {
            InitializeComponent();
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {
            myLogic = new BusinessLogic("PromoGuru.mdb");
            myLogic.LoadBusinessData();
            mySupplierForm = new SupplierForm(myLogic);
            mySupplierForm.MdiParent = this;
            myCustomerForm = new CustomerForm(myLogic);
            myCustomerForm.MdiParent = this;
            myProductForm = new ProductForm(myLogic);
            myProductForm.MdiParent = this;
            myOrderForm = new OrderForm(myLogic);
            myOrderForm.MdiParent = this;
            myReportForm = new ReportForm(myLogic);
            myReportForm.MdiParent = this;
        }

        private void supplierManagerMenuItem_Click(object sender, EventArgs e)
        {
            if (!supplierManagerMenuItem.Checked)
            {
                mySupplierForm.Hide();
            }
            else
            {
                mySupplierForm.Show();
            }
        }
        private void customerManagerMenuItem_Click(object sender, EventArgs e)
        {
            if (!customerManagerMenuItem.Checked)
            {
                myCustomerForm.Hide();
            }
            else
            {
                myCustomerForm.Show();
            }
        }
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            myLogic.SaveAll();
        }

        private void productManagerMenuItem_Click(object sender, EventArgs e)
        {
            if (!productManagerMenuItem.Checked)
            {
                myProductForm.Hide();
            }
            else
            {
                myProductForm.Show();
            }
        }

        private void orderManagerMenuItem_Click(object sender, EventArgs e)
        {
            if (!orderManagerMenuItem.Checked)
            {
                myOrderForm.Hide();
            }
            else
            {
                myOrderForm.Show();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportViewerMenuItem_Click(object sender, EventArgs e)
        {
            if (!reportViewerMenuItem.Checked)
            {
                myReportForm.Hide();
            }
            else
            {
                myReportForm.Show();
            }
        }
    }
}