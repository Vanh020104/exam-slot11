using exam_slot11.demo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_slot11
{
    public class Program
    {
        static void Main(string[] args)
        {
            BackAccount account = new BackAccount();

            account.SoDuThayDoi += Account_SoDuThayDoi;


            account.Deposit(1000000);
            account.Withdraw(1000000);
        }

        private static void Account_SoDuThayDoi(object sender, EventArgs e)
        {
            BackAccount account = (BackAccount)sender;
            Console.WriteLine($"Bien dong so du: {account.Balance}");
        }
    }
}
