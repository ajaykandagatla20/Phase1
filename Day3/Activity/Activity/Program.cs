using System;

namespace Activity
{
    class BankAccount
    {
        public string AccountHolder;
        protected long AccountNumber;
        private double Balance;
        internal string BankName;
        public BankAccount(string accountHolder, long accountNumber, double balance, string bankName)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
            BankName = bankName;
        }
        public void ShowAccountDetails()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Bank Name: {BankName}");
        }
    }
    class SavingAccount : BankAccount
    {
        public SavingAccount(string accountHolder, long accountNumber, double balance, string bankName)
            : base(accountHolder, accountNumber, balance, bankName) { }
        public void ShowAccountNumber()
        {
            Console.WriteLine($"Accessing Protected Account Number: {AccountNumber}");
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount b = new BankAccount("Ajay", 9876598765, 100000000.00, "Ajay Bank of India");
            Console.WriteLine($"Account Holder: {b.AccountHolder}");
            Console.WriteLine($"Bank Name: {b.BankName}");
            SavingAccount s = new SavingAccount("Ajay", 123123123, 1000000000.00, "Ajay Bank of India");
            s.ShowAccountDetails();
            s.ShowAccountNumber();
        }
    }
}