using System;
using ProjectAccount.Entities;

namespace ProjectAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(5509, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //error
            //account.Balance = 200.0;
        }
    }
}