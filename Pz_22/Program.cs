using System;

namespace Pz_22

{
    class Program
    {

        static void Main(string[] args)
        {
            Account account1 = new Account("johndoe", "johndoe@example.com", "1234Abcd!", new DateTime(2021, 10, 1));
            Account account2 = new Account("janedoe", "janedoe@example.com", "5678Efgh#", new DateTime(2020, 2, 14));
            Account account3 = new Account("bobsmith", "bobsmith@example.com", "iLoveCats", new DateTime(2022, 1, 1));

            Console.WriteLine("Number of accounts created since 2020: {0}", Account.GetAccountsSince(2020));

            Account.PrintStaticInfo();
        }
    }
    }
    