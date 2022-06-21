class AnonTypes
{
    static void Main(String[] args)
    {
        var p1 = new { Name = "A", price = 3 };
        Console.WriteLine("Name = {0}\nPrice = {1}", p1.Name.ToLower(), p1.price);
        Console.ReadLine();
    }
}
