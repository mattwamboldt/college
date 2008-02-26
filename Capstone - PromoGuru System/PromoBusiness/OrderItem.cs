using System;
using System.Collections.Generic;
using System.Text;

namespace PromoBusiness
{
    public class OrderItem
    {
        private Product myProduct;
        private Order myOrder;
        private int myQuantity;

        public OrderItem(Order order, Product product, int quantity)
        {
            myOrder = order;
            myProduct = product;
            myQuantity = quantity;
        }

        public Order Order
        {
            get
            {
                return myOrder;
            }
        }

        public Product Product
        {
            get
            {
                return myProduct;
            }

            set
            {
                myProduct = value;
            }
        }

        public int Quantity
        {
            get
            {
                return myQuantity;
            }

            set
            {
                myQuantity = value;
            }
        }

        public int ProductId
        {
            get
            {
                return myProduct.Id;
            }
            set
            {
               
            }
        }

        public decimal CalculateLineTotal()
        {
            return myProduct.Price * myQuantity;
        }
    }
}
