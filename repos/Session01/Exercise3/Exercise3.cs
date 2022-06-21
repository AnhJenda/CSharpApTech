class Exercise3
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Nhap 1 so bat ki tu 1 toi 7: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 7)
        {
            Console.WriteLine("Khong hop le!");
        }
        switch (n)
        {
            case 1: Console.WriteLine("its Monday");
                break;
            case 2: Console.WriteLine("its Tuesday");
                break;
            case 3: Console.WriteLine("its wednesday");
                break;
            case 4:
                Console.WriteLine("its thursday");
                break;
            case 5:
                Console.WriteLine("its friday");
                break;
            case 6:
                Console.WriteLine("its saturday");
                break;
            case 7:
                Console.WriteLine("its sunday");
                break;
        }
    }
}
