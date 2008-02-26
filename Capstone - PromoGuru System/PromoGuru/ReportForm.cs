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
    public partial class ReportForm : Form
    {
        BusinessLogic myLogic;
        public ReportForm(BusinessLogic logic)
        {
            InitializeComponent();
            myLogic = logic;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            decimal total = 0.0M;
            foreach (Order order in myLogic.Orders)
            {
                if (order != null)
                {
                    if (order.DateTaken >= DateTime.Now.AddDays(-7))
                    {
                        total += order.CalculateTotal();
                    }
                }
            }

            txtResult.Text = "Weekly Sales for " +
                DateTime.Now.AddDays(-7).ToShortDateString() +
                " to " + DateTime.Now.ToShortDateString() +
                ":\r\n\t" + total.ToString();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            decimal total = 0.0M;
            foreach (Order order in myLogic.Orders)
            {
                if (order != null)
                {
                    if (order.DateTaken.Month == DateTime.Now.Month
                        && order.DateTaken.Year == DateTime.Now.Year)
                    {
                        total += order.CalculateTotal();
                    }
                }
            }

            txtResult.Text = "Sales for the month of " +
                DateTime.Now.ToString("MMMM") +
                ":\r\n\t" + total.ToString();
        }

        private void btnUnsent_Click(object sender, EventArgs e)
        {
            txtResult.Text = "Unsent Orders:\r\n";
            foreach (Order order in myLogic.Orders)
            {
                if (order != null)
                {
                    if (order.DateTaken > order.DateShipped)
                    {
                        txtResult.Text += order.Id + "\r\n";
                    }
                }
            }
        }
    }
}