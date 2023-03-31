using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstraction.Abstraction_Principle;

namespace Abstraction
{
    internal class Abstraction_Principle_using_Interface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            IBank sbi = BankFactory.GetBankObject("SBI");
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.CheckBalance();
            sbi.BankTransfer();
            sbi.MiniStatement();

            Console.WriteLine("\nTransaction doing Union Bank");
            IBank uni = BankFactory.GetBankObject("UNION");
            uni.ValidateCard();
            uni.WithdrawMoney();
            uni.CheckBalance();
            uni.BankTransfer();
            uni.MiniStatement();

            Console.Read();
        }
    }
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalance();
        void BankTransfer();
        void MiniStatement();
    }

    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBI();
            }
            else if (bankType == "UNION")
            {
                BankObject = new UNION();
            }
            return BankObject;
        }
    }
    public class SBI : IBank
    {
        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
        public void CheckBalance()
        {
            Console.WriteLine("SBI Bank Check Balance");
        }
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }
        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }
    }
    public class UNION : IBank
    {
        public void ValidateCard()
        {
            Console.WriteLine("Union Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Union Bank Withdraw Money");
        }
        public void CheckBalance()
        {
            Console.WriteLine("Union Bank Check Balance");
        }
        public void BankTransfer()
        {
            Console.WriteLine("Union Bank Bank Transfer");
        }
        public void MiniStatement()
        {
            Console.WriteLine("Union Bank Mini Statement");
        }
    }
}
