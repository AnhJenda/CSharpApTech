class Exercise4
{
    public static void Main(String[] args)
    {
        do
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
            }
        }while(true);
    }
}
