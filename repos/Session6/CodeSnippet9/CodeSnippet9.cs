class Student
{
    string _studentName = "James";
    string _address = "California";
    public virtual void PrintDetails()
    {
        Console.WriteLine("Student Name: " + _studentName);
        Console.WriteLine("Student Address: " + _address);
    }
}
class Grade : Student
{
    string _class = "Four";
    float _percent = 71.25F;
    public override void PrintDetails()
    {
        Console.WriteLine("Class: " + _class);
        Console.WriteLine("Percentage: " + (float)_percent);
    }
    static void Main(string[] args)
    {
        Student objStudent = new Student();
        Grade objGrade = new Grade();
        objGrade.PrintDetails();
        objStudent.PrintDetails();
    }
}
