using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    class TestProgram
    {
        public static void Main(string[] args)
        {
            Book objBook1 = new Book(1, "BookOne", 100);
            Book objBook2 = new Book(2, "BookTwo", 150);
            Book objBook3 = new Book(3, "BookThree", 200);
            Phone objPhone1 = new Phone(4, "PhoneOne", 500);
            Phone objPhone2 = new Phone(5, "PhoneTwo", 1000);

            double TotalBookTax = 0;
            double TotalPhoneTax = 0;

            List<Book> Books = new List<Book> { };
            Books.Add(objBook1);
            Books.Add(objBook2);
            Books.Add(objBook3);

            List<Phone> Phones = new List<Phone> { };
            Phones.Add(objPhone1);
            Phones.Add(objPhone2);

            for(int i = 0; i < Books.Count; i++)
            {
                TotalBookTax += Books[i].computeTax();
            }
            for(int i = 0; i < Phones.Count; i++)
            {
                TotalPhoneTax += Phones[i].computeTax();
            }
            Console.WriteLine("Total tax of Books and Phones is: " + (TotalBookTax+TotalPhoneTax));
        }
    }
}
