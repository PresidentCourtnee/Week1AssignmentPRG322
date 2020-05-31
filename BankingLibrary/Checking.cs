using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{//This checking class is inhariting from the Account class
    public class Checking : Account
    {// Here is am setting some variables
        public string AcctName;
        public double AcctNum;
        public double DepAmount;
        public double WDAmount;
        public double TransAmt;
        public int AcctBal;
    
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
