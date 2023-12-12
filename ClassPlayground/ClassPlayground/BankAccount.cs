using System;

namespace ClassPlayground
{
    internal class BankAccount
    {
        string holderName;
        string currency;
        int accountNumber;
        int balance;

        public BankAccount(string holderName, string currency)
        {
            this.holderName = holderName;
            this.currency = currency;
        }

        public int Deposit()
        {
            Console.WriteLine("Zadej peníze pro vložení");
            balance+=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Aktuální zústatek je {balance}");
            return balance;
        }
        public int Withdraw()
        {
            Console.WriteLine("Zadej částku pro výběr");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw > balance || withdraw==0)
            {
                Console.WriteLine("Toto není platný výběr");
            }
            else
            {
                balance -= withdraw;
                Console.WriteLine($"Bylo vybráno {withdraw} a aktuální zústatek je {balance}");
                return withdraw;
            }
            return -1;
        }
        public int Transfer(int balance)
        {
            return -1;
        }
    }  
}
