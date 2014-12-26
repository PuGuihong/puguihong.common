using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common.main.common_8
{
    class Transaction : ITransactions
    {
        private string t_code;
        private string date;
        private double amount;

        public Transaction()
        {
            t_code = "";
            date = "";
            amount = 0.0;
        }
        public Transaction(string tc, string d, double a)
        {
            t_code = tc;
            date = d;
            amount = a;
        }

        public void ShowTransactions()
        {
            Console.WriteLine("Transaction : {0}", t_code);
            Console.WriteLine("Date : {0}", date);
            Console.WriteLine("Amount : {0}", amount);
        }

        public double GetAmount()
        {
            return amount;
        }
    }
}
