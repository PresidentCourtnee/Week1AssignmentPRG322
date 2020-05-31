using BankingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{ // The is the main program that has a referrence to the BankingLibrary which has the 
    //checking, saving subclasses and the account base class
    class Program
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking();
            Savings savings = new Savings();

            checking.AcctName = "Primary Checking";
            savings.AcctName = "Primary Savings";

            Console.WriteLine(checking);
            Console.WriteLine(savings);
        }
    }
}
