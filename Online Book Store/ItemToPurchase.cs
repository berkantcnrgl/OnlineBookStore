using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    class ItemToPurchase
    {
        private string product;
        private string quantity;

        public string Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public string Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}
