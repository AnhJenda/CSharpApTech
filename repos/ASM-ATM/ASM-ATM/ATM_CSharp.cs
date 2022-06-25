class ATM_CSHARP
{
    static double balance1 = 10000000000000;
    static double balance2 = 0;
    static void Main(string[] args)
    {
        int choice;
        Login();
        do
        {
            displayMenu();
            Console.WriteLine("Nhap lua chon: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    withdraw();
                    break;
                case 2:
                    transfer("admin2");
                    break;
                case 3:
                    checkBalance();
                    break;
                default:
                    break;
            }
        } while (choice != 4);
    }

    static void displayMenu()
    {
        Console.WriteLine("1. Rut tien");
        Console.WriteLine("2. Chuyen tien");
        Console.WriteLine("3. Kiem tra so du");
        Console.WriteLine("4. Dong chuong trinh");
    }

    static int Login (string id = "Admin", string pass = "1234admin")
    {
        Console.WriteLine("Nhap username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Nhap password: ");
        string password = Console.ReadLine();

        if(username == id && password == pass)
        {
            Console.WriteLine("Dang nhap thanh cong!");
            return 1;
        } else
        {
            Console.WriteLine("Tai khoan hoac mat khau khong dung");
            return 0;
        }
    }
    static double withdraw()
    {
        Console.WriteLine("So tien muon rut phai lon hon 0 va la boi so của 50000 và khong vuot qua 20000000.");
        Console.WriteLine("Nhap so tien muon rut: ");
        int amount = Int32.Parse(Console.ReadLine());
        if(amount > 0 && amount <= 20000000 && amount % 50000 == 0 && amount <= balance1)
        {
            balance1 -= amount;
            Console.WriteLine("Rut tien thanh cong, tai khoan của ban con: {0}", balance1);
            return balance1;
        } else
        {
            Console.WriteLine("So tien khong hop le!");
            return balance1;
        }
    }
    static double transfer(string toID)
    {
        Console.WriteLine("Nhap tai khoan ban muon chuyen den: ");
        string ID2 = Console.ReadLine();

        if(ID2 == toID)
        {
            Console.WriteLine("Nhap so tien muon chuyen: ");
            int transAmount = Int32.Parse(Console.ReadLine());
            if(transAmount <= balance1 && transAmount > 0)
            {
                balance1 -= transAmount;
                balance2 += transAmount;
                Console.WriteLine("Chuyen tien thanh cong. Tai khoan cua ban con: {0}", balance1);
                return balance1;
            } else
            {
                Console.WriteLine("So tien khong hop le");
                return balance1;
            }
        } else
        {
            Console.WriteLine("Tai khoan chuyen den khong dung");
        }
        return balance1;
    }
    static void checkBalance()
    {
        Console.WriteLine("Tai khoan cua ban con: {0}", balance1);
    }
}