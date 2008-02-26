using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PromoBusiness;

namespace PromoGuru
{
    public partial class frmSingleInput : Form
    {
        public int Value;

        public frmSingleInput(string labelValue, List<Customer> validSelections)
        {
            InitializeComponent();
            lblMessage.Text = labelValue;
            foreach (Customer customer in validSelections)
            {
                if (customer != null)
                {
                    cmbValues.Items.Add(customer.ID);
                }
            }
            cmbValues.SelectedIndex = cmbValues.SelectionStart;
        }

        public frmSingleInput(string labelValue, List<Product> validSelections)
        {
            InitializeComponent();
            lblMessage.Text = labelValue;
            foreach (Product product in validSelections)
            {
                if (product != null)
                {
                    cmbValues.Items.Add(product.Id);
                }
            }
            cmbValues.SelectedIndex = cmbValues.SelectionStart;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Value = (int)cmbValues.SelectedItem;
        }
    }
}