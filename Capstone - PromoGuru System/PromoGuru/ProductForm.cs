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
    public partial class ProductForm : Form
    {
        BusinessLogic myLogic;
        public ProductForm(BusinessLogic logic)
        {
            InitializeComponent();
            myLogic = logic;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            foreach (Product product in myLogic.Products)
            {
                if (product != null)
                {
                    idProduct.Items.Add(product.Id);
                    txtDesc.Text = (product.Description);
                }
            }

            foreach (Supplier supplier in myLogic.Suppliers)
            {
                if (supplier != null)
                {
                    idSupplier.Items.Add(supplier.ID);
                }
            }
            idProduct.SelectedIndex = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //busted
            int newProduct = myLogic.NewProduct((int)idSupplier.SelectedItem);
            idProduct.Items.Add(newProduct);
            idProduct.SelectedItem = newProduct;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int next = idProduct.SelectedIndex + 1;
            if (next >= idProduct.Items.Count)
            {
                next = idProduct.SelectionStart;
            }
            idProduct.SelectedIndex = next;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int previous = idProduct.SelectedIndex - 1;
            if (previous <= idProduct.Items.Count)
            {
                previous = idProduct.SelectionStart;
            }
            idProduct.SelectedIndex = previous;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.jpg";
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;
            ofd.Title = "Browse for image..";
            ofd.Filter = "All files (*.*)|*.*|JPEG (*.jpg)|*.jpg";
            ofd.ShowDialog();
            picBox.ImageLocation = ofd.FileName;
            myLogic.Products[(int)idProduct.SelectedItem].ImageLocation = ofd.FileName;
        }

        private void idProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBox.ImageLocation = myLogic.Products[(int)idProduct.SelectedItem].ImageLocation;
            idSupplier.SelectedItem = myLogic.Products[(int)idProduct.SelectedItem].Supplier.ID;
            txtPrice.Text = myLogic.Products[(int)idProduct.SelectedItem].Price.ToString();
            activeCheck.Checked = myLogic.Products[(int)idProduct.SelectedItem].Active;
            txtDesc.Text = myLogic.Products[(int)idProduct.SelectedItem].Description;
        }

        private void activeCheck_CheckedChanged(object sender, EventArgs e)
        {
            activeCheck.Checked = myLogic.Products[(int)idProduct.SelectedItem].Active;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal temp = Convert.ToDecimal(txtPrice.Text);
                if (temp < 0.0M)
                {
                    MessageBox.Show("Invalid Price. Must be positive Decimal Value.");
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                }
                else
                {
                    myLogic.Products[(int)idProduct.SelectedItem].Price = temp;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Price. Must be positive Decimal Value.");
                txtPrice.Focus();
                txtPrice.SelectAll();
            }
        }

        private void idSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //remove product from old supplier listing
            myLogic.Products[(int)idProduct.SelectedItem].Supplier.Products.Remove(myLogic.Products[(int)idProduct.SelectedItem]);
            //add product to new supplier listing
            myLogic.Suppliers[(int)idSupplier.SelectedItem].Products.Add(myLogic.Products[(int)idProduct.SelectedItem]);
            //set products supplier to new supplier
            myLogic.Products[(int)idProduct.SelectedItem].Supplier = myLogic.Suppliers[(int)idSupplier.SelectedItem];
        }
    }
}