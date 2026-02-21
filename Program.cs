using System;

class Program
{
    static void Main()
    {
        string[] transact = new string[10];
        int count = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- CRUD Transactions ---");
            Console.WriteLine("1. Create Transaction");
            Console.WriteLine("2. Read Transactions");
            Console.WriteLine("3. Update Transaction");
            Console.WriteLine("4. Delete Transaction");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");
            string choices = Console.ReadLine();

            switch (choices)
            {
                case "1":
                    if (count < transact.Length)
                    {
                        Console.Write("Enter transaction: ");
                        transact[count] = Console.ReadLine();
                        count++;
                        Console.WriteLine("Transaction is added.");
                    }
                    else
                    {
                        Console.WriteLine("Transaction list full.");
                    }
                    break;
                case "2":
                    Console.WriteLine("\nTransactions:");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {transact[i]}");
                    }
                    break;
                case "3":
                    Console.Write("Enter transaction number to update: ");
                    int updateIndex = int.Parse(Console.ReadLine()) - 1;
                    if (updateIndex >= 0 && updateIndex < count)
                    {
                        Console.Write("Enter new value: ");
                        transact[updateIndex] = Console.ReadLine();
                        Console.WriteLine("Transaction updated.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid transaction number. ");   
                    }
        }
    }
}