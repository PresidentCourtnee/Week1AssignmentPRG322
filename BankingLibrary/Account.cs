using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class Account
    {
        public double RoutNum;
        public string CustFName;
        public string CustLName;
        public double PhoneNum;

        public override string ToString()
        {
            return string.Format("Customer First Name: {0}, Customer Last Name: {1}\n Customer Phone Number: {2}\n Routing Number: {3}\n",CustFName,CustLName,PhoneNum,RoutNum);
        }
    }
}
