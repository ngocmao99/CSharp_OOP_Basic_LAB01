using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ap_lab1
{

    class BankAccount
    {
        private int id; // id of account
        private Decimal balance;// balance of account

        //Default Constructor
        public BankAccount()
        {
            id = 0;
            balance = 0;
        }
        // Constructor with properties
        public BankAccount(int Id, decimal Balance)
        {
            Id = id;
            Balance = balance;
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
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Balance = 15;
            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
            Console.ReadKey();
        }
    }
}
