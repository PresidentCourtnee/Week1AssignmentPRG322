using BankingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking checking = new Checking();
            Savings savings = new Savings();

            checking.AcctName = "Primary Checking";
           
            Console.WriteLine(checking);
            Console.WriteLine(savings);
        }
    }
}
