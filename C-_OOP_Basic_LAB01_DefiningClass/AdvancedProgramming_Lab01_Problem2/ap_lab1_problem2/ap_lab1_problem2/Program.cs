using System;

namespace ap_lab1_problem2
{
    class BankAccount
    {
        private int id;
        private decimal balance;
        
        public BankAccount()
        {
            id = 0;
            balance = 0;
        }
        public BankAccount(int Id, decimal Balance)
        {
            id = Id;
            balance = Balance;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        public void Withdrawl(decimal amount)
        {
            if (balance <= amount)
            {
                balance = amount;
            }
            balance -= amount;
        }
        public override string ToString()
        {
            return "Account "+Id+", balance "+Balance;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdrawl(10);
            Console.WriteLine(acc);
            Console.ReadKey();
        }
    }
}
