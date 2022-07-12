using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10
{
    abstract class Employee
    {
        private static int employeeCount = 1;
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public double BaseSalary
        {
            get { return employeeBaseSalary; }
            set { employeeBaseSalary = value; }
        }
        public int ID
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public Employee(string Name, double baseSalary)
        {
            this.Name = Name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }
        public string toString()
        {
            return this.ID + " " + this.Name;
        }
        public abstract string employeeStatus();
    }
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(string name) : base(name, 75000)
        {

        }
        public override string employeeStatus()
        {
            return this.toString() + "has" + this.successfulCheckIns + " successful check ins";
        }
    }
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;
        public BusinessEmployee(string name) : base(name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return this.toString() + "with a budget of " + this.bonusBudget;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}

