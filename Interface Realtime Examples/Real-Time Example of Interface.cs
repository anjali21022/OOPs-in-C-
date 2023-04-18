using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Realtime_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving Account:");
            BankAccount savingAccount = new SavingAccount();
            savingAccount.DepositAmount(2000);
            savingAccount.DepositAmount(1000);
            savingAccount.WithdrawAmount(1500);
            savingAccount.WithdrawAmount(5000);
            Console.WriteLine($"Saving Account Balanace: {savingAccount.CheckBalance()}");

            Console.WriteLine("\nCurrent Account:");
            BankAccount currentAccount = new CurrentAccount();
            currentAccount.DepositAmount(500);
            currentAccount.DepositAmount(1500);
            currentAccount.WithdrawAmount(2600);
            currentAccount.WithdrawAmount(1000);
            Console.WriteLine($"Current Account Balanace: {currentAccount.CheckBalance()}");
            Console.ReadLine();
        }
    }
    interface BankAccount
    {
        bool DepositAmount(decimal amount);
        bool WithdrawAmount(decimal amount);
        decimal CheckBalance();
    }
    public class SavingAccount : BankAccount
    {
        private decimal Balance = 0;
        private readonly decimal PerDayWithdrawLimit = 10000;
        private decimal TodayWithdrawal = 0;
        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }
        //Maximum Withdrawal Per Day: 10000
        public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else if (TodayWithdrawal + Amount > PerDayWithdrawLimit)
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                TodayWithdrawal = TodayWithdrawal + Amount;
                Console.WriteLine($"You have Successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }
    public class CurrentAccount : BankAccount
    {
        private decimal Balance = 0;
        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }
        public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                Console.WriteLine($"You have Successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }
}
