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
    public partial class CustomerForm : Form
    {
        BusinessLogic myLogic;
        public CustomerForm(BusinessLogic logic)
        {
            InitializeComponent();
            myLogic = logic;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //works
            idBox.Items.Clear();
            foreach (Customer customer in myLogic.Customers)
            {
                if (customer != null)
                {
                    idBox.Items.Add(customer.ID);
                }
            }
            idBox.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //works
            int newCustomer = myLogic.NewCustomer();
            idBox.Items.Add(newCustomer);
            idBox.SelectedItem = newCustomer;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //works
            int next = idBox.SelectedIndex + 1;
            if (next >= idBox.Items.Count)
            {
                next = idBox.SelectionStart;
            }
            idBox.SelectedIndex = next;
        }

        private void idBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //works

            activeCheck.Checked = myLogic.Customers[(int)idBox.SelectedItem].Active;
            txtName.Text = myLogic.Customers[(int)idBox.SelectedItem].Name;
            txtPhoneNum.Text = myLogic.Customers[(int)idBox.SelectedItem].PhoneNumber;

            lstOrders.DataSource = myLogic.Customers[(int)idBox.SelectedItem].Orders;
            lstOrders.DisplayMember = "Id";
            lstOrders.ValueMember = "Id";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //works
            int previous = idBox.SelectedIndex - 1;
            if (previous < idBox.SelectionStart)
            {
                previous = idBox.Items.Count - 1;
            }
            idBox.SelectedIndex = previous;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //works
            int newOrder = myLogic.NewOrder((int)idBox.SelectedItem);
            lstOrders.DataSource = null;
            lstOrders.DataSource = myLogic.Customers[(int)idBox.SelectedItem].Orders;
            lstOrders.DisplayMember = "Id";
            lstOrders.ValueMember = "Id";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            //works
            myLogic.Customers[(int)idBox.SelectedItem].Name = txtName.Text;
        }

        private void txtPhoneNum_Leave(object sender, EventArgs e)
        {
            //works
            try
            {
                myLogic.Customers[(int)idBox.SelectedItem].PhoneNumber = txtPhoneNum.Text;
            }
            catch (Exception ex)
            {
                txtPhoneNum.Focus();
                txtPhoneNum.SelectAll();
                MessageBox.Show(ex.Message);
            }
        }

        private void activeCheck_CheckedChanged(object sender, EventArgs e)
        {
            //works
            myLogic.Customers[(int)idBox.SelectedItem].Active = activeCheck.Checked;
        }
    }
}