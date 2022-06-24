class Exercise5
{
    public static void Main(String[] args)
    {
        Console.WriteLine("the factorials of the integers from 1 to 20: ");

        double fac = 1;
        for(int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Giai thua cua so {0} la: ", i);
            fac *= i;
            Console.WriteLine("{0}", (ulong)fac);
            Console.WriteLine("-------------------");
        }
    }
}