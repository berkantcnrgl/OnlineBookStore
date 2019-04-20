using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public abstract class Product
    {
        private string id;
        private string name;
        private double price;

   
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public double Price { get => price; set => price = value; }

        public Product(string id,string name,double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}
