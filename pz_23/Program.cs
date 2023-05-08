namespace pz_23
{
     class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1, "test1@test.com", "user1", "pass1", new DateTime(2021, 5, 8));
            Account acc2 = new Account(2, "test2@test.com", "user2", "pass2", new DateTime(2021, 5, 7));
            Account acc3 = new Account(3, "test3@test.com", "user3", "pass3", new DateTime(2021, 5, 6));

            DeletedAccount delAcc1 = new DeletedAccount(4, "test4@test.com", "user4", "pass4", new DateTime(2021, 5, 5), "spam");
            DeletedAccount delAcc2 = new DeletedAccount(5, "test5@test.com", "user5", "pass5", new DateTime(2021, 5, 4), "inactivity");
            DeletedAccount delAcc3 = new DeletedAccount(6, "test6@test.com", "user6", "pass6", new DateTime(2021, 5, 3), "violation");

            Console.WriteLine(acc1.PrintInfo());
            Console.WriteLine(acc2.PrintInfo());
            Console.WriteLine(acc3.PrintInfo());

            Console.WriteLine(delAcc1.PrintInfo());
            Console.WriteLine(delAcc2.PrintInfo());
            Console.WriteLine(delAcc3.PrintInfo());
        }
    }
}