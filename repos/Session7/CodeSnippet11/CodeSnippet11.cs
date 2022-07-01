using System;
interface ISet
{
    void AcceptDetails(int valOne, string valTwo);
}
interface IGet
{
    void Display();
}
class Employee : ISet
{
    int _empID;
    string _empName;
    public void AcceptDetails(int valOne, string valTwo)
    {
        _empID=valOne;
        _empName=valTwo;
    }
     static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.AcceptDetails(10, "Jack");
        IGet objGet = emp as IGet;
        if(objGet != null)
        {
            objGet.Display();
        }
        else
        {
            Console.WriteLine("Invalid casting occured");
        }
    }
}
