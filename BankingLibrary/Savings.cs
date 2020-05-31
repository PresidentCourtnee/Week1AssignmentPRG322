using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{//This savings class is inhariting from the Account class
    public class Savings:Account
    {// Here is am setting some variables
        public string AcctName;
        public double AcctNum;
        public decimal DepAmount;
        public decimal WDAmount;
        public decimal TransAmt;
        
        public override string ToString()
        {
            return base.ToString() + "\n Account Name: {0}" + AcctName.ToString() + "\n Acount Number: {1}" + AcctNum.ToString() .ToString();
        }
    }
}
