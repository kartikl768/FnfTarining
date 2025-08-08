using System.Runtime.InteropServices.Marshalling;

namespace BankDemo
{
    abstract class Account
    {
        static int _accountNo = 1000;
        public int AccountNo { get; private set; }
        public string AccountHolder { get; set; }

        // create a constructor
        public Account()
        {
            AccountNo = ++_accountNo;
        }
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(" invalid deposit");
                return;
            }
            Balance += amount;
            Console.WriteLine($" the {amount} deposited and the new balance is {Balance}");
        }
        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient balnce");
            }
            Balance -= amount;
            Console.WriteLine($" the amount debited is{amount} and the new Balance is {Balance}");
        }

        // the class which have one or more abstract methods must have a abstract keyword.
        // such that these cant be instantiated as they are contain the methods with incomplete body;
        public abstract void CalculateInterest();

    }
    class FDAccount : Account
    {
        public double interestrate { get; set; } = 0.8;
        public int Months { get; set; }
        public FDAccount(string accountHolder, int months)
        {
            AccountHolder = accountHolder;
            Months = months;
        }
        public override void CalculateInterest()

        {
            //P(1+r/n)^n*t
            Console.WriteLine("enter the interest rate and the months");
            double ir = Convert.ToDouble(Console.ReadLine());
            int months = Convert.ToInt32(Console.ReadLine());
            interestrate = (ir * Balance * months) / 100;
            Deposit(interestrate);
            Console.WriteLine($"Interest earned on Fixed Deposit Account: {interestrate} ");
        }
    }
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } = .025;
        public SavingsAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
        }
        public override void CalculateInterest()
        {
            double interest = Balance * InterestRate / 100;
            Deposit(interest); // Adding interest to the balance
            Console.WriteLine($"Interest earned on Savings Account: {interest}");
        }
    }

    class RecurringDepositAccount : Account
    {
        public double InterestRate { get; set; } = 0.05;
        public double MonthlyDeposit { get; set; }
        public int Months { get; set; }
        public RecurringDepositAccount(string accountHolder, double monthlyDeposit, int months)
        {
            AccountHolder = accountHolder;
            MonthlyDeposit = monthlyDeposit;
            Months = months;
        }
        public override void CalculateInterest()
        {
            // Formula for Recurring Deposit Interest:
            // Interest = P * n(n+1) * r / (2*12*100)
            // P = MonthlyDeposit, n = Months, r = annual interest rate (assume 5%)
            double r = 5.0;
            double interest = (MonthlyDeposit * Months * (Months + 1) * r) / (2 * 12 * 100);
            Deposit(interest); // Adding interest to the balance
            Console.WriteLine($"Interest earned on Recurring Deposit Account: {interest}");
        }
    }
}




namespace SampleConApp
{
    using BankDemo;
    internal class ex11AbstractClasses
    {
        //static Account AccType()
        //{
        //    Console.WriteLine("");

        //}
        
        static void Main(string[] args)
        {
            //Account acc = AccType();
            //Account acc = new FDAccount("Kartik", 36);
            //acc.Deposit(5000);
            //acc.Withdraw(399);
            //acc.CalculateInterest();
            //Console.WriteLine($"the new balance is {acc.Balance}");
            //Account acc1= new RecurringDepositAccount("ajay", 15000,24);
            //acc1.Deposit(500);
            //acc1.Withdraw(50);
            //acc1.CalculateInterest();
            //Console.WriteLine($"the new balance is {acc1.Balance}");
        }
    }
}
