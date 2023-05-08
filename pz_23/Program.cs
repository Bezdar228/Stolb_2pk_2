namespace pz_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем несколько объектов класса Account
            Account account1 = new Account(1, "email1@mail.com", "l@gin1", "p@ssword", new DateTime(2022, 4, 1));
            Account account2 = new Account(2, "email2@mail.com", "l@gin2", "p@ssword", new DateTime(2022, 4, 2));
            Account account3 = new Account(3, "email3@mail.com", "l@gin3", "p@ssword", new DateTime(2022, 4, 3));

            // Выводим информацию о каждом объекте класса Account
            account1.PrintInfo();
            account2.PrintInfo();
            account3.PrintInfo();

            // Создаем несколько объектов класса DeletedAccount
            DeletedAccount deletedAccount1 = new DeletedAccount(4, "email4@mail.com", "l@gin4", "p@ssword", new DateTime(2022, 4, 4), "неактивный аккаунт");
            DeletedAccount deletedAccount2 = new DeletedAccount(5, "email5@mail.com", "l@gin5", "p@ssword", new DateTime(2022, 4, 5), "нарушение правил использования");
            DeletedAccount deletedAccount3 = new DeletedAccount(6, "email6@mail.com", "l@gin6", "p@ssword", new DateTime(2022, 4, 6), "удаление по желанию пользователя");

            // Выводим информацию о каждом объекте класса DeletedAccount
            deletedAccount1.PrintInfo();
            deletedAccount2.PrintInfo();
            deletedAccount3.PrintInfo();
        }
    }
}
