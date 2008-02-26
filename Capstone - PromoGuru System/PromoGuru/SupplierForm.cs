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
    public partial class SupplierForm : Form
    {
        BusinessLogic myLogic;
        public SupplierForm(BusinessLogic logic)
        {
            InitializeComponent();
            myLogic = logic;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            //works
            foreach (Supplier supplier in myLogic.Suppliers)
            {
                if (supplier != null)
                    idBox.Items.Add(supplier.ID);
            }

            idBox.SelectedIndex = 0;
        }

        private void phoneBox_Leave(object sender, EventArgs e)
        {
            //works
            if (idBox.SelectedIndex < myLogic.Suppliers.Count - 1)
            {
                try
                {
                    myLogic.Suppliers[(int)idBox.SelectedItem].PhoneNumber = txtContactNum.Text;
                }
                catch (Exception ex)
                {
                    txtContactNum.Text = myLogic.Suppliers[(int)idBox.SelectedItem].PhoneNumber;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CompanyNameBox_Leave(object sender, EventArgs e)
        {
            //works
            if (idBox.SelectedIndex < myLogic.Suppliers.Count - 1)
            {
                myLogic.Suppliers[(int)idBox.SelectedItem].CompanyName = txtCompanyName.Text;
            }
        }

        private void contactNameBox_Leave(object sender, EventArgs e)
        {
            //works
            if (idBox.SelectedIndex < myLogic.Suppliers.Count - 1)
            {
                myLogic.Suppliers[(int)idBox.SelectedItem].Name = txtContact.Text;
            }
        }

        private void slaBox_Leave(object sender, EventArgs e)
        {
            //works
            if (idBox.SelectedIndex < myLogic.Suppliers.Count - 1)
            {
                myLogic.Suppliers[(int)idBox.SelectedItem].Sla = txtSla.Text;
            }
        }

        private void activeCheck_CheckedChanged(object sender, EventArgs e)
        {
            //works
            myLogic.Suppliers[(int)idBox.SelectedItem].Active = activeCheck.Checked;
        }

        private void idBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeCheck.Checked = myLogic.Suppliers[(int)idBox.SelectedItem].Active;
            txtCompanyName.Text = myLogic.Suppliers[(int)idBox.SelectedItem].CompanyName;
            txtContact.Text = myLogic.Suppliers[(int)idBox.SelectedItem].Name;
            txtContactNum.Text = myLogic.Suppliers[(int)idBox.SelectedItem].PhoneNumber;
            txtSla.Text = myLogic.Suppliers[(int)idBox.SelectedItem].Sla;
            productList.DataSource = null;
            productList.DataSource = myLogic.Suppliers[(int)idBox.SelectedItem].Products;
            productList.DisplayMember = "Id";
            productList.ValueMember = "Id";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //works
            int next = idBox.SelectedIndex + 1;
            if (next >= idBox.Items.Count)
            {
                next = idBox.SelectionStart;
            }
            idBox.SelectedIndex = next;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            //works
            int previous = idBox.SelectedIndex - 1;
            if (previous < idBox.SelectionStart)
            {
                previous = idBox.Items.Count - 1;
            }
            idBox.SelectedIndex = previous;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            int newSupplier = myLogic.NewSupplier();
            idBox.Items.Add(newSupplier);
            idBox.SelectedItem = newSupplier;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int newProduct = myLogic.NewProduct((int)idBox.SelectedItem);
            productList.DataSource = null;
            productList.DataSource = myLogic.Suppliers[(int)idBox.SelectedItem].Products;
            productList.DisplayMember = "Id";
            productList.ValueMember = "Id";
        }
    }
}