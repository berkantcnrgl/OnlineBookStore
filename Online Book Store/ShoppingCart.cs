using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store 
{
    class ShoppingCart
    {
        public Customer customerID;
        private List<ItemToPurchase> itemsToPurchase;
        private double paymentAmount;
        enum paymentType { cash, creditcard }

        public ShoppingCart()
        {
            itemsToPurchase = new List<ItemToPurchase>();
        }
        public void printProducts()
        {

        }
        public void addProduct(ItemToPurchase item)
        {

        }

        public void removeProduct(ItemToPurchase item)
        {

        }

        public void placeOrder()
        {

        }

        public void cancelOrder()
        {

        }
        public void sendInvoidcebyEmail()
        {

        }
    }
}
