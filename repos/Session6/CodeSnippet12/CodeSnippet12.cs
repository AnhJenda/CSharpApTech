class Area
{
    static int CalculateArea(int len, int wide)
    {
        return len * wide;
    }
    static double CalculateArea(double valOne, double valTwo)
    {
        return 0.5 * valOne * valTwo;
    }
    static void Main(string[] args)
    {
        int length = 10;
        int breadth = 22;
        double tbase = 1.5;
        double theight = 2.5;

        Console.WriteLine("Area of rectangle: " + CalculateArea(length, breadth));
        Console.WriteLine("Area of triangle: " + CalculateArea(tbase, theight));
    }
}
