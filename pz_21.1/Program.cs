namespace pz_21._1
{
    internal class Program
    {
        static void Main(string[] args)
      
        {
            var acc1 = new Account(1, "email1@example.com", "Флоппа1", "фвйцкайа1");
            var acc2 = new Account(2, "email2@example.com", "Гарфилд", "йцуйуй", new DateTime(2022, 1, 1));
            var acc3 = new Account(3, "email3@example.com", "ыфвфвфвф");
            var acc4 = new Account(4, "email4@example.com");

            acc1.PrintInfo();
            Console.WriteLine();
            acc2.PrintInfo();
            Console.WriteLine();
            acc3.PrintInfo();
            Console.WriteLine();
            acc4.PrintInfo();
        }
    }
}