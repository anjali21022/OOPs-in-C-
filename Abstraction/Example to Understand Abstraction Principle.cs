using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Abstraction_Principle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            SBI sbi = new SBI();
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.CheckBalance();
            sbi.BankTransfer();
            sbi.MiniStatement();

            Console.WriteLine("\nTransaction doing Union Bank");
            UNION uni = new UNION();
            uni.ValidateCard();
            uni.WithdrawMoney();
            uni.CheckBalance();
            uni.BankTransfer();
            uni.MiniStatement();

            Console.Read();
        }
        public class SBI
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
        public class UNION
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
}
