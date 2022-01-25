using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Article
    {
        private readonly string name, shop;
        private double price;

        public string Name => name;
        public string Shop => shop;
        public double Price { get => price; set => price = value; }

        public Article(string name, string shop, double price)
        {
            this.name = name;
            this.shop = shop;
            this.price = price;
        }

        public override string ToString()
        {
            return "Product name-'" + this.name + "', shop-'" + this.shop + "', price-" + this.price + "grn.";
        }
    }
}
