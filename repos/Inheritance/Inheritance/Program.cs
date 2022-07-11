class People
{
    protected string Name
    {
        get; set;
    }
    protected int Age
    {
        get; set;
    }
    protected string Gender
    {
        get; set;
    }

    public void displayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Gender: " + Gender);
    }
}

class Student : People
{
    public float Score
    {
        get; set;
    }

    new void DisplayInfo()
    {
        base.displayInfo();
        Console.WriteLine("Student test score: " + Score);
    }
/*    public static void Main(string[] args)
    {
        Student objStudent = new Student();
        objStudent.Name = "Dinh Quang Anh";
        objStudent.Age = 10;
        objStudent.Gender = "Male";
        objStudent.Score = 5.75F;

        objStudent.DisplayInfo();
    }*/
}

class Staff : People
{
    public double Salary
    {
        get; set;
    }
    new void DisplayInfo()
    {
        base.displayInfo();
        Console.WriteLine("Salary : " + Salary);
    }
    public static void Main(string[] args)
    {

        Staff objStaff = new Staff();
        objStaff.Name = "Dinh Quang Em";
        objStaff.Age = 30;
        objStaff.Gender = "Female";
        objStaff.Salary = 20000000;

        objStaff.DisplayInfo();
    }
}
