using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    class Book : Product
    {
        public Book(int iD, string name, double price) : base(iD, name, price)
        {
        }

        public override double computeTax()
        {
            return this.ProductPrice * 5 / 100;
        }
    }
}
