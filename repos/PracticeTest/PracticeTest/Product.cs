using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeTest
{
    abstract class Product
    {
        private int ID;
        private string Name;
        private double Price;

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string ProductName
        {
            get { return Name; }
            set { Name = value; }
        }
        public double ProductPrice
        {
            get { return Price; }
            set { Price = value; }
        }
        public Product(int iD, string name, double price)
        {
            ID=iD;
            Name=name;
            Price=price;
        }

        public abstract double computeTax();
    }
}

