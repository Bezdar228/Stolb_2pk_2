namespace pz_22._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание аккаунта с заданными параметрами
            Account account1 = new Account(1, "example@gmail.com", "us@er1", "p@ssword123", new DateTime(2022, 1, 1));

            // Вывод информации об аккаунте
            account1.PrintInfo();

            // Изменение пароля аккаунта
            account1.Pass = "newp@ssword123";

            // Вывод информации об аккаунте после изменения пароля
            account1.PrintInfo();

            // Создание аккаунта с помощью конструктора, принимающего только id и email
            Account account2 = new Account(2, "example2@gmail.com");

            // Вывод информации об аккаунте
            account2.PrintInfo();

            // Создание аккаунта с помощью конструктора, принимающего только id и email, и изменение пароля
            Account account3 = new Account(3, "example3@gmail.com");
            account3.Pass = "p@ssword123";

            // Вывод информации об аккаунте
            account3.PrintInfo();

            // Вывод количества аккаунтов, созданных начиная с 2020 года
            Console.WriteLine($"Количество аккаунтов, созданных начиная с 2020 года: {Account.AccountsCreatedSince2020}");
        }
    }
}