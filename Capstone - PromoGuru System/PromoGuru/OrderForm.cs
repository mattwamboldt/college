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
    public partial class OrderForm : Form
    {
        BusinessLogic myLogic;
        public OrderForm(BusinessLogic logic)
        {
            InitializeComponent();
            myLogic = logic;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            foreach (Order order in myLogic.Orders)
            {
                if (order != null)
                {
                    cmbOrderId.Items.Add(order.Id);
                }
            }

            cmbOrderId.SelectedIndex = cmbOrderId.SelectionStart;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int previous = cmbOrderId.SelectedIndex - 1;
            if (previous < cmbOrderId.SelectionStart)
            {
                previous = cmbOrderId.Items.Count - 1;
            }
            cmbOrderId.SelectedIndex = previous;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmSingleInput idInput = new frmSingleInput("Select Customer Id:", myLogic.Customers);
            idInput.ShowDialog();
            int newOrder = myLogic.NewOrder(idInput.Value);
            cmbOrderId.Items.Add(newOrder);
            cmbOrderId.SelectedItem = newOrder;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSingleInput idInput = new frmSingleInput("Select Product Id:", myLogic.Products);
            idInput.ShowDialog();

            myLogic.Orders[(int)cmbOrderId.SelectedItem].Items.Add(new OrderItem(myLogic.Orders[(int)cmbOrderId.SelectedItem], myLogic.Products[idInput.Value], 0));
            lstProductIds.DataSource = null;
            lstQuantities.DataSource = null;
            lstProductIds.DataSource = myLogic.Orders[(int)cmbOrderId.SelectedItem].Items;
            lstProductIds.DisplayMember = "ProductId";
            lstProductIds.ValueMember = "ProductId";
            lstQuantities.DataSource = myLogic.Orders[(int)cmbOrderId.SelectedItem].Items;
            lstQuantities.DisplayMember = "Quantity";
            lstQuantities.ValueMember = "Quantity";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int next = cmbOrderId.SelectedIndex + 1;
            if (next >= cmbOrderId.Items.Count)
            {
                next = cmbOrderId.SelectionStart;
            }
            cmbOrderId.SelectedIndex = next;
        }

        private void cmbOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = myLogic.Orders[(int)cmbOrderId.SelectedItem].Customer.ID.ToString();
            dropDate.Value = myLogic.Orders[(int)cmbOrderId.SelectedItem].DateTaken;
            dropShipped.Value = myLogic.Orders[(int)cmbOrderId.SelectedItem].DateShipped;
            lstProductIds.DataSource = null;
            lstQuantities.DataSource = null;
            lstProductIds.DataSource = myLogic.Orders[(int)cmbOrderId.SelectedItem].Items;
            lstProductIds.DisplayMember = "ProductId";
            lstProductIds.ValueMember = "ProductId";
            lstQuantities.DataSource = myLogic.Orders[(int)cmbOrderId.SelectedItem].Items;
            lstQuantities.DisplayMember = "Quantity";
            lstQuantities.ValueMember = "Quantity";
        }

        private void dropDate_ValueChanged(object sender, EventArgs e)
        {
            myLogic.Orders[(int)cmbOrderId.SelectedItem].DateTaken = dropDate.Value;
        }

        private void dropShipped_ValueChanged(object sender, EventArgs e)
        {
            myLogic.Orders[(int)cmbOrderId.SelectedItem].DateShipped = dropShipped.Value;
        }

        private void lstProductIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductIds.ValueMember != "" && lstProductIds.SelectedIndex != -1)
            {
                nmsQuantity.Value = myLogic.Orders[(int)cmbOrderId.SelectedItem].Items.Find(new Predicate<OrderItem>(IsMatch)).Quantity;
            }
        }

        private void nmsQuantity_ValueChanged(object sender, EventArgs e)
        {
            myLogic.Orders[(int)cmbOrderId.SelectedItem].Items.Find(new Predicate<OrderItem>(IsMatch)).Quantity = (int)nmsQuantity.Value;
            lstProductIds.DataSource = null;
            lstQuantities.DataSource = null;
            lstProductIds.DataSource = myLogic.Orders[(int)cmbOrderId.SelectedItem].Items;
            lstProductIds.DisplayMember = "ProductId";
            lstProductIds.ValueMember = "ProductId";
            lstQuantities.DataSource = myLogic.Orders[(int)cmbOrderId.SelectedItem].Items;
            lstQuantities.DisplayMember = "Quantity";
            lstQuantities.ValueMember = "Quantity";
        }

        private bool IsMatch(OrderItem item)
        {
            return item.ProductId == (int)lstProductIds.SelectedValue;
        }
    }
}