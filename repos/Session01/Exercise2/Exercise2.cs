class Exercise2
{
    public static void Main()
    {
        int num1 = System.Int32.Parse(Console.ReadLine());
        int num2 = System.Int32.Parse(Console.ReadLine());
        int num3 = System.Int32.Parse(Console.ReadLine());

        int max = num1;

        if(num1 < num2)
        {
            max = num2;
        }
        if(num2 < num3)
        {
            max = num3;
        }
        Console.WriteLine(max);
    }
}
