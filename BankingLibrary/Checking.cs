using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class Checking : Account
    {
        public string AcctName;
        public double AcctNum;
        public double DepAmount;
        public double WDAmount;
        public double TransAmt;
    
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
