using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class Savings:Account
    {
        public string AcctName;
        public double AcctNum;
        public decimal DepAmount;
        public decimal WDAmount;
        public decimal TransAmt;
        private decimal interestRate;
        private decimal minBalanace;
        private decimal savingsBalance;

        public override string ToString()
        {
            return base.ToString() + "\n Account Name: {0}" + AcctName.ToString() + "\n Acount Number: {1}" + AcctNum.ToString() +
                "\nInterest Rate: {3}"+interestRate.ToString()+ "\nMinimum Balance: {4}" +minBalanace.ToString() +"\n Savings Balance: {5}" + 
                savingsBalance.ToString();
        }
    }
}
