﻿using System;
using ProjectAccount.Entities;

namespace ProjectAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(5509, "Bobison", 0.0);
            BusinessAccount bacc = new BusinessAccount(5905, "Joaquinaina", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Joaquinsom", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anitanita", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}