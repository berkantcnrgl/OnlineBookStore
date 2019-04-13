using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    abstract class Product
    {
        private string name;
        private string iD;
        private double price;

        public string Name { get => name; set => name = value; }
        public string ID { get => iD; set => iD = value; }
        public double Price { get => price; set => price = value; }
    }
}
