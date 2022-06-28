using System;

class ArrayTask07
{
    static void Main(string[] args)
    {
        Array objAuthorID = Array.CreateInstance(typeof(int), 3);
        Array objAuthorName = Array.CreateInstance(typeof(string), 3);
        Array objAddress = Array.CreateInstance(typeof(string), 3);
        Array objState = Array.CreateInstance(typeof(string), 3);

        string input = "";

        for(int i = 0; i < objAuthorName.Length; i++)
        {
            Console.Write("Enter the ID of author: ");
            input = Console.ReadLine();
            objAuthorID.SetValue(Convert.ToInt32(input), i);
            Console.Write("Enter the name: ");
            input = Console.ReadLine();
            objAuthorName.SetValue(input, i);
            Console.Write("Enter the address: ");
            input = Console.ReadLine();
            objAddress.SetValue(input, i);
            Console.Write("Enter the state: ");
            input = Console.ReadLine();
            objState.SetValue(input, i);
            Console.WriteLine();
        }

        // Hien thi dang bang
        Console.WriteLine("\nDatail of the author:\n");
        Console.WriteLine("AuthorID\tAuthorName\t\tAddress\t\t\tState");
        for(int j = 0; j < objAuthorID.Length; j++)
        {
            Console.Write(objAuthorID.GetValue(j) + "\t");
            Console.Write(objAuthorName.GetValue(j) + "\t\t");
            Console.Write(objAddress.GetValue(j) + "\t\t\t");
            Console.WriteLine(objState.GetValue(j));
        }

        // sap xep mang
        Array.Sort(objAuthorName);
        // in ket qua sau khi sap xep
        for(int k = 0; k < objAuthorName.Length; k++)
        {
            Console.WriteLine(objAuthorName.GetValue(k));
        }
    }
}